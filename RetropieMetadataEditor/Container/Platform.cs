using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetropieMetadataEditor.Container
{
    public class Platform
    {
        #region Properties

        public static int RomCount { get; set; }
        public static int ImageCount { get; set; }

        string name;
        public string Name
        {
            get
            {
                return this.name + " (" + ListRoms.Count + ")";
            }
            set
            {
                this.name = value;
            }
        }
        public string NameCoverCount
        {
            get
            {
                return this.name + " (" + ListImages.Length + ")";
            }
        }
        public string NameOnly
        {
            get
            {
                return this.name;
            }
        }
        public string DirectoryName { get; set; }
        public List<string> Extensions { get; set; }
        public string PathRoms { get; set; }
        public string PathGamelist { get; set; }
        public string PathImages { get; set; }
        public string[] ListImages { get; set; }
        public List<Rom> ListRoms { get; set; }
        public BindingList<Rom> ListRomsWithoutMetadata { get; set; }
        public BindingList<Rom> ListRomsWithoutImage { get; set; }
        public XmlDocument XmlGamelist { get; set; }

        #endregion

        public Platform(string name, string directoryName, string[] extensions, bool scanForDirectories, MainForm mainForm)
        {
            mainForm.Log("Initialize System " + name);
            Name = name;
            DirectoryName = directoryName;
            Extensions = extensions.ToList<string>();

            #region Add Default Extensions to the List of supported Extensions

            if (!Extensions.Contains("zip"))
            {
                Extensions.Add("zip");
            }

            if (!Extensions.Contains("7z"))
            {
                Extensions.Add("7z");
            }

            #endregion

            #region Set Paths

            PathRoms = Properties.Settings.Default.PathRoms.Replace("{SYSTEM}", DirectoryName);
            PathGamelist = Path.Combine(Properties.Settings.Default.PathGamelists.Replace("{SYSTEM}", DirectoryName), "gamelist.xml");
            PathImages   = Properties.Settings.Default.PathImages.Replace("{SYSTEM}", DirectoryName);

            #endregion

            #region Load Roms

            ListRoms = new List<Rom>();

            if (Directory.Exists(PathRoms))
            {
                foreach (string romPath in Directory.GetFiles(PathRoms))
                {
                    Rom rom = new Rom(romPath, this, RomType.File);
                    if (Extensions.Contains(rom.RomExtension))
                    {
                        ListRoms.Add(rom);
                    }
                }

                if(scanForDirectories)
                {
                    foreach(string romPath in Directory.GetDirectories(PathRoms))
                    {
                        Rom rom = new Rom(romPath, this, RomType.Directory);
                        ListRoms.Add(rom);
                    }
                }
            }

            RomCount += ListRoms.Count;
            mainForm.Log("   ...Roms found: " + ListRoms.Count);
            if (ListRoms.Count > 0)
            {
                Program.ListPlatforms.Add(this);
                mainForm.Log("   ...ADDED");
            }
            else
            {
                mainForm.Log("   ...IGNORED");
                return;
            }

            #endregion

            #region Load Gamelist

            mainForm.Log("   ...Load Gamelist XML");
            XmlGamelist = new XmlDocument();
            XmlGamelist.Load(PathGamelist);
            mainForm.Log("   ...SUCCESSFULLY");

            #endregion

            #region Images

            mainForm.Log("   ...Load Images");
            LoadImages(mainForm);
            mainForm.Log("   ...Found Images: " + ListImages.Length);

            ImageCount += ListImages.Length;
            if (ListImages.Length > ListRoms.Count)
            {
                mainForm.Log("   ...This image directory should be cleaned up!");
            }

            #endregion

            LoadMetadata();
        }

        public void LoadMetadata()
        {
            ListRomsWithoutMetadata = new BindingList<Rom>();
            ListRomsWithoutImage = new BindingList<Rom>();

            foreach (Rom item in ListRoms)
            {
                item.LoadMetadata();
                if (item.NoMetadata)
                {
                    ListRomsWithoutMetadata.Add(item);
                    ListRomsWithoutImage.Add(item);
                }
                else if (item.NoImage)
                {
                    ListRomsWithoutImage.Add(item);
                }
            }
        }

        public void LoadImages(MainForm mainForm)
        {
            if (!Directory.Exists(PathImages))
            {
                mainForm.Log("   ...No image directory was found");
                Directory.CreateDirectory(PathImages);
                mainForm.Log("   ...Image directory was successfully created!");
            }
            ListImages = Directory.GetFiles(PathImages);
        }

        public XmlNodeList GetGameNodes()
        {
            return XmlGamelist.DocumentElement.SelectNodes("game");
        }

        public void DeleteGameNode(XmlNode gameNode)
        {
            XmlGamelist.DocumentElement.RemoveChild(gameNode);
            XmlGamelist.Save(PathGamelist);
        }

        public bool ExistsRom(string path)
        {
            foreach(Rom rom in ListRoms)
            {
                if(rom.MetaPath == path)
                {
                    return true;
                }                
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

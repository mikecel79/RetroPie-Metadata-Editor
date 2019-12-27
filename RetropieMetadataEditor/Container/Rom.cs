using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Globalization;

namespace RetropieMetadataEditor.Container
{
    public enum RomType
    {
        File,
        Directory
    }

    public class Rom
    {
        #region Properties

        public Platform Platform { get; set; }
        public RomType RomType { get; set; }
        public string Name { get; set; }
        public string NameWithoutExtension { get; set; }
        public string RomPath { get; set; }
        public string RomExtension { get; set; }
        public FileInfo RomInfo { get; set; }
        public XmlNode MetaXmlNode { get; set; }
        public string MetaPath { get; set; }
        public string MetaName { get; set; }
        public string MetaDesc { get; set; }
        public string MetaImage { get; set; }
        public string MetaVideo { get; set; }
        public string MetaMarquee { get; set; }
        public string MetaRating { get; set; }
        public decimal MetaRatingDecimal { get; set; }
        public string MetaReleasdate { get; set; }
        public DateTime MetaReleasdateDatetime { get; set; }
        public string MetaDeveloper { get; set; }
        public string MetaPublisher { get; set; }
        public string MetaGenre { get; set; }
        public string MetaPlayers { get; set; }
        public int MetaPlayersInt { get; set; }
        public string MetaPlaycount { get; set; }
        public int MetaPlaycountInt { get; set; }
        public string MetaLastplayed { get; set; }
        public DateTime MetaLastplayedDatetime { get; set; }
        public string ImagePath { get; set; }
        public FileInfo ImageInfo { get; set; }
        public bool NoMetadata { get; set; }
        public bool NoImage { get; set; }

        #endregion

        public Rom(string romPath, Platform platform, RomType romType)
        {
            Platform = platform;
            RomType = romType;
            RomPath = romPath;
            RomInfo = new FileInfo(RomPath);
            Name = RomInfo.Name;
            NameWithoutExtension = RomInfo.Name;
            if (RomInfo.Extension != null && RomInfo.Extension != string.Empty)
            {
                NameWithoutExtension = Name.Replace(RomInfo.Extension, string.Empty);
            }
            RomExtension = RomInfo.Extension.ToLower().Replace(".", string.Empty);
        }

        public void LoadMetadata()
        {
            MetaXmlNode = Platform.XmlGamelist.DocumentElement.SelectSingleNode("game[path = \"./" + RomInfo.Name + "\"]");

            if (MetaXmlNode != null)
            {
                NoMetadata = false;
                MetaPath = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("path"));
                MetaName = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("name"));
                MetaDesc = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("desc"));
                MetaImage = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("image"));
                MetaVideo = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("video"));
                MetaMarquee = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("marquee"));
                MetaRating = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("rating"));
                MetaReleasdate = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("releasedate"));
                MetaReleasdateDatetime = Library.ParseDatetime(MetaReleasdate);
                MetaDeveloper = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("developer"));
                MetaPublisher = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("publisher"));
                MetaGenre = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("genre"));
                MetaPlayers = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("players"));
                int players = 0;
                int.TryParse(MetaPlayers, out players);
                MetaPlayersInt = players;
                MetaPlaycount = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("playcount"));
                int playCount = 0;
                int.TryParse(MetaPlaycount, out playCount);
                MetaPlaycountInt = playCount;
                MetaLastplayed = Library.GetXmlValue(MetaXmlNode.SelectSingleNode("lastplayed"));
                MetaLastplayedDatetime = Library.ParseDatetime(MetaLastplayed);

                if (MetaImage != string.Empty)
                {
                    NoImage = false;
                    ImageInfo = new FileInfo(MetaImage);
                    ImagePath = Path.Combine(Platform.PathImages, ImageInfo.Name);
                    ImageInfo = new FileInfo(ImagePath);

                }
                else
                {
                    NoImage = true;
                }
            }
            else
            {
                NoMetadata = true;
            }

        }

        public void Save()
        {
            // Create a new XML-Node, if no Metadata exists
            if (NoMetadata || MetaXmlNode == null)
            {
                XmlElement xmlElement = Platform.XmlGamelist.CreateElement("game");
                MetaXmlNode = Platform.XmlGamelist.DocumentElement.AppendChild(xmlElement);

                UpdateXmlNode("path", MetaPath);
                NoMetadata = false;
                Platform.ListRomsWithoutMetadata.Remove(this);
            }

            UpdateXmlNode("name", MetaName);
            UpdateXmlNode("genre", MetaGenre);
            UpdateXmlNode("developer", MetaDeveloper);
            UpdateXmlNode("publisher", MetaPublisher);
            UpdateXmlNode("desc", MetaDesc);
            UpdateXmlNode("video", MetaVideo);
            UpdateXmlNode("marquee", MetaMarquee);

            if (MetaPlaycountInt > 0)
            {
                UpdateXmlNode("playcount", MetaPlaycount);
            }
            else
            {
                UpdateXmlNode("playcount", string.Empty);
            }
            if (MetaPlayersInt > 0)
            {
                UpdateXmlNode("players", MetaPlayers);
            }
            else
            {
                UpdateXmlNode("players", string.Empty);
            }
            if (MetaReleasdateDatetime != DateTime.MinValue)
            {
                string rlsDate = MetaReleasdateDatetime.Year.ToString();
                rlsDate += Library.Add0(MetaReleasdateDatetime.Month.ToString());
                rlsDate += Library.Add0(MetaReleasdateDatetime.Day.ToString());
                rlsDate += "T000000";
                UpdateXmlNode("releasedate", rlsDate);
            }
            else
            {
                UpdateXmlNode("releasedate", string.Empty);
            }

            Platform.XmlGamelist.Save(Platform.PathGamelist);
        }

        public void Delete()
        {
            // Delete From Lists
            Platform.ListRoms.Remove(this);
            Platform.ListRomsWithoutImage.Remove(this);
            Platform.ListRomsWithoutMetadata.Remove(this);
            //Platform.ListImages.Remove(ImagePath)            
            --Platform.RomCount;
            //--Platform.ImageCount;

            // Delete Rom
            File.Delete(RomPath);

            // Delete Cover
            File.Delete(ImagePath);

            // Delete Metadata from List and Save
            MetaXmlNode.ParentNode.RemoveChild(MetaXmlNode);
            Platform.XmlGamelist.Save(Platform.PathGamelist);

        }

        public void AddImage(string sourceFile)
        {
            if (NoMetadata)
            {
                Save();
            }

            // Delete existing File
            if (!NoImage && File.Exists(ImagePath))
            {
                File.Delete(ImagePath);
            }

            // Get Name of Destination-File
            FileInfo sourceFileInfo = new FileInfo(sourceFile);
            string destinationFileName = NameWithoutExtension + Properties.Settings.Default.ImageNameSuffix + sourceFileInfo.Extension;
            ImagePath = Path.Combine(Platform.PathImages, destinationFileName);

            // Copy File to Retropie
            File.Copy(sourceFile, ImagePath, true);

            // Update Metadata
            MetaImage = Properties.Settings.Default.PathImagesLocal.Replace("{SYSTEM}", Platform.DirectoryName) + "/" + destinationFileName;
            UpdateXmlNode("image", MetaImage);
            Platform.XmlGamelist.Save(Platform.PathGamelist);
            ImageInfo = new FileInfo(ImagePath);

            //Remove from No-Image-List
            NoImage = false;
            Platform.ListRomsWithoutImage.Remove(this);
        }

        public Size GetImageSize()
        {
            Size result = new Size(0, 0);
            try
            {
                if (!File.Exists(ImagePath))
                {
                    return result;
                }

                FileStream fileStream = new FileStream(ImagePath, FileMode.Open);
                Image image = Image.FromStream(fileStream, false, false);
                result = image.Size;
                fileStream.Close();
            }
            catch { }
            return result;
        }

        #region Helper

        void UpdateXmlNode(string nodeName, string nodeContent)
        {
            XmlNode item = MetaXmlNode.SelectSingleNode(nodeName);

            if (item == null && nodeContent == string.Empty)
            {
                return;
            }

            if (item != null)
            {
                item.InnerText = nodeContent;
            }
            else
            {
                XmlElement xmlElement = Platform.XmlGamelist.CreateElement(nodeName);
                xmlElement.InnerText = nodeContent;
                MetaXmlNode.AppendChild(xmlElement);
            }
        }

        #endregion
    }
}

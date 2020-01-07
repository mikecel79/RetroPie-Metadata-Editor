using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using RetropieMetadataEditor.Container;

namespace RetropieMetadataEditor
{
    public partial class MainForm : Form
    {
        #region Properties

        Rom CurrentRom = null;
        StringBuilder ExportList = new StringBuilder();

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            this.Text = "RetroPie Metadata Editor v" + Application.ProductVersion + " BETA";
                        
            LoadSettings();
        }

        #endregion

        #region Tab: Configuration

        void LoadSettings()
        {
            textBoxSettingsPathRoms.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "PathRoms",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxSettingsPathGamelists.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "PathGamelists",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxSettingsPathImages.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "PathImages",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxSettingsImageSuffix.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "ImageNameSuffix",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxSettingsImageEditingSoftware.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "ImageEditingSoftware",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxSettingsLocalImagePath.DataBindings.Add
            (
                "Text",
                Properties.Settings.Default,
                "PathImagesLocal",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

        }

        private void buttonConnectToRetropie_Click(object sender, EventArgs e)
        {
            Platform.RomCount = 0;
            Platform.ImageCount = 0;

            // System initialisieren
            Program.ListPlatforms.Clear();
            new Platform("Amiga", "amiga", new string[] { "adf", "dms", "exe", "adz", "rp9", "uae", "sh" }, false, this);
            new Platform("Arcade", "arcade", new string[] { "zip" }, false, this);
            new Platform("Atari 2600", "atari2600", new string[] { "bin", "a26", "rom" }, false, this);
            new Platform("Atari 7800", "atari7800", new string[] { "a78", "bin" }, false, this);
            new Platform("Atari Lynx", "atarilynx", new string[] { "lnx" }, false, this);
            new Platform("Atari Jaguar", "atarijaguar", new string[] { "j64", "jag" }, false, this);
            new Platform("Daphne", "daphne", new string[] { "daphne" }, true, this);
            new Platform("Game Boy", "gb", new string[] { "gb" }, false, this);
            new Platform("Game Boy Advance", "gba", new string[] { "gba" }, false, this);
            new Platform("Game Boy Color", "gbc", new string[] { "gbc" }, false, this);
            new Platform("Game Gear", "gamegear", new string[] { "gg" }, false, this);
            new Platform("MAME libretro", "mame-libretro", new string[] { "zip" }, false, this);
            new Platform("MAME4All", "mame-mame4all", new string[] { "zip" }, false, this);
            new Platform("Master System", "mastersystem", new string[] { "sms" }, false, this);
            new Platform("Mega Drive", "megadrive", new string[] { "smd", "bin", "md", "iso", "gen" }, false, this);
            new Platform("Neo Geo", "neogeo", new string[] { "zip" }, false, this);
            new Platform("Neo Geo Pocket", "ngp", new string[] { "ngp" }, false, this);
            new Platform("Neo Geo Pocket Color", "ngpc", new string[] { "ngc" }, false, this);
            new Platform("Nintendo 64", "n64", new string[] { "z64", "n64", "v64" }, false, this);
            new Platform("Nintendo DS", "nds", new string[] { "nds", "bin" }, false, this);
            new Platform("NES", "nes", new string[] { "zip", "nes", "smc", "sfc", "fig", "swc", "mgd" }, false, this);
            // PC is removed because of use of folder XML in gamelist
            //new Platform("PC", "pc", new string[] { "com", "sh", "bat", "exe" }, true, this);
            new Platform("PC Engine", "pcengine", new string[] { "pce", "cue", "zip" }, false, this);
            new Platform("PlayStation 1", "psx", new string[] { "cue", "cbn", "img", "iso", "m3u", "mdf", "pbp", "toc", "z", "znx" }, false, this);
            new Platform("PlayStation Portable", "psp", new string[] { "cso", "iso", "pbp" }, false, this);
            new Platform("Ports", "ports", new string[] { "sh" }, false, this);
            new Platform("ScummVM", "scummvm", new string[] { "svm", "sh" }, false, this);
            new Platform("Sega 32X", "sega32x", new string[] { "32x", "smd", "bin", "md" }, false, this);
            new Platform("Sega CD", "segacd", new string[] { "cue", "iso" }, false, this);
            new Platform("SG-1000", "sg-1000", new string[] { "sg", "zip" }, false, this);
            new Platform("Super NES", "snes", new string[] { "zip", "smc", "sfc", "fig", "swc" }, false, this);
            new Platform("Vectrex", "vectrex", new string[] { "vec", "gam", "bin" }, false, this);
            new Platform("Virtual Boy", "virtualboy", new string[] { "vb" }, false, this);
            new Platform("WonderSwan", "wonderswan", new string[] { "ws" }, false, this);
            new Platform("WonderSwan Color", "wonderswancolor", new string[] { "wsc" }, false, this);

            Log("============================================================");
            Log("Total Games: " + Platform.RomCount);
            Log("Total Images: " + Platform.ImageCount);

            comboBoxPlatform.DataSource = Program.ListPlatforms;
            comboBoxPlatform.DisplayMember = "Name";
            comboBoxPlatform_SelectedValueChanged(null, null);

            comboBoxCoverCleanUp.DataSource = Program.ListPlatforms;
            comboBoxCoverCleanUp.DisplayMember = "NameCoverCount";

            comboBoxGamelistCleanUp.DataSource = Program.ListPlatforms;
            comboBoxGamelistCleanUp.DisplayMember = "Name";

            checkedListBoxSystems.Items.Clear();
            foreach (Platform platform in Program.ListPlatforms)
            {
                checkedListBoxSystems.Items.Add(platform, true);
            }
        }
        
        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void buttonRestoreDefaultSettings_Click(object sender, EventArgs e)
        {
            textBoxSettingsPathRoms.Text = @"\\retropie\roms\{SYSTEM}";
            textBoxSettingsPathGamelists.Text = @"\\retropie\configs\all\emulationstation\gamelists\{SYSTEM}";
            textBoxSettingsPathImages.Text = @"\\retropie\configs\all\emulationstation\downloaded_images\{SYSTEM}";
            textBoxSettingsImageEditingSoftware.Text = @"%windir%\system32\mspaint.exe";
            textBoxSettingsImageSuffix.Text = @"-image";
            textBoxSettingsLocalImagePath.Text = @"/home/pi/.emulationstation/downloaded_images/{SYSTEM}";

            buttonSaveSettings_Click(sender, e);
        }
                
        
        public void Log(string message)
        {
            textBoxLog.AppendText(message + Environment.NewLine);
            textBoxLog.ScrollToCaret();
        }

        #endregion

        #region Tab: Editor

        private void comboBoxPlatform_SelectedValueChanged(object sender, EventArgs e)
        {
            Platform currentPlatform = (Platform)comboBoxPlatform.SelectedItem;
            if (currentPlatform != null)
            {
                currentPlatform.LoadMetadata();
                listBoxRoms.DataSource = currentPlatform.ListRoms;
                listBoxRoms.DisplayMember = "Name";
            }
            radioButtonAll.Checked = true;
        }

        private void radioButtonRomlistFilter_CheckedChanged(object sender, EventArgs e)
        {
            Platform currentPlatform = (Platform)comboBoxPlatform.SelectedItem;
            if (currentPlatform != null)
            {
                switch (((RadioButton)sender).Name)
                {
                    case "radioButtonNoMetadata":
                        listBoxRoms.DataSource = currentPlatform.ListRomsWithoutMetadata;
                        break;

                    case "radioButtonNoImage":
                        listBoxRoms.DataSource = currentPlatform.ListRomsWithoutImage;
                        break;

                    default:
                        listBoxRoms.DataSource = currentPlatform.ListRoms;
                        break;
                }
                listBoxRoms.DisplayMember = "Name";
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            if (CurrentRom == null)
            {
                return;
            }
            buttonSave_Click(null, null);
            Rom rememberRom = CurrentRom;

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                CurrentRom.AddImage(openFileDialogImage.FileName);
                if (radioButtonAll.Checked)
                {
                    ShowCover();
                }
                else
                {
                    radioButtonAll.Checked = true;
                    listBoxRoms.SelectedItem = rememberRom;
                }
            }
        }
        
        private void buttonEditImage_Click(object sender, EventArgs e)
        {
            if (CurrentRom != null && CurrentRom.ImagePath != string.Empty)
            {
                Process process = new Process();
                process.StartInfo.FileName = Properties.Settings.Default.ImageEditingSoftware;
                process.StartInfo.Arguments = "\"" + CurrentRom.ImagePath + "\"";
                process.Start();
            }
        }

        private void ShowCover()
        {
            if (CurrentRom != null && CurrentRom.ImagePath != string.Empty && CurrentRom.ImagePath != null)
            {
                CurrentRom.ImageInfo = new FileInfo(CurrentRom.ImagePath);
                pictureBoxCover.ImageLocation = CurrentRom.ImagePath;
                Size imageSize = CurrentRom.GetImageSize();
                labelImage.Text = "Image: " + imageSize.Width + " x " + imageSize.Height + " Pixel   - - -   " + Library.GetFileSize(CurrentRom.ImageInfo.Length);
            }
            else
            {
                pictureBoxCover.ImageLocation = null;
                labelImage.Text = "No Image available";
            }
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {
            ShowCover();
        }

        private void listBoxRoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRoms.SelectedItem != null)
            {
                CurrentRom = (Rom)listBoxRoms.SelectedItem;

                textBoxPath.Text = CurrentRom.MetaPath;
                if (CurrentRom.MetaName != null && CurrentRom.MetaName != string.Empty)
                {
                    textBoxName.Text = CurrentRom.MetaName;
                }
                else
                {
                    textBoxName.Text = CurrentRom.NameWithoutExtension;
                }
                textBoxDescription.Text = CurrentRom.MetaDesc;
                textBoxImage.Text = CurrentRom.MetaImage;
                textBoxRating.Text = CurrentRom.MetaRating;
                if (CurrentRom.MetaReleasdateDatetime != DateTime.MinValue)
                {
                    dateTimePickerReleaseDate.Value = CurrentRom.MetaReleasdateDatetime;
                    dateTimePickerReleaseDate.Checked = true;
                }
                else
                {
                    dateTimePickerReleaseDate.Value = DateTime.Now;
                    dateTimePickerReleaseDate.Checked = false;
                }
                textBoxDeveloper.Text = CurrentRom.MetaDeveloper;
                textBoxPublisher.Text = CurrentRom.MetaPublisher;
                textBoxGenre.Text = CurrentRom.MetaGenre;
                numericUpDownPlayCount.Value = CurrentRom.MetaPlaycountInt;
                numericUpDownPlayers.Value = CurrentRom.MetaPlayersInt;
                if (CurrentRom.MetaLastplayedDatetime != DateTime.MinValue)
                {
                    textBoxLastPlayed.Text = CurrentRom.MetaLastplayedDatetime.ToString();
                }
                else
                {
                    textBoxLastPlayed.Text = string.Empty;
                }
                if (textBoxPath.Text == string.Empty)
                {
                    textBoxPath.Text = "./" + CurrentRom.RomInfo.Name;
                    CurrentRom.MetaPath = textBoxPath.Text;
                }

                textBoxVideo.Text = CurrentRom.MetaVideo;
                textBoxMarguee.Text = CurrentRom.MetaMarquee;
                ShowCover();
            }
            else
            {
                CurrentRom = null;

                textBoxPath.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxDescription.Text = string.Empty;
                textBoxImage.Text = string.Empty;
                textBoxVideo.Text = string.Empty;
                textBoxMarguee.Text = string.Empty;
                textBoxRating.Text = string.Empty;
                dateTimePickerReleaseDate.Value = DateTime.Now;
                dateTimePickerReleaseDate.Checked = false;
                textBoxDeveloper.Text = string.Empty;
                textBoxPublisher.Text = string.Empty;
                textBoxGenre.Text = string.Empty;
                numericUpDownPlayCount.Value = 0;
                numericUpDownPlayers.Value = 0;
                textBoxLastPlayed.Text = string.Empty;
                pictureBoxCover.ImageLocation = null;
                labelImage.Text = "No Image available";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CurrentRom != null)
            {
                Rom rememberRom = CurrentRom;

                CurrentRom.MetaName = textBoxName.Text;
                CurrentRom.MetaGenre = textBoxGenre.Text;
                CurrentRom.MetaDeveloper = textBoxDeveloper.Text;
                CurrentRom.MetaPublisher = textBoxPublisher.Text;
                CurrentRom.MetaDesc = textBoxDescription.Text;
                CurrentRom.MetaVideo = textBoxVideo.Text;
                CurrentRom.MetaMarquee = textBoxMarguee.Text;
                CurrentRom.MetaPlaycount = numericUpDownPlayCount.Value.ToString();
                CurrentRom.MetaPlaycountInt = (int)numericUpDownPlayCount.Value;
                CurrentRom.MetaPlayers = numericUpDownPlayers.Value.ToString();
                CurrentRom.MetaPlayersInt = (int)numericUpDownPlayers.Value;
                if (dateTimePickerReleaseDate.Checked)
                {
                    CurrentRom.MetaReleasdateDatetime = dateTimePickerReleaseDate.Value;
                }
                else
                {
                    CurrentRom.MetaReleasdateDatetime = DateTime.MinValue;
                }

                CurrentRom.Save();

                if (!radioButtonAll.Checked)
                {
                    radioButtonAll.Checked = true;
                    listBoxRoms.SelectedItem = rememberRom;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CurrentRom == null)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Should the game '" + CurrentRom.Name + "' be really deleted?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CurrentRom.Delete();
                CurrentRom = null;
                ShowCover();
                listBoxRoms_SelectedIndexChanged(null, null);
            }
        }

        #endregion

        #region Tab: Clean Up

        private void buttonStartCleanUp_Click(object sender, EventArgs e)
        {
            Platform currentPlatform = (Platform)comboBoxCoverCleanUp.SelectedItem;
            int coverDeletedCount = 0;
            if (currentPlatform != null)
            {
                LogCoverCleanUp("Start Cover Clean Up " + currentPlatform.NameOnly);
                currentPlatform.LoadMetadata();

                bool coverFound = false;
                foreach (string cover in currentPlatform.ListImages)
                {
                    coverFound = false;
                    FileInfo coverFI = new FileInfo(cover);
                    foreach (Rom rom in currentPlatform.ListRoms)
                    {
                        if (coverFI.FullName == rom.ImagePath)
                        {
                            coverFound = true;
                            break;
                        }
                    }

                    if (!coverFound)
                    {
                        ++coverDeletedCount;
                        File.Delete(cover);
                        LogCoverCleanUp("DELETE IMAGE --> " + coverFI.Name);
                    }
                }
                LogCoverCleanUp("Deleted Images: " + coverDeletedCount);
                if (coverDeletedCount > 0)
                {
                    currentPlatform.LoadImages(this);
                }
            }
        }

        public void LogCoverCleanUp(string message)
        {
            textBoxCoverDeleted.AppendText(message + Environment.NewLine);
            textBoxCoverDeleted.ScrollToCaret();
        }

        private void buttonStartGamelistCleanUp_Click(object sender, EventArgs e)
        {
            Platform currentPlatform = (Platform)comboBoxGamelistCleanUp.SelectedItem;
            int gameDeletedCount = 0;
            if (currentPlatform != null)
            {
                LogGamelistCleanUp("Start Gamelist Clean Up " + currentPlatform.NameOnly);
                currentPlatform.LoadMetadata();

                foreach(XmlNode xmlNode in currentPlatform.GetGameNodes())
                {
                    string path = Library.GetXmlValue(xmlNode.SelectSingleNode("path"));
                    if(!currentPlatform.ExistsRom(path))
                    {                        
                        ++gameDeletedCount;
                        currentPlatform.DeleteGameNode(xmlNode);
                        LogGamelistCleanUp("DELETE GAME --> " + path);
                    }                    
                }

                LogGamelistCleanUp("Deleted Games: " + gameDeletedCount);                
            }
        }

        public void LogGamelistCleanUp(string message)
        {
            textBoxGamelistDeleted.AppendText(message + Environment.NewLine);
            textBoxGamelistDeleted.ScrollToCaret();
        }

        #endregion

        #region Tab: Export

        private void buttonStartExport_Click(object sender, EventArgs e)
        {
            if (openFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                string exportFile = openFileDialogExport.FileName;

                ExportList = new StringBuilder();
                textBoxExport.Text = string.Empty;

                foreach (Platform platform in checkedListBoxSystems.CheckedItems)
                {
                    Export(platform.Name);
                    Export("----------------------------------------------------------------------");
                    int i = 0;
                    foreach (Rom rom in platform.ListRoms)
                    {
                        ++i;
                        string name = rom.MetaName;
                        if (name == string.Empty || name == null)
                        {
                            name = rom.NameWithoutExtension;
                        }
                        Export(Library.Add0(i.ToString(), 4) + ". " + name);
                    }
                    Export("======================================================================");
                    Export(string.Empty);
                }

                Export("Total Games: " + Platform.RomCount);
                File.WriteAllText(exportFile, ExportList.ToString());
            }
        }

        private void Export(string row)
        {
            textBoxExport.AppendText(row + Environment.NewLine);
            ExportList.AppendLine(row);
        }



        #endregion

        #region Tab: Dupecheck

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

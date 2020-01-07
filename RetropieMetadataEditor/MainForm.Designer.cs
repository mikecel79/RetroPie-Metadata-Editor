namespace RetropieMetadataEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.buttonRestoreDefaultSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSettingsPathRoms = new System.Windows.Forms.TextBox();
            this.textBoxSettingsPathGamelists = new System.Windows.Forms.TextBox();
            this.textBoxSettingsPathImages = new System.Windows.Forms.TextBox();
            this.textBoxSettingsLocalImagePath = new System.Windows.Forms.TextBox();
            this.textBoxSettingsImageEditingSoftware = new System.Windows.Forms.TextBox();
            this.textBoxSettingsImageSuffix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonConnectToRetropie = new System.Windows.Forms.Button();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEditImage = new System.Windows.Forms.Button();
            this.radioButtonNoImage = new System.Windows.Forms.RadioButton();
            this.radioButtonNoMetadata = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxRoms = new System.Windows.Forms.ListBox();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.numericUpDownPlayCount = new System.Windows.Forms.NumericUpDown();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxLastPlayed = new System.Windows.Forms.TextBox();
            this.textBoxMarguee = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxDeveloper = new System.Windows.Forms.TextBox();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMarquee = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelLastPlayed = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelPlaycount = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.tabPageCleanUp = new System.Windows.Forms.TabPage();
            this.groupBoxGamelistCleanUp = new System.Windows.Forms.GroupBox();
            this.textBoxGamelistDeleted = new System.Windows.Forms.TextBox();
            this.buttonStartGamelistCleanUp = new System.Windows.Forms.Button();
            this.comboBoxGamelistCleanUp = new System.Windows.Forms.ComboBox();
            this.groupBoxCoverCleanUp = new System.Windows.Forms.GroupBox();
            this.textBoxCoverDeleted = new System.Windows.Forms.TextBox();
            this.buttonStartCoverCleanUp = new System.Windows.Forms.Button();
            this.comboBoxCoverCleanUp = new System.Windows.Forms.ComboBox();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxExport = new System.Windows.Forms.TextBox();
            this.buttonStartExport = new System.Windows.Forms.Button();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.checkedListBoxSystems = new System.Windows.Forms.CheckedListBox();
            this.tabPageDupecheck = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogExport = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabPageCleanUp.SuspendLayout();
            this.groupBoxGamelistCleanUp.SuspendLayout();
            this.groupBoxCoverCleanUp.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageDupecheck.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tabPageEditor);
            this.tabControl1.Controls.Add(this.tabPageCleanUp);
            this.tabControl1.Controls.Add(this.tabPageExport);
            this.tabControl1.Controls.Add(this.tabPageDupecheck);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.groupBox4);
            this.tabPageConfig.Controls.Add(this.buttonRestoreDefaultSettings);
            this.tabPageConfig.Controls.Add(this.buttonSaveSettings);
            this.tabPageConfig.Controls.Add(this.groupBox2);
            this.tabPageConfig.Controls.Add(this.groupBox1);
            this.tabPageConfig.Controls.Add(this.buttonConnectToRetropie);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(931, 535);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDefaultSettings
            // 
            this.buttonRestoreDefaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestoreDefaultSettings.Location = new System.Drawing.Point(621, 6);
            this.buttonRestoreDefaultSettings.Name = "buttonRestoreDefaultSettings";
            this.buttonRestoreDefaultSettings.Size = new System.Drawing.Size(150, 23);
            this.buttonRestoreDefaultSettings.TabIndex = 10;
            this.buttonRestoreDefaultSettings.Text = "Restore Default Settings";
            this.buttonRestoreDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonRestoreDefaultSettings.Click += new System.EventHandler(this.buttonRestoreDefaultSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSettings.Location = new System.Drawing.Point(775, 6);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(150, 23);
            this.buttonSaveSettings.TabIndex = 8;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSettingsPathRoms);
            this.groupBox2.Controls.Add(this.textBoxSettingsPathGamelists);
            this.groupBox2.Controls.Add(this.textBoxSettingsPathImages);
            this.groupBox2.Controls.Add(this.textBoxSettingsLocalImagePath);
            this.groupBox2.Controls.Add(this.textBoxSettingsImageEditingSoftware);
            this.groupBox2.Controls.Add(this.textBoxSettingsImageSuffix);
            this.groupBox2.Location = new System.Drawing.Point(487, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 335);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Local Image Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Image Editing Software)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image Name Suffix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Path Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Path Gamelists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Path Roms";
            // 
            // textBoxSettingsPathRoms
            // 
            this.textBoxSettingsPathRoms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsPathRoms.Location = new System.Drawing.Point(6, 35);
            this.textBoxSettingsPathRoms.Name = "textBoxSettingsPathRoms";
            this.textBoxSettingsPathRoms.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsPathRoms.TabIndex = 2;
            // 
            // textBoxSettingsPathGamelists
            // 
            this.textBoxSettingsPathGamelists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsPathGamelists.Location = new System.Drawing.Point(6, 74);
            this.textBoxSettingsPathGamelists.Name = "textBoxSettingsPathGamelists";
            this.textBoxSettingsPathGamelists.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsPathGamelists.TabIndex = 3;
            // 
            // textBoxSettingsPathImages
            // 
            this.textBoxSettingsPathImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsPathImages.Location = new System.Drawing.Point(6, 113);
            this.textBoxSettingsPathImages.Name = "textBoxSettingsPathImages";
            this.textBoxSettingsPathImages.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsPathImages.TabIndex = 4;
            // 
            // textBoxSettingsLocalImagePath
            // 
            this.textBoxSettingsLocalImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsLocalImagePath.Location = new System.Drawing.Point(6, 230);
            this.textBoxSettingsLocalImagePath.Name = "textBoxSettingsLocalImagePath";
            this.textBoxSettingsLocalImagePath.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsLocalImagePath.TabIndex = 7;
            // 
            // textBoxSettingsImageEditingSoftware
            // 
            this.textBoxSettingsImageEditingSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsImageEditingSoftware.Location = new System.Drawing.Point(6, 191);
            this.textBoxSettingsImageEditingSoftware.Name = "textBoxSettingsImageEditingSoftware";
            this.textBoxSettingsImageEditingSoftware.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsImageEditingSoftware.TabIndex = 6;
            // 
            // textBoxSettingsImageSuffix
            // 
            this.textBoxSettingsImageSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettingsImageSuffix.Location = new System.Drawing.Point(6, 152);
            this.textBoxSettingsImageSuffix.Name = "textBoxSettingsImageSuffix";
            this.textBoxSettingsImageSuffix.Size = new System.Drawing.Size(426, 20);
            this.textBoxSettingsImageSuffix.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 16);
            this.textBoxLog.MaxLength = 4000000;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(467, 473);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonConnectToRetropie
            // 
            this.buttonConnectToRetropie.Location = new System.Drawing.Point(8, 6);
            this.buttonConnectToRetropie.Name = "buttonConnectToRetropie";
            this.buttonConnectToRetropie.Size = new System.Drawing.Size(150, 23);
            this.buttonConnectToRetropie.TabIndex = 1;
            this.buttonConnectToRetropie.Text = "Connect To Retropie";
            this.buttonConnectToRetropie.UseVisualStyleBackColor = true;
            this.buttonConnectToRetropie.Click += new System.EventHandler(this.buttonConnectToRetropie_Click);
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.label12);
            this.tabPageEditor.Controls.Add(this.label11);
            this.tabPageEditor.Controls.Add(this.buttonDelete);
            this.tabPageEditor.Controls.Add(this.buttonAddImage);
            this.tabPageEditor.Controls.Add(this.buttonSave);
            this.tabPageEditor.Controls.Add(this.buttonEditImage);
            this.tabPageEditor.Controls.Add(this.radioButtonNoImage);
            this.tabPageEditor.Controls.Add(this.radioButtonNoMetadata);
            this.tabPageEditor.Controls.Add(this.radioButtonAll);
            this.tabPageEditor.Controls.Add(this.splitContainer1);
            this.tabPageEditor.Controls.Add(this.comboBoxPlatform);
            this.tabPageEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(931, 535);
            this.tabPageEditor.TabIndex = 1;
            this.tabPageEditor.Text = "Editor";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(351, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Quit EmulationStation before saving";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(435, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "- - - C A U T I O N - - -";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(683, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddImage.Location = new System.Drawing.Point(764, 6);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddImage.TabIndex = 20;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(602, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEditImage
            // 
            this.buttonEditImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditImage.Location = new System.Drawing.Point(845, 6);
            this.buttonEditImage.Name = "buttonEditImage";
            this.buttonEditImage.Size = new System.Drawing.Size(75, 23);
            this.buttonEditImage.TabIndex = 21;
            this.buttonEditImage.Text = "Edit Image";
            this.buttonEditImage.UseVisualStyleBackColor = true;
            this.buttonEditImage.Click += new System.EventHandler(this.buttonEditImage_Click);
            // 
            // radioButtonNoImage
            // 
            this.radioButtonNoImage.AutoSize = true;
            this.radioButtonNoImage.Location = new System.Drawing.Point(274, 9);
            this.radioButtonNoImage.Name = "radioButtonNoImage";
            this.radioButtonNoImage.Size = new System.Drawing.Size(71, 17);
            this.radioButtonNoImage.TabIndex = 4;
            this.radioButtonNoImage.Text = "No Image";
            this.radioButtonNoImage.UseVisualStyleBackColor = true;
            this.radioButtonNoImage.CheckedChanged += new System.EventHandler(this.radioButtonRomlistFilter_CheckedChanged);
            // 
            // radioButtonNoMetadata
            // 
            this.radioButtonNoMetadata.AutoSize = true;
            this.radioButtonNoMetadata.Location = new System.Drawing.Point(188, 9);
            this.radioButtonNoMetadata.Name = "radioButtonNoMetadata";
            this.radioButtonNoMetadata.Size = new System.Drawing.Size(87, 17);
            this.radioButtonNoMetadata.TabIndex = 3;
            this.radioButtonNoMetadata.Text = "No Metadata";
            this.radioButtonNoMetadata.UseVisualStyleBackColor = true;
            this.radioButtonNoMetadata.CheckedChanged += new System.EventHandler(this.radioButtonRomlistFilter_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(150, 9);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonRomlistFilter_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxRoms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerReleaseDate);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownPlayCount);
            this.splitContainer1.Panel2.Controls.Add(this.labelImage);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDescription);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxCover);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRating);
            this.splitContainer1.Panel2.Controls.Add(this.labelRating);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLastPlayed);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMarguee);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxGenre);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPublisher);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDeveloper);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxImage);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxVideo);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPath);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.labelMarquee);
            this.splitContainer1.Panel2.Controls.Add(this.labelGenre);
            this.splitContainer1.Panel2.Controls.Add(this.labelLastPlayed);
            this.splitContainer1.Panel2.Controls.Add(this.labelPublisher);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlaycount);
            this.splitContainer1.Panel2.Controls.Add(this.labelDeveloper);
            this.splitContainer1.Panel2.Controls.Add(this.labelDescription);
            this.splitContainer1.Panel2.Controls.Add(this.labelVideo);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.labelPath);
            this.splitContainer1.Size = new System.Drawing.Size(915, 492);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 1;
            // 
            // listBoxRoms
            // 
            this.listBoxRoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRoms.FormattingEnabled = true;
            this.listBoxRoms.Location = new System.Drawing.Point(0, 0);
            this.listBoxRoms.Name = "listBoxRoms";
            this.listBoxRoms.Size = new System.Drawing.Size(281, 492);
            this.listBoxRoms.Sorted = true;
            this.listBoxRoms.TabIndex = 5;
            this.listBoxRoms.SelectedIndexChanged += new System.EventHandler(this.listBoxRoms_SelectedIndexChanged);
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(6, 221);
            this.dateTimePickerReleaseDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.ShowCheckBox = true;
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerReleaseDate.TabIndex = 15;
            // 
            // numericUpDownPlayers
            // 
            this.numericUpDownPlayers.Location = new System.Drawing.Point(168, 221);
            this.numericUpDownPlayers.Name = "numericUpDownPlayers";
            this.numericUpDownPlayers.Size = new System.Drawing.Size(155, 20);
            this.numericUpDownPlayers.TabIndex = 16;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(168, 205);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(41, 13);
            this.labelPlayers.TabIndex = 27;
            this.labelPlayers.Text = "Players";
            // 
            // numericUpDownPlayCount
            // 
            this.numericUpDownPlayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPlayCount.Location = new System.Drawing.Point(6, 469);
            this.numericUpDownPlayCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPlayCount.Name = "numericUpDownPlayCount";
            this.numericUpDownPlayCount.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownPlayCount.TabIndex = 19;
            this.numericUpDownPlayCount.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(327, 7);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(36, 13);
            this.labelImage.TabIndex = 25;
            this.labelImage.Text = "Image";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Location = new System.Drawing.Point(6, 299);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(318, 151);
            this.textBoxDescription.TabIndex = 18;
            this.textBoxDescription.Text = "";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCover.Location = new System.Drawing.Point(330, 52);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(297, 358);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 23;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.Click += new System.EventHandler(this.pictureBoxCover_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(5, 260);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.ReadOnly = true;
            this.textBoxRating.Size = new System.Drawing.Size(318, 20);
            this.textBoxRating.TabIndex = 17;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(2, 244);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 21;
            this.labelRating.Text = "Rating";
            // 
            // textBoxLastPlayed
            // 
            this.textBoxLastPlayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLastPlayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastPlayed.Location = new System.Drawing.Point(90, 469);
            this.textBoxLastPlayed.Name = "textBoxLastPlayed";
            this.textBoxLastPlayed.ReadOnly = true;
            this.textBoxLastPlayed.Size = new System.Drawing.Size(234, 20);
            this.textBoxLastPlayed.TabIndex = 20;
            // 
            // textBoxMarguee
            // 
            this.textBoxMarguee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarguee.Location = new System.Drawing.Point(330, 468);
            this.textBoxMarguee.Name = "textBoxMarguee";
            this.textBoxMarguee.Size = new System.Drawing.Size(297, 20);
            this.textBoxMarguee.TabIndex = 12;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(6, 104);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(318, 20);
            this.textBoxGenre.TabIndex = 12;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(5, 182);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(318, 20);
            this.textBoxPublisher.TabIndex = 14;
            // 
            // textBoxDeveloper
            // 
            this.textBoxDeveloper.Location = new System.Drawing.Point(5, 143);
            this.textBoxDeveloper.Name = "textBoxDeveloper";
            this.textBoxDeveloper.Size = new System.Drawing.Size(318, 20);
            this.textBoxDeveloper.TabIndex = 13;
            // 
            // textBoxImage
            // 
            this.textBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImage.Location = new System.Drawing.Point(330, 26);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.ReadOnly = true;
            this.textBoxImage.Size = new System.Drawing.Size(297, 20);
            this.textBoxImage.TabIndex = 21;
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVideo.Location = new System.Drawing.Point(330, 429);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(297, 20);
            this.textBoxVideo.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(318, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(6, 26);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(318, 20);
            this.textBoxPath.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Release Date";
            // 
            // labelMarquee
            // 
            this.labelMarquee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarquee.AutoSize = true;
            this.labelMarquee.Location = new System.Drawing.Point(327, 452);
            this.labelMarquee.Name = "labelMarquee";
            this.labelMarquee.Size = new System.Drawing.Size(49, 13);
            this.labelMarquee.TabIndex = 8;
            this.labelMarquee.Text = "Marquee";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(3, 88);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre";
            // 
            // labelLastPlayed
            // 
            this.labelLastPlayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastPlayed.AutoSize = true;
            this.labelLastPlayed.Location = new System.Drawing.Point(87, 453);
            this.labelLastPlayed.Name = "labelLastPlayed";
            this.labelLastPlayed.Size = new System.Drawing.Size(62, 13);
            this.labelLastPlayed.TabIndex = 7;
            this.labelLastPlayed.Text = "Last Played";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(2, 166);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(50, 13);
            this.labelPublisher.TabIndex = 5;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelPlaycount
            // 
            this.labelPlaycount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlaycount.AutoSize = true;
            this.labelPlaycount.Location = new System.Drawing.Point(3, 453);
            this.labelPlaycount.Name = "labelPlaycount";
            this.labelPlaycount.Size = new System.Drawing.Size(58, 13);
            this.labelPlaycount.TabIndex = 4;
            this.labelPlaycount.Text = "Play Count";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(2, 127);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(56, 13);
            this.labelDeveloper.TabIndex = 3;
            this.labelDeveloper.Text = "Developer";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 283);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // labelVideo
            // 
            this.labelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(326, 413);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(34, 13);
            this.labelVideo.TabIndex = 1;
            this.labelVideo.Text = "Video";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(2, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 7);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(8, 8);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(134, 21);
            this.comboBoxPlatform.Sorted = true;
            this.comboBoxPlatform.TabIndex = 1;
            this.comboBoxPlatform.SelectedValueChanged += new System.EventHandler(this.comboBoxPlatform_SelectedValueChanged);
            // 
            // tabPageCleanUp
            // 
            this.tabPageCleanUp.Controls.Add(this.groupBoxGamelistCleanUp);
            this.tabPageCleanUp.Controls.Add(this.groupBoxCoverCleanUp);
            this.tabPageCleanUp.Location = new System.Drawing.Point(4, 22);
            this.tabPageCleanUp.Name = "tabPageCleanUp";
            this.tabPageCleanUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCleanUp.Size = new System.Drawing.Size(931, 535);
            this.tabPageCleanUp.TabIndex = 2;
            this.tabPageCleanUp.Text = "Clean Up";
            this.tabPageCleanUp.UseVisualStyleBackColor = true;
            // 
            // groupBoxGamelistCleanUp
            // 
            this.groupBoxGamelistCleanUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGamelistCleanUp.Controls.Add(this.textBoxGamelistDeleted);
            this.groupBoxGamelistCleanUp.Controls.Add(this.buttonStartGamelistCleanUp);
            this.groupBoxGamelistCleanUp.Controls.Add(this.comboBoxGamelistCleanUp);
            this.groupBoxGamelistCleanUp.Location = new System.Drawing.Point(6, 263);
            this.groupBoxGamelistCleanUp.Name = "groupBoxGamelistCleanUp";
            this.groupBoxGamelistCleanUp.Size = new System.Drawing.Size(917, 264);
            this.groupBoxGamelistCleanUp.TabIndex = 1;
            this.groupBoxGamelistCleanUp.TabStop = false;
            this.groupBoxGamelistCleanUp.Text = "Gamelist Clean Up";
            // 
            // textBoxGamelistDeleted
            // 
            this.textBoxGamelistDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGamelistDeleted.Location = new System.Drawing.Point(386, 19);
            this.textBoxGamelistDeleted.MaxLength = 4000000;
            this.textBoxGamelistDeleted.Multiline = true;
            this.textBoxGamelistDeleted.Name = "textBoxGamelistDeleted";
            this.textBoxGamelistDeleted.ReadOnly = true;
            this.textBoxGamelistDeleted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGamelistDeleted.Size = new System.Drawing.Size(525, 239);
            this.textBoxGamelistDeleted.TabIndex = 3;
            // 
            // buttonStartGamelistCleanUp
            // 
            this.buttonStartGamelistCleanUp.Location = new System.Drawing.Point(243, 17);
            this.buttonStartGamelistCleanUp.Name = "buttonStartGamelistCleanUp";
            this.buttonStartGamelistCleanUp.Size = new System.Drawing.Size(137, 23);
            this.buttonStartGamelistCleanUp.TabIndex = 2;
            this.buttonStartGamelistCleanUp.Text = "Clean Up Gamelist";
            this.buttonStartGamelistCleanUp.UseVisualStyleBackColor = true;
            this.buttonStartGamelistCleanUp.Click += new System.EventHandler(this.buttonStartGamelistCleanUp_Click);
            // 
            // comboBoxGamelistCleanUp
            // 
            this.comboBoxGamelistCleanUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGamelistCleanUp.FormattingEnabled = true;
            this.comboBoxGamelistCleanUp.Location = new System.Drawing.Point(6, 19);
            this.comboBoxGamelistCleanUp.Name = "comboBoxGamelistCleanUp";
            this.comboBoxGamelistCleanUp.Size = new System.Drawing.Size(231, 21);
            this.comboBoxGamelistCleanUp.Sorted = true;
            this.comboBoxGamelistCleanUp.TabIndex = 1;
            // 
            // groupBoxCoverCleanUp
            // 
            this.groupBoxCoverCleanUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCoverCleanUp.Controls.Add(this.textBoxCoverDeleted);
            this.groupBoxCoverCleanUp.Controls.Add(this.buttonStartCoverCleanUp);
            this.groupBoxCoverCleanUp.Controls.Add(this.comboBoxCoverCleanUp);
            this.groupBoxCoverCleanUp.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCoverCleanUp.Name = "groupBoxCoverCleanUp";
            this.groupBoxCoverCleanUp.Size = new System.Drawing.Size(917, 251);
            this.groupBoxCoverCleanUp.TabIndex = 0;
            this.groupBoxCoverCleanUp.TabStop = false;
            this.groupBoxCoverCleanUp.Text = "Cover Clean Up";
            // 
            // textBoxCoverDeleted
            // 
            this.textBoxCoverDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoverDeleted.Location = new System.Drawing.Point(386, 19);
            this.textBoxCoverDeleted.MaxLength = 4000000;
            this.textBoxCoverDeleted.Multiline = true;
            this.textBoxCoverDeleted.Name = "textBoxCoverDeleted";
            this.textBoxCoverDeleted.ReadOnly = true;
            this.textBoxCoverDeleted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoverDeleted.Size = new System.Drawing.Size(525, 226);
            this.textBoxCoverDeleted.TabIndex = 3;
            // 
            // buttonStartCoverCleanUp
            // 
            this.buttonStartCoverCleanUp.Location = new System.Drawing.Point(243, 17);
            this.buttonStartCoverCleanUp.Name = "buttonStartCoverCleanUp";
            this.buttonStartCoverCleanUp.Size = new System.Drawing.Size(137, 23);
            this.buttonStartCoverCleanUp.TabIndex = 2;
            this.buttonStartCoverCleanUp.Text = "Clean Up Image Directory";
            this.buttonStartCoverCleanUp.UseVisualStyleBackColor = true;
            this.buttonStartCoverCleanUp.Click += new System.EventHandler(this.buttonStartCleanUp_Click);
            // 
            // comboBoxCoverCleanUp
            // 
            this.comboBoxCoverCleanUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoverCleanUp.FormattingEnabled = true;
            this.comboBoxCoverCleanUp.Location = new System.Drawing.Point(6, 19);
            this.comboBoxCoverCleanUp.Name = "comboBoxCoverCleanUp";
            this.comboBoxCoverCleanUp.Size = new System.Drawing.Size(231, 21);
            this.comboBoxCoverCleanUp.Sorted = true;
            this.comboBoxCoverCleanUp.TabIndex = 1;
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.groupBox3);
            this.tabPageExport.Location = new System.Drawing.Point(4, 22);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(931, 535);
            this.tabPageExport.TabIndex = 3;
            this.tabPageExport.Text = "Export";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxExport);
            this.groupBox3.Controls.Add(this.buttonStartExport);
            this.groupBox3.Controls.Add(this.radioButtonText);
            this.groupBox3.Controls.Add(this.checkedListBoxSystems);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(920, 521);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export Gamelist";
            // 
            // textBoxExport
            // 
            this.textBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExport.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExport.Location = new System.Drawing.Point(380, 18);
            this.textBoxExport.MaxLength = 4000000;
            this.textBoxExport.Multiline = true;
            this.textBoxExport.Name = "textBoxExport";
            this.textBoxExport.ReadOnly = true;
            this.textBoxExport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExport.Size = new System.Drawing.Size(534, 497);
            this.textBoxExport.TabIndex = 4;
            // 
            // buttonStartExport
            // 
            this.buttonStartExport.Location = new System.Drawing.Point(237, 18);
            this.buttonStartExport.Name = "buttonStartExport";
            this.buttonStartExport.Size = new System.Drawing.Size(137, 23);
            this.buttonStartExport.TabIndex = 3;
            this.buttonStartExport.Text = "Start Export";
            this.buttonStartExport.UseVisualStyleBackColor = true;
            this.buttonStartExport.Click += new System.EventHandler(this.buttonStartExport_Click);
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Checked = true;
            this.radioButtonText.Location = new System.Drawing.Point(237, 47);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(46, 17);
            this.radioButtonText.TabIndex = 2;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSystems
            // 
            this.checkedListBoxSystems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxSystems.FormattingEnabled = true;
            this.checkedListBoxSystems.Location = new System.Drawing.Point(6, 18);
            this.checkedListBoxSystems.Name = "checkedListBoxSystems";
            this.checkedListBoxSystems.Size = new System.Drawing.Size(225, 499);
            this.checkedListBoxSystems.TabIndex = 1;
            // 
            // tabPageDupecheck
            // 
            this.tabPageDupecheck.Controls.Add(this.label7);
            this.tabPageDupecheck.Location = new System.Drawing.Point(4, 22);
            this.tabPageDupecheck.Name = "tabPageDupecheck";
            this.tabPageDupecheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDupecheck.Size = new System.Drawing.Size(931, 535);
            this.tabPageDupecheck.TabIndex = 4;
            this.tabPageDupecheck.Text = "Dupecheck";
            this.tabPageDupecheck.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Coming soon...";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "JPG-Files|*.jpg|PNG-Files|*.png";
            // 
            // openFileDialogExport
            // 
            this.openFileDialogExport.CheckFileExists = false;
            this.openFileDialogExport.FileName = "Gamelist.txt";
            this.openFileDialogExport.Filter = "Text File|*.txt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(487, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 148);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "About";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "To report issues or get the latest version go to ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(43, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(272, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/mikecel79/RetroPie-Metadata-Editor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 561);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageEditor.ResumeLayout(false);
            this.tabPageEditor.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabPageCleanUp.ResumeLayout(false);
            this.groupBoxGamelistCleanUp.ResumeLayout(false);
            this.groupBoxGamelistCleanUp.PerformLayout();
            this.groupBoxCoverCleanUp.ResumeLayout(false);
            this.groupBoxCoverCleanUp.PerformLayout();
            this.tabPageExport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageDupecheck.ResumeLayout(false);
            this.tabPageDupecheck.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.Button buttonConnectToRetropie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxRoms;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelLastPlayed;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelPlaycount;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxDeveloper;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxLastPlayed;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.RadioButton radioButtonNoMetadata;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonNoImage;
        private System.Windows.Forms.Button buttonEditImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayers;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.TabPage tabPageCleanUp;
        private System.Windows.Forms.GroupBox groupBoxCoverCleanUp;
        private System.Windows.Forms.ComboBox comboBoxCoverCleanUp;
        private System.Windows.Forms.TextBox textBoxCoverDeleted;
        private System.Windows.Forms.Button buttonStartCoverCleanUp;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TextBox textBoxSettingsImageSuffix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSettingsPathRoms;
        private System.Windows.Forms.TextBox textBoxSettingsPathGamelists;
        private System.Windows.Forms.TextBox textBoxSettingsPathImages;
        private System.Windows.Forms.TextBox textBoxSettingsLocalImagePath;
        private System.Windows.Forms.TextBox textBoxSettingsImageEditingSoftware;
        private System.Windows.Forms.OpenFileDialog openFileDialogExport;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMarguee;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.Label labelMarquee;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.TabPage tabPageDupecheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxExport;
        private System.Windows.Forms.Button buttonStartExport;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.CheckedListBox checkedListBoxSystems;
        private System.Windows.Forms.GroupBox groupBoxGamelistCleanUp;
        private System.Windows.Forms.TextBox textBoxGamelistDeleted;
        private System.Windows.Forms.Button buttonStartGamelistCleanUp;
        private System.Windows.Forms.ComboBox comboBoxGamelistCleanUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRestoreDefaultSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}


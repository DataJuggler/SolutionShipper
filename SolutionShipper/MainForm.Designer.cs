namespace SolutionShipper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceFolderTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.BrowseSourceFolderButton = new System.Windows.Forms.Button();
            this.BrowseOutputFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ShipSolutionButton = new System.Windows.Forms.Button();
            this.SourceFoldersCountLabel = new System.Windows.Forms.Label();
            this.SourceFoldersCountValueLabel = new System.Windows.Forms.Label();
            this.SourceFilesCountValueLabel = new System.Windows.Forms.Label();
            this.SourceFilesCountLabel = new System.Windows.Forms.Label();
            this.SourceSizeValueLabel = new System.Windows.Forms.Label();
            this.SourceSizeCountLabel = new System.Windows.Forms.Label();
            this.OutputSizeValueLabel = new System.Windows.Forms.Label();
            this.OutputSizeLabel = new System.Windows.Forms.Label();
            this.OutputFilesCountValueLabel = new System.Windows.Forms.Label();
            this.OutputFilesCountLabel = new System.Windows.Forms.Label();
            this.OutputFolderCountValueLabel = new System.Windows.Forms.Label();
            this.OutputFolderCountLabel = new System.Windows.Forms.Label();
            this.ReductionPercentValueLabel = new System.Windows.Forms.Label();
            this.ReductionPercentLabel = new System.Windows.Forms.Label();
            this.ReductionSizeValueLabel = new System.Windows.Forms.Label();
            this.ReductionSizeLabel = new System.Windows.Forms.Label();
            this.DeleteOptionsLabel = new System.Windows.Forms.Label();
            this.BinCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.ObjCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.PackagesCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.IgnoreFoldersListBox = new System.Windows.Forms.ListBox();
            this.IngoreFoldersLabel = new System.Windows.Forms.Label();
            this.AddIgnoreFolderButton = new System.Windows.Forms.Button();
            this.IgnorFolderTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.OpenShipmentButton = new System.Windows.Forms.Button();
            this.SaveShipmentButton = new System.Windows.Forms.Button();
            this.ShipmentNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.CopyCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.ZipCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.AddTimeStampCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceFolderTextBox
            // 
            this.SourceFolderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SourceFolderTextBox.BottomMargin = 0;
            this.SourceFolderTextBox.Editable = true;
            this.SourceFolderTextBox.Encrypted = false;
            this.SourceFolderTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceFolderTextBox.LabelBottomMargin = 0;
            this.SourceFolderTextBox.LabelColor = System.Drawing.SystemColors.ControlText;
            this.SourceFolderTextBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.SourceFolderTextBox.LabelText = "Source Folder:";
            this.SourceFolderTextBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SourceFolderTextBox.LabelTopMargin = 4;
            this.SourceFolderTextBox.LabelWidth = 200;
            this.SourceFolderTextBox.Location = new System.Drawing.Point(24, 61);
            this.SourceFolderTextBox.MultiLine = false;
            this.SourceFolderTextBox.Name = "SourceFolderTextBox";
            this.SourceFolderTextBox.OnTextChangedListener = null;
            this.SourceFolderTextBox.PasswordMode = false;
            this.SourceFolderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceFolderTextBox.Size = new System.Drawing.Size(880, 32);
            this.SourceFolderTextBox.TabIndex = 1;
            this.SourceFolderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SourceFolderTextBox.TextBoxBottomMargin = 0;
            this.SourceFolderTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SourceFolderTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.SourceFolderTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F);
            this.SourceFolderTextBox.TextBoxTopMargin = 0;
            // 
            // BrowseSourceFolderButton
            // 
            this.BrowseSourceFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseSourceFolderButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.BrowseSourceFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseSourceFolderButton.FlatAppearance.BorderSize = 0;
            this.BrowseSourceFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseSourceFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseSourceFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseSourceFolderButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseSourceFolderButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BrowseSourceFolderButton.Location = new System.Drawing.Point(864, 59);
            this.BrowseSourceFolderButton.Name = "BrowseSourceFolderButton";
            this.BrowseSourceFolderButton.Size = new System.Drawing.Size(48, 36);
            this.BrowseSourceFolderButton.TabIndex = 1000;
            this.BrowseSourceFolderButton.TabStop = false;
            this.BrowseSourceFolderButton.Text = "...";
            this.BrowseSourceFolderButton.UseVisualStyleBackColor = false;
            this.BrowseSourceFolderButton.Click += new System.EventHandler(this.BrowseSourceFolderButton_Click);
            this.BrowseSourceFolderButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.BrowseSourceFolderButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // BrowseOutputFolderButton
            // 
            this.BrowseOutputFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseOutputFolderButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.BrowseOutputFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseOutputFolderButton.FlatAppearance.BorderSize = 0;
            this.BrowseOutputFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseOutputFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseOutputFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseOutputFolderButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseOutputFolderButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BrowseOutputFolderButton.Location = new System.Drawing.Point(864, 104);
            this.BrowseOutputFolderButton.Name = "BrowseOutputFolderButton";
            this.BrowseOutputFolderButton.Size = new System.Drawing.Size(48, 36);
            this.BrowseOutputFolderButton.TabIndex = 1001;
            this.BrowseOutputFolderButton.TabStop = false;
            this.BrowseOutputFolderButton.Text = "...";
            this.BrowseOutputFolderButton.UseVisualStyleBackColor = false;
            this.BrowseOutputFolderButton.Click += new System.EventHandler(this.BrowseOutputFolderButton_Click);
            this.BrowseOutputFolderButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.BrowseOutputFolderButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderTextBox.BottomMargin = 0;
            this.OutputFolderTextBox.Editable = true;
            this.OutputFolderTextBox.Encrypted = false;
            this.OutputFolderTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolderTextBox.LabelBottomMargin = 0;
            this.OutputFolderTextBox.LabelColor = System.Drawing.SystemColors.ControlText;
            this.OutputFolderTextBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.OutputFolderTextBox.LabelText = "Output Folder:";
            this.OutputFolderTextBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OutputFolderTextBox.LabelTopMargin = 4;
            this.OutputFolderTextBox.LabelWidth = 200;
            this.OutputFolderTextBox.Location = new System.Drawing.Point(24, 106);
            this.OutputFolderTextBox.MultiLine = false;
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.OnTextChangedListener = null;
            this.OutputFolderTextBox.PasswordMode = false;
            this.OutputFolderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputFolderTextBox.Size = new System.Drawing.Size(880, 32);
            this.OutputFolderTextBox.TabIndex = 2;
            this.OutputFolderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OutputFolderTextBox.TextBoxBottomMargin = 0;
            this.OutputFolderTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.OutputFolderTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.OutputFolderTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F);
            this.OutputFolderTextBox.TextBoxTopMargin = 0;
            // 
            // ShipSolutionButton
            // 
            this.ShipSolutionButton.BackColor = System.Drawing.Color.Transparent;
            this.ShipSolutionButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.ShipSolutionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShipSolutionButton.FlatAppearance.BorderSize = 0;
            this.ShipSolutionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.ShipSolutionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ShipSolutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShipSolutionButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipSolutionButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ShipSolutionButton.Location = new System.Drawing.Point(692, 566);
            this.ShipSolutionButton.Name = "ShipSolutionButton";
            this.ShipSolutionButton.Size = new System.Drawing.Size(220, 36);
            this.ShipSolutionButton.TabIndex = 4;
            this.ShipSolutionButton.TabStop = false;
            this.ShipSolutionButton.Text = "Ship Solution";
            this.ShipSolutionButton.UseVisualStyleBackColor = false;
            this.ShipSolutionButton.Click += new System.EventHandler(this.ShipSolutionButton_Click);
            this.ShipSolutionButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ShipSolutionButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // SourceFoldersCountLabel
            // 
            this.SourceFoldersCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceFoldersCountLabel.Location = new System.Drawing.Point(16, 428);
            this.SourceFoldersCountLabel.Name = "SourceFoldersCountLabel";
            this.SourceFoldersCountLabel.Size = new System.Drawing.Size(164, 24);
            this.SourceFoldersCountLabel.TabIndex = 5;
            this.SourceFoldersCountLabel.Text = "Source Folders:";
            this.SourceFoldersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SourceFoldersCountValueLabel
            // 
            this.SourceFoldersCountValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceFoldersCountValueLabel.Location = new System.Drawing.Point(174, 428);
            this.SourceFoldersCountValueLabel.Name = "SourceFoldersCountValueLabel";
            this.SourceFoldersCountValueLabel.Size = new System.Drawing.Size(154, 24);
            this.SourceFoldersCountValueLabel.TabIndex = 6;
            this.SourceFoldersCountValueLabel.Text = "0";
            this.SourceFoldersCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceFilesCountValueLabel
            // 
            this.SourceFilesCountValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceFilesCountValueLabel.Location = new System.Drawing.Point(174, 456);
            this.SourceFilesCountValueLabel.Name = "SourceFilesCountValueLabel";
            this.SourceFilesCountValueLabel.Size = new System.Drawing.Size(168, 24);
            this.SourceFilesCountValueLabel.TabIndex = 8;
            this.SourceFilesCountValueLabel.Text = "0";
            this.SourceFilesCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceFilesCountLabel
            // 
            this.SourceFilesCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceFilesCountLabel.Location = new System.Drawing.Point(16, 456);
            this.SourceFilesCountLabel.Name = "SourceFilesCountLabel";
            this.SourceFilesCountLabel.Size = new System.Drawing.Size(164, 24);
            this.SourceFilesCountLabel.TabIndex = 7;
            this.SourceFilesCountLabel.Text = "Source Files:";
            this.SourceFilesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SourceSizeValueLabel
            // 
            this.SourceSizeValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceSizeValueLabel.Location = new System.Drawing.Point(174, 484);
            this.SourceSizeValueLabel.Name = "SourceSizeValueLabel";
            this.SourceSizeValueLabel.Size = new System.Drawing.Size(200, 24);
            this.SourceSizeValueLabel.TabIndex = 10;
            this.SourceSizeValueLabel.Text = "0 kb";
            this.SourceSizeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceSizeCountLabel
            // 
            this.SourceSizeCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.SourceSizeCountLabel.Location = new System.Drawing.Point(16, 484);
            this.SourceSizeCountLabel.Name = "SourceSizeCountLabel";
            this.SourceSizeCountLabel.Size = new System.Drawing.Size(164, 24);
            this.SourceSizeCountLabel.TabIndex = 9;
            this.SourceSizeCountLabel.Text = "Source Size:";
            this.SourceSizeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputSizeValueLabel
            // 
            this.OutputSizeValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputSizeValueLabel.Location = new System.Drawing.Point(492, 484);
            this.OutputSizeValueLabel.Name = "OutputSizeValueLabel";
            this.OutputSizeValueLabel.Size = new System.Drawing.Size(205, 24);
            this.OutputSizeValueLabel.TabIndex = 16;
            this.OutputSizeValueLabel.Text = "0 kb";
            this.OutputSizeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputSizeLabel
            // 
            this.OutputSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputSizeLabel.Location = new System.Drawing.Point(318, 484);
            this.OutputSizeLabel.Name = "OutputSizeLabel";
            this.OutputSizeLabel.Size = new System.Drawing.Size(180, 24);
            this.OutputSizeLabel.TabIndex = 15;
            this.OutputSizeLabel.Text = "Output Size:";
            this.OutputSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputFilesCountValueLabel
            // 
            this.OutputFilesCountValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputFilesCountValueLabel.Location = new System.Drawing.Point(492, 456);
            this.OutputFilesCountValueLabel.Name = "OutputFilesCountValueLabel";
            this.OutputFilesCountValueLabel.Size = new System.Drawing.Size(100, 24);
            this.OutputFilesCountValueLabel.TabIndex = 14;
            this.OutputFilesCountValueLabel.Text = "0";
            this.OutputFilesCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputFilesCountLabel
            // 
            this.OutputFilesCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputFilesCountLabel.Location = new System.Drawing.Point(318, 456);
            this.OutputFilesCountLabel.Name = "OutputFilesCountLabel";
            this.OutputFilesCountLabel.Size = new System.Drawing.Size(180, 24);
            this.OutputFilesCountLabel.TabIndex = 13;
            this.OutputFilesCountLabel.Text = "Output Files:";
            this.OutputFilesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputFolderCountValueLabel
            // 
            this.OutputFolderCountValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderCountValueLabel.Location = new System.Drawing.Point(492, 428);
            this.OutputFolderCountValueLabel.Name = "OutputFolderCountValueLabel";
            this.OutputFolderCountValueLabel.Size = new System.Drawing.Size(100, 24);
            this.OutputFolderCountValueLabel.TabIndex = 12;
            this.OutputFolderCountValueLabel.Text = "0";
            this.OutputFolderCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputFolderCountLabel
            // 
            this.OutputFolderCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderCountLabel.Location = new System.Drawing.Point(318, 428);
            this.OutputFolderCountLabel.Name = "OutputFolderCountLabel";
            this.OutputFolderCountLabel.Size = new System.Drawing.Size(180, 24);
            this.OutputFolderCountLabel.TabIndex = 11;
            this.OutputFolderCountLabel.Text = "Output Folders:";
            this.OutputFolderCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReductionPercentValueLabel
            // 
            this.ReductionPercentValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReductionPercentValueLabel.Location = new System.Drawing.Point(744, 456);
            this.ReductionPercentValueLabel.Name = "ReductionPercentValueLabel";
            this.ReductionPercentValueLabel.Size = new System.Drawing.Size(80, 24);
            this.ReductionPercentValueLabel.TabIndex = 20;
            this.ReductionPercentValueLabel.Text = "0%";
            this.ReductionPercentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReductionPercentLabel
            // 
            this.ReductionPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReductionPercentLabel.Location = new System.Drawing.Point(570, 456);
            this.ReductionPercentLabel.Name = "ReductionPercentLabel";
            this.ReductionPercentLabel.Size = new System.Drawing.Size(180, 24);
            this.ReductionPercentLabel.TabIndex = 19;
            this.ReductionPercentLabel.Text = "Reduction %:";
            this.ReductionPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReductionSizeValueLabel
            // 
            this.ReductionSizeValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReductionSizeValueLabel.Location = new System.Drawing.Point(744, 428);
            this.ReductionSizeValueLabel.Name = "ReductionSizeValueLabel";
            this.ReductionSizeValueLabel.Size = new System.Drawing.Size(188, 24);
            this.ReductionSizeValueLabel.TabIndex = 18;
            this.ReductionSizeValueLabel.Text = "0 kb";
            this.ReductionSizeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReductionSizeLabel
            // 
            this.ReductionSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReductionSizeLabel.Location = new System.Drawing.Point(570, 428);
            this.ReductionSizeLabel.Name = "ReductionSizeLabel";
            this.ReductionSizeLabel.Size = new System.Drawing.Size(180, 24);
            this.ReductionSizeLabel.TabIndex = 17;
            this.ReductionSizeLabel.Text = "Reduction Size:";
            this.ReductionSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeleteOptionsLabel
            // 
            this.DeleteOptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteOptionsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOptionsLabel.Location = new System.Drawing.Point(44, 150);
            this.DeleteOptionsLabel.Name = "DeleteOptionsLabel";
            this.DeleteOptionsLabel.Size = new System.Drawing.Size(180, 24);
            this.DeleteOptionsLabel.TabIndex = 21;
            this.DeleteOptionsLabel.Text = "Delete Options:";
            this.DeleteOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BinCheckBox
            // 
            this.BinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BinCheckBox.CheckBoxVerticalOffSet = 4;
            this.BinCheckBox.CheckChangedListener = null;
            this.BinCheckBox.Checked = true;
            this.BinCheckBox.Editable = true;
            this.BinCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BinCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.BinCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinCheckBox.LabelText = "Bin Folder";
            this.BinCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BinCheckBox.LabelWidth = 172;
            this.BinCheckBox.Location = new System.Drawing.Point(226, 146);
            this.BinCheckBox.Name = "BinCheckBox";
            this.BinCheckBox.Size = new System.Drawing.Size(192, 28);
            this.BinCheckBox.TabIndex = 22;
            // 
            // ObjCheckBox
            // 
            this.ObjCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ObjCheckBox.CheckBoxVerticalOffSet = 4;
            this.ObjCheckBox.CheckChangedListener = null;
            this.ObjCheckBox.Checked = true;
            this.ObjCheckBox.Editable = true;
            this.ObjCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ObjCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ObjCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjCheckBox.LabelText = "Obj Folder";
            this.ObjCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ObjCheckBox.LabelWidth = 124;
            this.ObjCheckBox.Location = new System.Drawing.Point(434, 146);
            this.ObjCheckBox.Name = "ObjCheckBox";
            this.ObjCheckBox.Size = new System.Drawing.Size(144, 28);
            this.ObjCheckBox.TabIndex = 24;
            // 
            // PackagesCheckBox
            // 
            this.PackagesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PackagesCheckBox.CheckBoxVerticalOffSet = 4;
            this.PackagesCheckBox.CheckChangedListener = null;
            this.PackagesCheckBox.Checked = true;
            this.PackagesCheckBox.Editable = true;
            this.PackagesCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackagesCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PackagesCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.PackagesCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackagesCheckBox.LabelText = "Packages Folder";
            this.PackagesCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PackagesCheckBox.LabelWidth = 172;
            this.PackagesCheckBox.Location = new System.Drawing.Point(602, 146);
            this.PackagesCheckBox.Name = "PackagesCheckBox";
            this.PackagesCheckBox.Size = new System.Drawing.Size(192, 28);
            this.PackagesCheckBox.TabIndex = 26;
            // 
            // IgnoreFoldersListBox
            // 
            this.IgnoreFoldersListBox.FormattingEnabled = true;
            this.IgnoreFoldersListBox.ItemHeight = 23;
            this.IgnoreFoldersListBox.Location = new System.Drawing.Point(226, 235);
            this.IgnoreFoldersListBox.Name = "IgnoreFoldersListBox";
            this.IgnoreFoldersListBox.Size = new System.Drawing.Size(686, 142);
            this.IgnoreFoldersListBox.TabIndex = 27;
            this.IgnoreFoldersListBox.TabStop = false;
            this.IgnoreFoldersListBox.DoubleClick += new System.EventHandler(this.IgnoreFoldersListBox_DoubleClick);
            this.IgnoreFoldersListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreFoldersListBox_KeyDown);
            // 
            // IngoreFoldersLabel
            // 
            this.IngoreFoldersLabel.BackColor = System.Drawing.Color.Transparent;
            this.IngoreFoldersLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngoreFoldersLabel.Location = new System.Drawing.Point(44, 235);
            this.IngoreFoldersLabel.Name = "IngoreFoldersLabel";
            this.IngoreFoldersLabel.Size = new System.Drawing.Size(180, 24);
            this.IngoreFoldersLabel.TabIndex = 28;
            this.IngoreFoldersLabel.Text = "Ignore Folders:";
            this.IngoreFoldersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddIgnoreFolderButton
            // 
            this.AddIgnoreFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.AddIgnoreFolderButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.AddIgnoreFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddIgnoreFolderButton.FlatAppearance.BorderSize = 0;
            this.AddIgnoreFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddIgnoreFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddIgnoreFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIgnoreFolderButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIgnoreFolderButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddIgnoreFolderButton.Location = new System.Drawing.Point(832, 382);
            this.AddIgnoreFolderButton.Name = "AddIgnoreFolderButton";
            this.AddIgnoreFolderButton.Size = new System.Drawing.Size(80, 36);
            this.AddIgnoreFolderButton.TabIndex = 29;
            this.AddIgnoreFolderButton.TabStop = false;
            this.AddIgnoreFolderButton.Text = "Add";
            this.AddIgnoreFolderButton.UseVisualStyleBackColor = false;
            this.AddIgnoreFolderButton.Click += new System.EventHandler(this.AddIgnoreFolderButton_Click);
            this.AddIgnoreFolderButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.AddIgnoreFolderButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // IgnorFolderTextBox
            // 
            this.IgnorFolderTextBox.Location = new System.Drawing.Point(-726, 395);
            this.IgnorFolderTextBox.Name = "IgnorFolderTextBox";
            this.IgnorFolderTextBox.Size = new System.Drawing.Size(100, 31);
            this.IgnorFolderTextBox.TabIndex = 30;
            this.IgnorFolderTextBox.Visible = false;
            this.IgnorFolderTextBox.TextChanged += new System.EventHandler(this.IgnorFolderTextBox_TextChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(226, 379);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(564, 24);
            this.InfoLabel.TabIndex = 31;
            this.InfoLabel.Text = "Press Delete to remove an item; double click to edit exceptions\r\n.";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel2.Font = new System.Drawing.Font("Verdana", 13F);
            this.InfoLabel2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InfoLabel2.Location = new System.Drawing.Point(12, 267);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(212, 133);
            this.InfoLabel2.TabIndex = 32;
            this.InfoLabel2.Text = "By default the folder is not copied. You can change this by adding an exception.\r" +
    "\n\r\n\r\n\r\n\r\n";
            this.InfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenShipmentButton
            // 
            this.OpenShipmentButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenShipmentButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.OpenShipmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenShipmentButton.FlatAppearance.BorderSize = 0;
            this.OpenShipmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.OpenShipmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.OpenShipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenShipmentButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenShipmentButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.OpenShipmentButton.Location = new System.Drawing.Point(466, 566);
            this.OpenShipmentButton.Name = "OpenShipmentButton";
            this.OpenShipmentButton.Size = new System.Drawing.Size(220, 36);
            this.OpenShipmentButton.TabIndex = 33;
            this.OpenShipmentButton.TabStop = false;
            this.OpenShipmentButton.Text = "Open Shipment";
            this.OpenShipmentButton.UseVisualStyleBackColor = false;
            this.OpenShipmentButton.Click += new System.EventHandler(this.OpenShipmentButton_Click);
            this.OpenShipmentButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.OpenShipmentButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // SaveShipmentButton
            // 
            this.SaveShipmentButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveShipmentButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.SaveShipmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveShipmentButton.FlatAppearance.BorderSize = 0;
            this.SaveShipmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveShipmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveShipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveShipmentButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveShipmentButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveShipmentButton.Location = new System.Drawing.Point(240, 565);
            this.SaveShipmentButton.Name = "SaveShipmentButton";
            this.SaveShipmentButton.Size = new System.Drawing.Size(220, 36);
            this.SaveShipmentButton.TabIndex = 34;
            this.SaveShipmentButton.TabStop = false;
            this.SaveShipmentButton.Text = "Save Shipment";
            this.SaveShipmentButton.UseVisualStyleBackColor = false;
            this.SaveShipmentButton.Click += new System.EventHandler(this.SaveShipmentButton_Click);
            this.SaveShipmentButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.SaveShipmentButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ShipmentNameControl
            // 
            this.ShipmentNameControl.BackColor = System.Drawing.Color.Transparent;
            this.ShipmentNameControl.BottomMargin = 0;
            this.ShipmentNameControl.Editable = true;
            this.ShipmentNameControl.Encrypted = false;
            this.ShipmentNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentNameControl.LabelBottomMargin = 0;
            this.ShipmentNameControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.ShipmentNameControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.ShipmentNameControl.LabelText = "Shipment Name:";
            this.ShipmentNameControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShipmentNameControl.LabelTopMargin = 4;
            this.ShipmentNameControl.LabelWidth = 200;
            this.ShipmentNameControl.Location = new System.Drawing.Point(24, 16);
            this.ShipmentNameControl.MultiLine = false;
            this.ShipmentNameControl.Name = "ShipmentNameControl";
            this.ShipmentNameControl.OnTextChangedListener = null;
            this.ShipmentNameControl.PasswordMode = false;
            this.ShipmentNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ShipmentNameControl.Size = new System.Drawing.Size(880, 32);
            this.ShipmentNameControl.TabIndex = 0;
            this.ShipmentNameControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipmentNameControl.TextBoxBottomMargin = 0;
            this.ShipmentNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ShipmentNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ShipmentNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F);
            this.ShipmentNameControl.TextBoxTopMargin = 0;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.Location = new System.Drawing.Point(44, 191);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(180, 24);
            this.OptionsLabel.TabIndex = 1002;
            this.OptionsLabel.Text = "Options:";
            this.OptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CopyCheckBox
            // 
            this.CopyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.CopyCheckBox.CheckBoxVerticalOffSet = 4;
            this.CopyCheckBox.CheckChangedListener = null;
            this.CopyCheckBox.Checked = true;
            this.CopyCheckBox.Editable = true;
            this.CopyCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CopyCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CopyCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCheckBox.LabelText = "Copy";
            this.CopyCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyCheckBox.LabelWidth = 124;
            this.CopyCheckBox.Location = new System.Drawing.Point(434, 189);
            this.CopyCheckBox.Name = "CopyCheckBox";
            this.CopyCheckBox.Size = new System.Drawing.Size(144, 28);
            this.CopyCheckBox.TabIndex = 1003;
            this.CopyCheckBox.Visible = false;
            // 
            // ZipCheckBox
            // 
            this.ZipCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ZipCheckBox.CheckBoxVerticalOffSet = 4;
            this.ZipCheckBox.CheckChangedListener = null;
            this.ZipCheckBox.Checked = true;
            this.ZipCheckBox.Editable = true;
            this.ZipCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ZipCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCheckBox.LabelText = "Zip Project";
            this.ZipCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZipCheckBox.LabelWidth = 172;
            this.ZipCheckBox.Location = new System.Drawing.Point(602, 189);
            this.ZipCheckBox.Name = "ZipCheckBox";
            this.ZipCheckBox.Size = new System.Drawing.Size(192, 28);
            this.ZipCheckBox.TabIndex = 1004;
            this.ZipCheckBox.Visible = false;
            // 
            // AddTimeStampCheckBox
            // 
            this.AddTimeStampCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AddTimeStampCheckBox.CheckBoxVerticalOffSet = 4;
            this.AddTimeStampCheckBox.CheckChangedListener = null;
            this.AddTimeStampCheckBox.Checked = true;
            this.AddTimeStampCheckBox.Editable = true;
            this.AddTimeStampCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimeStampCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddTimeStampCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.AddTimeStampCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimeStampCheckBox.LabelText = "Add Timestamp";
            this.AddTimeStampCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddTimeStampCheckBox.LabelWidth = 172;
            this.AddTimeStampCheckBox.Location = new System.Drawing.Point(226, 189);
            this.AddTimeStampCheckBox.Name = "AddTimeStampCheckBox";
            this.AddTimeStampCheckBox.Size = new System.Drawing.Size(192, 28);
            this.AddTimeStampCheckBox.TabIndex = 1005;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(226, 525);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(686, 23);
            this.Graph.TabIndex = 1006;
            this.Graph.Visible = false;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.BackColor = System.Drawing.Color.Transparent;
            this.DestinationLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DestinationLabel.Location = new System.Drawing.Point(16, 524);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(896, 24);
            this.DestinationLabel.TabIndex = 1007;
            this.DestinationLabel.Text = "Destination:";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DestinationLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SolutionShipper.Properties.Resources.BlueTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.AddTimeStampCheckBox);
            this.Controls.Add(this.ZipCheckBox);
            this.Controls.Add(this.CopyCheckBox);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.ShipmentNameControl);
            this.Controls.Add(this.SaveShipmentButton);
            this.Controls.Add(this.OpenShipmentButton);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.IgnorFolderTextBox);
            this.Controls.Add(this.AddIgnoreFolderButton);
            this.Controls.Add(this.IngoreFoldersLabel);
            this.Controls.Add(this.IgnoreFoldersListBox);
            this.Controls.Add(this.PackagesCheckBox);
            this.Controls.Add(this.ObjCheckBox);
            this.Controls.Add(this.BinCheckBox);
            this.Controls.Add(this.DeleteOptionsLabel);
            this.Controls.Add(this.ReductionPercentValueLabel);
            this.Controls.Add(this.ReductionPercentLabel);
            this.Controls.Add(this.ReductionSizeValueLabel);
            this.Controls.Add(this.ReductionSizeLabel);
            this.Controls.Add(this.OutputSizeValueLabel);
            this.Controls.Add(this.OutputSizeLabel);
            this.Controls.Add(this.OutputFilesCountValueLabel);
            this.Controls.Add(this.OutputFilesCountLabel);
            this.Controls.Add(this.OutputFolderCountValueLabel);
            this.Controls.Add(this.OutputFolderCountLabel);
            this.Controls.Add(this.SourceSizeValueLabel);
            this.Controls.Add(this.SourceSizeCountLabel);
            this.Controls.Add(this.SourceFilesCountValueLabel);
            this.Controls.Add(this.SourceFilesCountLabel);
            this.Controls.Add(this.SourceFoldersCountValueLabel);
            this.Controls.Add(this.SourceFoldersCountLabel);
            this.Controls.Add(this.ShipSolutionButton);
            this.Controls.Add(this.BrowseOutputFolderButton);
            this.Controls.Add(this.OutputFolderTextBox);
            this.Controls.Add(this.BrowseSourceFolderButton);
            this.Controls.Add(this.SourceFolderTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solution Shipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl SourceFolderTextBox;
        private System.Windows.Forms.Button BrowseSourceFolderButton;
        private System.Windows.Forms.Button BrowseOutputFolderButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl OutputFolderTextBox;
        private System.Windows.Forms.Button ShipSolutionButton;
        private System.Windows.Forms.Label SourceFoldersCountLabel;
        private System.Windows.Forms.Label SourceFoldersCountValueLabel;
        private System.Windows.Forms.Label SourceFilesCountValueLabel;
        private System.Windows.Forms.Label SourceFilesCountLabel;
        private System.Windows.Forms.Label SourceSizeValueLabel;
        private System.Windows.Forms.Label SourceSizeCountLabel;
        private System.Windows.Forms.Label OutputSizeValueLabel;
        private System.Windows.Forms.Label OutputSizeLabel;
        private System.Windows.Forms.Label OutputFilesCountValueLabel;
        private System.Windows.Forms.Label OutputFilesCountLabel;
        private System.Windows.Forms.Label OutputFolderCountValueLabel;
        private System.Windows.Forms.Label OutputFolderCountLabel;
        private System.Windows.Forms.Label ReductionPercentValueLabel;
        private System.Windows.Forms.Label ReductionPercentLabel;
        private System.Windows.Forms.Label ReductionSizeValueLabel;
        private System.Windows.Forms.Label ReductionSizeLabel;
        private System.Windows.Forms.Label DeleteOptionsLabel;
        private DataJuggler.Win.Controls.LabelCheckBoxControl BinCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl ObjCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl PackagesCheckBox;
        private System.Windows.Forms.ListBox IgnoreFoldersListBox;
        private System.Windows.Forms.Label IngoreFoldersLabel;
        private System.Windows.Forms.Button AddIgnoreFolderButton;
        private System.Windows.Forms.TextBox IgnorFolderTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.Button OpenShipmentButton;
        private System.Windows.Forms.Button SaveShipmentButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl ShipmentNameControl;
        private System.Windows.Forms.Label OptionsLabel;
        private DataJuggler.Win.Controls.LabelCheckBoxControl CopyCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl ZipCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AddTimeStampCheckBox;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label DestinationLabel;
    }
}


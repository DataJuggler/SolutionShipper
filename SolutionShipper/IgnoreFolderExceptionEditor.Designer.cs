

#region using statements


#endregion

namespace SolutionShipper
{

    #region class IgnoreFolderExceptionEditor
    /// <summary>
    /// method [Enter Method Description]
    /// </summary>
    partial class IgnoreFolderExceptionEditor
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label IgnoreFolderNameLabel;
        private System.Windows.Forms.Label IgnoreFolderLabel;
        private DataJuggler.Win.Controls.LabelComboBoxControl IgnoreExceptionType;
        private DataJuggler.Win.Controls.LabelTextBoxControl ExceptionTextControl;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button AddIgnoreExceptionButton;
        private System.Windows.Forms.ListBox IgnoreFoldersListBox;
        private System.Windows.Forms.Label IngoreFoldersLabel;
        private DataJuggler.Win.Controls.LabelTextBoxControl ExceptionNameControl;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgnoreFolderExceptionEditor));
            this.IgnoreFolderNameLabel = new System.Windows.Forms.Label();
            this.IgnoreFolderLabel = new System.Windows.Forms.Label();
            this.IgnoreExceptionType = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.ExceptionTextControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.DoneButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AddIgnoreExceptionButton = new System.Windows.Forms.Button();
            this.IgnoreFoldersListBox = new System.Windows.Forms.ListBox();
            this.IngoreFoldersLabel = new System.Windows.Forms.Label();
            this.ExceptionNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SuspendLayout();
            // 
            // IgnoreFolderNameLabel
            // 
            this.IgnoreFolderNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.IgnoreFolderNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreFolderNameLabel.Location = new System.Drawing.Point(148, 24);
            this.IgnoreFolderNameLabel.Name = "IgnoreFolderNameLabel";
            this.IgnoreFolderNameLabel.Size = new System.Drawing.Size(98, 24);
            this.IgnoreFolderNameLabel.TabIndex = 8;
            this.IgnoreFolderNameLabel.Text = "[Name]";
            this.IgnoreFolderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IgnoreFolderLabel
            // 
            this.IgnoreFolderLabel.BackColor = System.Drawing.Color.Transparent;
            this.IgnoreFolderLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreFolderLabel.Location = new System.Drawing.Point(12, 24);
            this.IgnoreFolderLabel.Name = "IgnoreFolderLabel";
            this.IgnoreFolderLabel.Size = new System.Drawing.Size(140, 24);
            this.IgnoreFolderLabel.TabIndex = 7;
            this.IgnoreFolderLabel.Text = "Folder:";
            this.IgnoreFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IgnoreExceptionType
            // 
            this.IgnoreExceptionType.BackColor = System.Drawing.Color.Transparent;
            this.IgnoreExceptionType.ComboBoxLeftMargin = 1;
            this.IgnoreExceptionType.ComboBoxText = "";
            this.IgnoreExceptionType.ComoboBoxFont = null;
            this.IgnoreExceptionType.Editable = true;
            this.IgnoreExceptionType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreExceptionType.LabelBottomMargin = 0;
            this.IgnoreExceptionType.LabelColor = System.Drawing.SystemColors.ControlText;
            this.IgnoreExceptionType.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreExceptionType.LabelText = "Exception Type:";
            this.IgnoreExceptionType.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IgnoreExceptionType.LabelTopMargin = 0;
            this.IgnoreExceptionType.LabelWidth = 200;
            this.IgnoreExceptionType.List = null;
            this.IgnoreExceptionType.Location = new System.Drawing.Point(12, 382);
            this.IgnoreExceptionType.Name = "IgnoreExceptionType";
            this.IgnoreExceptionType.SelectedIndex = -1;
            this.IgnoreExceptionType.SelectedIndexListener = null;
            this.IgnoreExceptionType.Size = new System.Drawing.Size(558, 28);
            this.IgnoreExceptionType.Sorted = true;
            this.IgnoreExceptionType.Source = null;
            this.IgnoreExceptionType.TabIndex = 9;
            // 
            // ExceptionTextControl
            // 
            this.ExceptionTextControl.BackColor = System.Drawing.Color.Transparent;
            this.ExceptionTextControl.BottomMargin = 0;
            this.ExceptionTextControl.Editable = true;
            this.ExceptionTextControl.Encrypted = false;
            this.ExceptionTextControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExceptionTextControl.LabelBottomMargin = 0;
            this.ExceptionTextControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.ExceptionTextControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExceptionTextControl.LabelText = "Text:";
            this.ExceptionTextControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExceptionTextControl.LabelTopMargin = 4;
            this.ExceptionTextControl.LabelWidth = 200;
            this.ExceptionTextControl.Location = new System.Drawing.Point(12, 424);
            this.ExceptionTextControl.MultiLine = false;
            this.ExceptionTextControl.Name = "ExceptionTextControl";
            this.ExceptionTextControl.OnTextChangedListener = null;
            this.ExceptionTextControl.PasswordMode = false;
            this.ExceptionTextControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExceptionTextControl.Size = new System.Drawing.Size(558, 28);
            this.ExceptionTextControl.TabIndex = 10;
            this.ExceptionTextControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExceptionTextControl.TextBoxBottomMargin = 0;
            this.ExceptionTextControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ExceptionTextControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ExceptionTextControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F);
            this.ExceptionTextControl.TextBoxTopMargin = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DoneButton.Location = new System.Drawing.Point(458, 488);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(112, 36);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneExceptionsButton_Click);
            this.DoneButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.DoneButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(16, 282);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(468, 24);
            this.InfoLabel.TabIndex = 34;
            this.InfoLabel.Text = "Press Delete to remove an item";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddIgnoreExceptionButton
            // 
            this.AddIgnoreExceptionButton.BackColor = System.Drawing.Color.Transparent;
            this.AddIgnoreExceptionButton.BackgroundImage = global::SolutionShipper.Properties.Resources.DarkBlueButton;
            this.AddIgnoreExceptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddIgnoreExceptionButton.FlatAppearance.BorderSize = 0;
            this.AddIgnoreExceptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddIgnoreExceptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddIgnoreExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIgnoreExceptionButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIgnoreExceptionButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddIgnoreExceptionButton.Location = new System.Drawing.Point(490, 281);
            this.AddIgnoreExceptionButton.Name = "AddIgnoreExceptionButton";
            this.AddIgnoreExceptionButton.Size = new System.Drawing.Size(80, 36);
            this.AddIgnoreExceptionButton.TabIndex = 33;
            this.AddIgnoreExceptionButton.Text = "Add";
            this.AddIgnoreExceptionButton.UseVisualStyleBackColor = false;
            this.AddIgnoreExceptionButton.Click += new System.EventHandler(this.AddIgnoreExceptionButton_Click);
            this.AddIgnoreExceptionButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.AddIgnoreExceptionButton.MouseLeave += new System.EventHandler(this.Button_Enter);
            // 
            // IgnoreFoldersListBox
            // 
            this.IgnoreFoldersListBox.FormattingEnabled = true;
            this.IgnoreFoldersListBox.ItemHeight = 23;
            this.IgnoreFoldersListBox.Location = new System.Drawing.Point(21, 90);
            this.IgnoreFoldersListBox.Name = "IgnoreFoldersListBox";
            this.IgnoreFoldersListBox.Size = new System.Drawing.Size(549, 188);
            this.IgnoreFoldersListBox.TabIndex = 32;
            this.IgnoreFoldersListBox.SelectedIndexChanged += new System.EventHandler(this.IgnoreFoldersListBox_SelectedIndexChanged);
            this.IgnoreFoldersListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IgnoreFoldersListBox_KeyDown);
            // 
            // IngoreFoldersLabel
            // 
            this.IngoreFoldersLabel.BackColor = System.Drawing.Color.Transparent;
            this.IngoreFoldersLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngoreFoldersLabel.Location = new System.Drawing.Point(12, 59);
            this.IngoreFoldersLabel.Name = "IngoreFoldersLabel";
            this.IngoreFoldersLabel.Size = new System.Drawing.Size(140, 24);
            this.IngoreFoldersLabel.TabIndex = 35;
            this.IngoreFoldersLabel.Text = "Exceptions:";
            this.IngoreFoldersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExceptionNameControl
            // 
            this.ExceptionNameControl.BackColor = System.Drawing.Color.Transparent;
            this.ExceptionNameControl.BottomMargin = 0;
            this.ExceptionNameControl.Editable = true;
            this.ExceptionNameControl.Encrypted = false;
            this.ExceptionNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExceptionNameControl.LabelBottomMargin = 0;
            this.ExceptionNameControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.ExceptionNameControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExceptionNameControl.LabelText = "Exception Name:";
            this.ExceptionNameControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExceptionNameControl.LabelTopMargin = 4;
            this.ExceptionNameControl.LabelWidth = 200;
            this.ExceptionNameControl.Location = new System.Drawing.Point(12, 340);
            this.ExceptionNameControl.MultiLine = false;
            this.ExceptionNameControl.Name = "ExceptionNameControl";
            this.ExceptionNameControl.OnTextChangedListener = null;
            this.ExceptionNameControl.PasswordMode = false;
            this.ExceptionNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExceptionNameControl.Size = new System.Drawing.Size(558, 28);
            this.ExceptionNameControl.TabIndex = 36;
            this.ExceptionNameControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExceptionNameControl.TextBoxBottomMargin = 0;
            this.ExceptionNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ExceptionNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ExceptionNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F);
            this.ExceptionNameControl.TextBoxTopMargin = 0;
            // 
            // IgnoreFolderExceptionEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SolutionShipper.Properties.Resources.OrangeBackground;
            this.ClientSize = new System.Drawing.Size(604, 541);
            this.Controls.Add(this.ExceptionNameControl);
            this.Controls.Add(this.IngoreFoldersLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AddIgnoreExceptionButton);
            this.Controls.Add(this.IgnoreFoldersListBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ExceptionTextControl);
            this.Controls.Add(this.IgnoreExceptionType);
            this.Controls.Add(this.IgnoreFolderNameLabel);
            this.Controls.Add(this.IgnoreFolderLabel);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IgnoreFolderExceptionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ignore Folder Exception";
            this.ResumeLayout(false);

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}

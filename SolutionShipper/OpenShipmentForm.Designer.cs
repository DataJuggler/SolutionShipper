namespace SolutionShipper
{
    partial class OpenShipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenShipmentForm));
            this.ShipmentsListBox = new System.Windows.Forms.ListBox();
            this.ShipmentsLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShipmentsListBox
            // 
            this.ShipmentsListBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentsListBox.FormattingEnabled = true;
            this.ShipmentsListBox.ItemHeight = 23;
            this.ShipmentsListBox.Location = new System.Drawing.Point(15, 38);
            this.ShipmentsListBox.Name = "ShipmentsListBox";
            this.ShipmentsListBox.Size = new System.Drawing.Size(311, 280);
            this.ShipmentsListBox.TabIndex = 0;
            this.ShipmentsListBox.DoubleClick += new System.EventHandler(this.ShipmentsListBox_DoubleClick);
            this.ShipmentsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShipmentsListBox_KeyDown);
            // 
            // ShipmentsLabel
            // 
            this.ShipmentsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShipmentsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentsLabel.Location = new System.Drawing.Point(15, 12);
            this.ShipmentsLabel.Name = "ShipmentsLabel";
            this.ShipmentsLabel.Size = new System.Drawing.Size(120, 24);
            this.ShipmentsLabel.TabIndex = 1;
            this.ShipmentsLabel.Text = "Shipments";
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(0, 329);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(344, 32);
            this.InfoLabel.TabIndex = 32;
            this.InfoLabel.Text = "Press Delete to remove; double click to open.\r\n\r\n.";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenShipmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SolutionShipper.Properties.Resources.OrangeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ShipmentsLabel);
            this.Controls.Add(this.ShipmentsListBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenShipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenShipmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShipmentsListBox;
        private System.Windows.Forms.Label ShipmentsLabel;
        private System.Windows.Forms.Label InfoLabel;
    }
}
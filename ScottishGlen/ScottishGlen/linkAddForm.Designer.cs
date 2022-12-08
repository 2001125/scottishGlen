
namespace ScottishGlen
{
    partial class linkAddForm
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
            this.displayHardware = new System.Windows.Forms.ListBox();
            this.displaySoftware = new System.Windows.Forms.ListBox();
            this.hardwareLabel = new System.Windows.Forms.Label();
            this.softwareLabel = new System.Windows.Forms.Label();
            this.addLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayHardware
            // 
            this.displayHardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.displayHardware.FormattingEnabled = true;
            this.displayHardware.Location = new System.Drawing.Point(12, 25);
            this.displayHardware.Name = "displayHardware";
            this.displayHardware.Size = new System.Drawing.Size(384, 342);
            this.displayHardware.TabIndex = 29;
            // 
            // displaySoftware
            // 
            this.displaySoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.displaySoftware.FormattingEnabled = true;
            this.displaySoftware.Location = new System.Drawing.Point(404, 25);
            this.displaySoftware.Name = "displaySoftware";
            this.displaySoftware.Size = new System.Drawing.Size(384, 342);
            this.displaySoftware.TabIndex = 30;
            // 
            // hardwareLabel
            // 
            this.hardwareLabel.AutoSize = true;
            this.hardwareLabel.Location = new System.Drawing.Point(12, 6);
            this.hardwareLabel.Name = "hardwareLabel";
            this.hardwareLabel.Size = new System.Drawing.Size(53, 13);
            this.hardwareLabel.TabIndex = 31;
            this.hardwareLabel.Text = "Hardware";
            // 
            // softwareLabel
            // 
            this.softwareLabel.AutoSize = true;
            this.softwareLabel.Location = new System.Drawing.Point(401, 6);
            this.softwareLabel.Name = "softwareLabel";
            this.softwareLabel.Size = new System.Drawing.Size(49, 13);
            this.softwareLabel.TabIndex = 32;
            this.softwareLabel.Text = "Software";
            // 
            // addLinkButton
            // 
            this.addLinkButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addLinkButton.Location = new System.Drawing.Point(315, 373);
            this.addLinkButton.Name = "addLinkButton";
            this.addLinkButton.Size = new System.Drawing.Size(173, 65);
            this.addLinkButton.TabIndex = 33;
            this.addLinkButton.Text = "Add Link";
            this.addLinkButton.UseVisualStyleBackColor = false;
            this.addLinkButton.Click += new System.EventHandler(this.addLinkButton_Click);
            // 
            // linkAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addLinkButton);
            this.Controls.Add(this.softwareLabel);
            this.Controls.Add(this.hardwareLabel);
            this.Controls.Add(this.displaySoftware);
            this.Controls.Add(this.displayHardware);
            this.Name = "linkAddForm";
            this.Text = "Add Link";
            this.Load += new System.EventHandler(this.linkAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayHardware;
        private System.Windows.Forms.ListBox displaySoftware;
        private System.Windows.Forms.Label hardwareLabel;
        private System.Windows.Forms.Label softwareLabel;
        private System.Windows.Forms.Button addLinkButton;
    }
}
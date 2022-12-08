
namespace ScottishGlen
{
    partial class softwareEditForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.osBox = new System.Windows.Forms.TextBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.displaySoftware = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.OliveDrab;
            this.editButton.Location = new System.Drawing.Point(48, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 33);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Confirm Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.manufacturerBox.Location = new System.Drawing.Point(48, 130);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 22;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(47, 114);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLabel.TabIndex = 21;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // versionBox
            // 
            this.versionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.versionBox.Location = new System.Drawing.Point(48, 91);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(100, 20);
            this.versionBox.TabIndex = 20;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(45, 75);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 19;
            this.versionLabel.Text = "Version";
            // 
            // osBox
            // 
            this.osBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.osBox.Location = new System.Drawing.Point(48, 52);
            this.osBox.Name = "osBox";
            this.osBox.Size = new System.Drawing.Size(100, 20);
            this.osBox.TabIndex = 18;
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(45, 35);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(90, 13);
            this.osLabel.TabIndex = 17;
            this.osLabel.Text = "Operating System";
            // 
            // displaySoftware
            // 
            this.displaySoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.displaySoftware.FormattingEnabled = true;
            this.displaySoftware.Location = new System.Drawing.Point(251, 35);
            this.displaySoftware.Name = "displaySoftware";
            this.displaySoftware.Size = new System.Drawing.Size(504, 381);
            this.displaySoftware.TabIndex = 16;
            this.displaySoftware.SelectedIndexChanged += new System.EventHandler(this.displaySoftware_SelectedIndexChanged);
            // 
            // softwareEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.osBox);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.displaySoftware);
            this.Name = "softwareEditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox versionBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox osBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.ListBox displaySoftware;
    }
}

namespace ScottishGlen
{
    partial class softwareAddForm
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
            this.scanSys = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.displayListData = new System.Windows.Forms.ListBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.versionBox = new System.Windows.Forms.TextBox();
            this.osBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scanSys
            // 
            this.scanSys.BackColor = System.Drawing.Color.OliveDrab;
            this.scanSys.Location = new System.Drawing.Point(45, 260);
            this.scanSys.Name = "scanSys";
            this.scanSys.Size = new System.Drawing.Size(99, 31);
            this.scanSys.TabIndex = 36;
            this.scanSys.Text = "Scan System";
            this.scanSys.UseVisualStyleBackColor = false;
            this.scanSys.Click += new System.EventHandler(this.scanSys_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(42, 61);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 30;
            this.versionLabel.Text = "Version";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(42, 22);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(90, 13);
            this.osLabel.TabIndex = 29;
            this.osLabel.Text = "Operating System";
            // 
            // displayListData
            // 
            this.displayListData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.displayListData.FormattingEnabled = true;
            this.displayListData.Location = new System.Drawing.Point(253, 22);
            this.displayListData.Name = "displayListData";
            this.displayListData.Size = new System.Drawing.Size(506, 381);
            this.displayListData.TabIndex = 28;
            // 
            // addDataButton
            // 
            this.addDataButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addDataButton.Location = new System.Drawing.Point(46, 157);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(99, 31);
            this.addDataButton.TabIndex = 27;
            this.addDataButton.Text = "Submit";
            this.addDataButton.UseVisualStyleBackColor = false;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // versionBox
            // 
            this.versionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.versionBox.Location = new System.Drawing.Point(45, 77);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(100, 20);
            this.versionBox.TabIndex = 21;
            // 
            // osBox
            // 
            this.osBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.osBox.Location = new System.Drawing.Point(45, 38);
            this.osBox.Name = "osBox";
            this.osBox.Size = new System.Drawing.Size(100, 20);
            this.osBox.TabIndex = 20;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(43, 100);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLabel.TabIndex = 31;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.manufacturerBox.Location = new System.Drawing.Point(45, 116);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 22;
            // 
            // softwareAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scanSys);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.displayListData);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.osBox);
            this.Name = "softwareAddForm";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.softwareAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button scanSys;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.ListBox displayListData;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.TextBox versionBox;
        private System.Windows.Forms.TextBox osBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox manufacturerBox;
    }
}
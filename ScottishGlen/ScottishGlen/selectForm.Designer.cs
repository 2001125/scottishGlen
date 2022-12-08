
namespace ScottishGlen
{
    partial class selectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hardwareButton = new System.Windows.Forms.Button();
            this.softwareButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.linkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 83);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // hardwareButton
            // 
            this.hardwareButton.BackColor = System.Drawing.Color.OliveDrab;
            this.hardwareButton.Location = new System.Drawing.Point(53, 198);
            this.hardwareButton.Name = "hardwareButton";
            this.hardwareButton.Size = new System.Drawing.Size(227, 111);
            this.hardwareButton.TabIndex = 2;
            this.hardwareButton.Text = "Hardware";
            this.hardwareButton.UseVisualStyleBackColor = false;
            this.hardwareButton.Click += new System.EventHandler(this.hardwareButton_Click);
            // 
            // softwareButton
            // 
            this.softwareButton.BackColor = System.Drawing.Color.OliveDrab;
            this.softwareButton.Location = new System.Drawing.Point(512, 198);
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.Size = new System.Drawing.Size(220, 111);
            this.softwareButton.TabIndex = 3;
            this.softwareButton.Text = "Software";
            this.softwareButton.UseVisualStyleBackColor = false;
            this.softwareButton.Click += new System.EventHandler(this.softwareButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OliveDrab;
            this.exitButton.Location = new System.Drawing.Point(340, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // linkButton
            // 
            this.linkButton.BackColor = System.Drawing.Color.OliveDrab;
            this.linkButton.Location = new System.Drawing.Point(286, 198);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(220, 111);
            this.linkButton.TabIndex = 5;
            this.linkButton.Text = "Links";
            this.linkButton.UseVisualStyleBackColor = false;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.softwareButton);
            this.Controls.Add(this.hardwareButton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "selectForm";
            this.Text = "Select";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hardwareButton;
        private System.Windows.Forms.Button softwareButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button linkButton;
    }
}
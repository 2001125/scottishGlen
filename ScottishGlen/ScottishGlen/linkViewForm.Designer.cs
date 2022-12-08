
namespace ScottishGlen
{
    partial class linkViewForm
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
            this.displayLinks = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.goToAddLink = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLinks
            // 
            this.displayLinks.FormattingEnabled = true;
            this.displayLinks.Location = new System.Drawing.Point(140, 12);
            this.displayLinks.Name = "displayLinks";
            this.displayLinks.Size = new System.Drawing.Size(504, 342);
            this.displayLinks.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(482, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 54);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // goToAddLink
            // 
            this.goToAddLink.Location = new System.Drawing.Point(140, 359);
            this.goToAddLink.Name = "goToAddLink";
            this.goToAddLink.Size = new System.Drawing.Size(165, 55);
            this.goToAddLink.TabIndex = 19;
            this.goToAddLink.Text = "Add Link";
            this.goToAddLink.UseVisualStyleBackColor = true;
            this.goToAddLink.Click += new System.EventHandler(this.goToAddLink_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(311, 360);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(165, 54);
            this.Refresh.TabIndex = 20;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // linkViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.goToAddLink);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.displayLinks);
            this.Name = "linkViewForm";
            this.Text = "Links";
            this.Load += new System.EventHandler(this.linkViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox displayLinks;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button goToAddLink;
        private System.Windows.Forms.Button Refresh;
    }
}
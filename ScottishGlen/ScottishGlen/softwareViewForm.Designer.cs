
namespace ScottishGlen
{
    partial class softwareViewForm
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
            this.viewSoftwareGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewSoftwareGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSoftwareGrid
            // 
            this.viewSoftwareGrid.AllowUserToAddRows = false;
            this.viewSoftwareGrid.AllowUserToDeleteRows = false;
            this.viewSoftwareGrid.AllowUserToResizeColumns = false;
            this.viewSoftwareGrid.AllowUserToResizeRows = false;
            this.viewSoftwareGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewSoftwareGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.viewSoftwareGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSoftwareGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.viewSoftwareGrid.Location = new System.Drawing.Point(100, 48);
            this.viewSoftwareGrid.Name = "viewSoftwareGrid";
            this.viewSoftwareGrid.Size = new System.Drawing.Size(575, 356);
            this.viewSoftwareGrid.TabIndex = 1;
            // 
            // softwareViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewSoftwareGrid);
            this.Name = "softwareViewForm";
            this.Text = "View";
            this.Load += new System.EventHandler(this.softwareViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSoftwareGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewSoftwareGrid;
    }
}
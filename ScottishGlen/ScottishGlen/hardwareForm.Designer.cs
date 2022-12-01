
namespace ScottishGlen
{
    partial class hardwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hardwareForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toAdd = new System.Windows.Forms.Button();
            this.toView = new System.Windows.Forms.Button();
            this.toEdit = new System.Windows.Forms.Button();
            this.toDelete = new System.Windows.Forms.Button();
            this.hardwareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toAdd
            // 
            this.toAdd.Location = new System.Drawing.Point(175, 176);
            this.toAdd.Name = "toAdd";
            this.toAdd.Size = new System.Drawing.Size(152, 44);
            this.toAdd.TabIndex = 1;
            this.toAdd.Text = "Add";
            this.toAdd.UseVisualStyleBackColor = true;
            this.toAdd.Click += new System.EventHandler(this.toAdd_Click);
            // 
            // toView
            // 
            this.toView.Location = new System.Drawing.Point(454, 176);
            this.toView.Name = "toView";
            this.toView.Size = new System.Drawing.Size(152, 44);
            this.toView.TabIndex = 2;
            this.toView.Text = "View";
            this.toView.UseVisualStyleBackColor = true;
            // 
            // toEdit
            // 
            this.toEdit.Location = new System.Drawing.Point(175, 280);
            this.toEdit.Name = "toEdit";
            this.toEdit.Size = new System.Drawing.Size(152, 44);
            this.toEdit.TabIndex = 3;
            this.toEdit.Text = "Edit";
            this.toEdit.UseVisualStyleBackColor = true;
            // 
            // toDelete
            // 
            this.toDelete.Location = new System.Drawing.Point(454, 280);
            this.toDelete.Name = "toDelete";
            this.toDelete.Size = new System.Drawing.Size(152, 44);
            this.toDelete.TabIndex = 4;
            this.toDelete.Text = "Delete";
            this.toDelete.UseVisualStyleBackColor = true;
            // 
            // hardwareLabel
            // 
            this.hardwareLabel.AutoSize = true;
            this.hardwareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareLabel.Location = new System.Drawing.Point(342, 132);
            this.hardwareLabel.Name = "hardwareLabel";
            this.hardwareLabel.Size = new System.Drawing.Size(104, 25);
            this.hardwareLabel.TabIndex = 5;
            this.hardwareLabel.Text = "Hardware";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hardwareLabel);
            this.Controls.Add(this.toDelete);
            this.Controls.Add(this.toEdit);
            this.Controls.Add(this.toView);
            this.Controls.Add(this.toAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "ScottishGlen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button toAdd;
        private System.Windows.Forms.Button toView;
        private System.Windows.Forms.Button toEdit;
        private System.Windows.Forms.Button toDelete;
        private System.Windows.Forms.Label hardwareLabel;
    }
}
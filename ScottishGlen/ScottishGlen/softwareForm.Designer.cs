
namespace ScottishGlen
{
    partial class softwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(softwareForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hardwareLabel = new System.Windows.Forms.Label();
            this.toView = new System.Windows.Forms.Button();
            this.toAdd = new System.Windows.Forms.Button();
            this.toEdit = new System.Windows.Forms.Button();
            this.toDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // hardwareLabel
            // 
            this.hardwareLabel.AutoSize = true;
            this.hardwareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareLabel.Location = new System.Drawing.Point(353, 156);
            this.hardwareLabel.Name = "hardwareLabel";
            this.hardwareLabel.Size = new System.Drawing.Size(96, 25);
            this.hardwareLabel.TabIndex = 7;
            this.hardwareLabel.Text = "Software";
            // 
            // toView
            // 
            this.toView.BackColor = System.Drawing.Color.OliveDrab;
            this.toView.Location = new System.Drawing.Point(440, 197);
            this.toView.Name = "toView";
            this.toView.Size = new System.Drawing.Size(152, 44);
            this.toView.TabIndex = 8;
            this.toView.Text = "View";
            this.toView.UseVisualStyleBackColor = false;
            this.toView.Click += new System.EventHandler(this.toView_Click);
            // 
            // toAdd
            // 
            this.toAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.toAdd.Location = new System.Drawing.Point(203, 197);
            this.toAdd.Name = "toAdd";
            this.toAdd.Size = new System.Drawing.Size(152, 44);
            this.toAdd.TabIndex = 9;
            this.toAdd.Text = "Add";
            this.toAdd.UseVisualStyleBackColor = false;
            this.toAdd.Click += new System.EventHandler(this.toAdd_Click);
            // 
            // toEdit
            // 
            this.toEdit.BackColor = System.Drawing.Color.OliveDrab;
            this.toEdit.Location = new System.Drawing.Point(203, 289);
            this.toEdit.Name = "toEdit";
            this.toEdit.Size = new System.Drawing.Size(152, 44);
            this.toEdit.TabIndex = 10;
            this.toEdit.Text = "Edit";
            this.toEdit.UseVisualStyleBackColor = false;
            this.toEdit.Click += new System.EventHandler(this.toEdit_Click);
            // 
            // toDelete
            // 
            this.toDelete.BackColor = System.Drawing.Color.OliveDrab;
            this.toDelete.Location = new System.Drawing.Point(440, 289);
            this.toDelete.Name = "toDelete";
            this.toDelete.Size = new System.Drawing.Size(152, 44);
            this.toDelete.TabIndex = 11;
            this.toDelete.Text = "Delete";
            this.toDelete.UseVisualStyleBackColor = false;
            this.toDelete.Click += new System.EventHandler(this.toDelete_Click);
            // 
            // softwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toDelete);
            this.Controls.Add(this.toEdit);
            this.Controls.Add(this.toAdd);
            this.Controls.Add(this.toView);
            this.Controls.Add(this.hardwareLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "softwareForm";
            this.Text = "Software";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hardwareLabel;
        private System.Windows.Forms.Button toView;
        private System.Windows.Forms.Button toAdd;
        private System.Windows.Forms.Button toEdit;
        private System.Windows.Forms.Button toDelete;
    }
}
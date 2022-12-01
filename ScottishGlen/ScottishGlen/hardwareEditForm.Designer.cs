
namespace ScottishGlen
{
    partial class hardwareEditForm
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
            this.displayAssets = new System.Windows.Forms.ListBox();
            this.sysNameLabel = new System.Windows.Forms.Label();
            this.sysNameBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.sysTypeBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayAssets
            // 
            this.displayAssets.FormattingEnabled = true;
            this.displayAssets.Location = new System.Drawing.Point(271, 32);
            this.displayAssets.Name = "displayAssets";
            this.displayAssets.Size = new System.Drawing.Size(504, 381);
            this.displayAssets.TabIndex = 0;
            this.displayAssets.SelectedIndexChanged += new System.EventHandler(this.displayAssets_SelectedIndexChanged);
            // 
            // sysNameLabel
            // 
            this.sysNameLabel.AutoSize = true;
            this.sysNameLabel.Location = new System.Drawing.Point(65, 32);
            this.sysNameLabel.Name = "sysNameLabel";
            this.sysNameLabel.Size = new System.Drawing.Size(72, 13);
            this.sysNameLabel.TabIndex = 1;
            this.sysNameLabel.Text = "System Name";
            // 
            // sysNameBox
            // 
            this.sysNameBox.Location = new System.Drawing.Point(68, 49);
            this.sysNameBox.Name = "sysNameBox";
            this.sysNameBox.Size = new System.Drawing.Size(100, 20);
            this.sysNameBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(65, 72);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(68, 88);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 4;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(67, 111);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLabel.TabIndex = 5;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(68, 127);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(65, 151);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(68, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "System Type";
            // 
            // sysTypeBox
            // 
            this.sysTypeBox.Location = new System.Drawing.Point(68, 167);
            this.sysTypeBox.Name = "sysTypeBox";
            this.sysTypeBox.Size = new System.Drawing.Size(100, 20);
            this.sysTypeBox.TabIndex = 8;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(67, 190);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP Address";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(68, 206);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 10;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(66, 229);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Purchase Date";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(68, 246);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 12;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(67, 269);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 13;
            this.notesLabel.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(68, 285);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(100, 20);
            this.notesBox.TabIndex = 14;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(68, 329);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 33);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Confirm Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // hardwareEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.sysTypeBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.sysNameBox);
            this.Controls.Add(this.sysNameLabel);
            this.Controls.Add(this.displayAssets);
            this.Name = "hardwareEditForm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayAssets;
        private System.Windows.Forms.Label sysNameLabel;
        private System.Windows.Forms.TextBox sysNameBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox sysTypeBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button editButton;
    }
}
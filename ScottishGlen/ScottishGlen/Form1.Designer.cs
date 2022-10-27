
namespace ScottishGlen
{
    partial class Form1
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.purchDateBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.displayListData = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.purchDateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(62, 47);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(62, 86);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 2;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(62, 125);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 3;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(62, 164);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 4;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(62, 203);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 5;
            // 
            // purchDateBox
            // 
            this.purchDateBox.Location = new System.Drawing.Point(62, 242);
            this.purchDateBox.Name = "purchDateBox";
            this.purchDateBox.Size = new System.Drawing.Size(100, 20);
            this.purchDateBox.TabIndex = 6;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(62, 281);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(100, 20);
            this.noteBox.TabIndex = 7;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(75, 338);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(75, 23);
            this.addDataButton.TabIndex = 8;
            this.addDataButton.Text = "Submit";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // displayListData
            // 
            this.displayListData.FormattingEnabled = true;
            this.displayListData.Location = new System.Drawing.Point(270, 31);
            this.displayListData.Name = "displayListData";
            this.displayListData.Size = new System.Drawing.Size(506, 381);
            this.displayListData.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(59, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "System Name";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(59, 70);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 11;
            this.modelLabel.Text = "Model";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(60, 109);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLabel.TabIndex = 12;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(60, 148);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(68, 13);
            this.typeLabel.TabIndex = 13;
            this.typeLabel.Text = "System Type";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(60, 187);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 14;
            this.ipLabel.Text = "IP Address";
            // 
            // purchDateLabel
            // 
            this.purchDateLabel.AutoSize = true;
            this.purchDateLabel.Location = new System.Drawing.Point(60, 226);
            this.purchDateLabel.Name = "purchDateLabel";
            this.purchDateLabel.Size = new System.Drawing.Size(78, 13);
            this.purchDateLabel.TabIndex = 15;
            this.purchDateLabel.Text = "Purchase Date";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(60, 265);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 16;
            this.notesLabel.Text = "Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.purchDateLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.displayListData);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.purchDateBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox purchDateBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.ListBox displayListData;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label purchDateLabel;
        private System.Windows.Forms.Label notesLabel;
    }
}



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
            this.displayData = new System.Windows.Forms.RichTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.purchDateBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayData
            // 
            this.displayData.Location = new System.Drawing.Point(399, 69);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(377, 296);
            this.displayData.TabIndex = 0;
            this.displayData.Text = "";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(62, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(62, 105);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 2;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Location = new System.Drawing.Point(62, 142);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerBox.TabIndex = 3;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(62, 180);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 4;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(62, 217);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 5;
            // 
            // purchDateBox
            // 
            this.purchDateBox.Location = new System.Drawing.Point(62, 254);
            this.purchDateBox.Name = "purchDateBox";
            this.purchDateBox.Size = new System.Drawing.Size(100, 20);
            this.purchDateBox.TabIndex = 6;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(62, 292);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(100, 20);
            this.noteBox.TabIndex = 7;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(73, 342);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(75, 23);
            this.addDataButton.TabIndex = 8;
            this.addDataButton.Text = "Submit";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.purchDateBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.manufacturerBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.displayData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayData;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox purchDateBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Button addDataButton;
    }
}


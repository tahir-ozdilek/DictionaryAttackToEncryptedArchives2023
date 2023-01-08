namespace DictionaryAttackToEncryptedArchives
{
    partial class DictionaryAttackToArchiveFiles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.arcPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.dicpathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(258, 165);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(42, 15);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arcPathBox
            // 
            this.arcPathBox.Location = new System.Drawing.Point(19, 62);
            this.arcPathBox.Name = "arcPathBox";
            this.arcPathBox.Size = new System.Drawing.Size(506, 23);
            this.arcPathBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paste archive file path here:  \r\nSharpCompress: Rar, Zip, GZip, BZip2, Tar, Xz, L" +
    "Zip\r\nSevenZipSharp: 7z // Zip, GZip, BZip2, Tar, Xz, ";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(100, 165);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(96, 15);
            this.counterLabel.TabIndex = 4;
            this.counterLabel.Text = "Tried Passwords: ";
            // 
            // dicpathBox
            // 
            this.dicpathBox.Location = new System.Drawing.Point(19, 114);
            this.dicpathBox.Name = "dicpathBox";
            this.dicpathBox.Size = new System.Drawing.Size(506, 23);
            this.dicpathBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paste dictionary path here:";
            // 
            // DictionaryAttackToArchiveFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dicpathBox);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arcPathBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLabel);
            this.Name = "DictionaryAttackToArchiveFiles";
            this.Text = "DictionaryAttackToArchiveFiles 2023";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resultLabel;
        private Button button1;
        private TextBox arcPathBox;
        private Label label2;
        private Label counterLabel;
        private TextBox dicpathBox;
        private Label label3;
    }
}
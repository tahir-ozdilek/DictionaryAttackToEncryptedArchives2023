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
            resultLabel = new Label();
            button1 = new Button();
            arcPathBox = new TextBox();
            label2 = new Label();
            counterLabel = new Label();
            dicpathBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(258, 163);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(42, 15);
            resultLabel.TabIndex = 0;
            resultLabel.Text = "Result:";
            // 
            // button1
            // 
            button1.Location = new Point(19, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // arcPathBox
            // 
            arcPathBox.Location = new Point(19, 62);
            arcPathBox.Name = "arcPathBox";
            arcPathBox.Size = new Size(506, 23);
            arcPathBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(237, 45);
            label2.TabIndex = 3;
            label2.Text = "Paste archive file path here:  \r\nAspose: Rar\r\nSevenZipSharp: 7z, Zip, GZip, BZip2, Tar, Xz, ";
            // 
            // counterLabel
            // 
            counterLabel.AutoSize = true;
            counterLabel.Location = new Point(100, 163);
            counterLabel.Name = "counterLabel";
            counterLabel.Size = new Size(96, 15);
            counterLabel.TabIndex = 4;
            counterLabel.Text = "Tried Passwords: ";
            // 
            // dicpathBox
            // 
            dicpathBox.Location = new Point(19, 114);
            dicpathBox.Name = "dicpathBox";
            dicpathBox.Size = new Size(506, 23);
            dicpathBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 96);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 6;
            label3.Text = "Paste dictionary path here:";
            // 
            // DictionaryAttackToArchiveFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 205);
            Controls.Add(label3);
            Controls.Add(dicpathBox);
            Controls.Add(counterLabel);
            Controls.Add(label2);
            Controls.Add(arcPathBox);
            Controls.Add(button1);
            Controls.Add(resultLabel);
            Name = "DictionaryAttackToArchiveFiles";
            Text = "DictionaryAttackToArchiveFiles 2023";
            ResumeLayout(false);
            PerformLayout();
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
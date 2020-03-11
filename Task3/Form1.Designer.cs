namespace Task3
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
            this.EncryptButton = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileReadButton1 = new System.Windows.Forms.Button();
            this.FileWriteButton2 = new System.Windows.Forms.Button();
            this.EncryptedText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileReadButton2 = new System.Windows.Forms.Button();
            this.FileWriteButton1 = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.SecretKeyButton = new System.Windows.Forms.Button();
            this.SecretKeyCancelButton = new System.Windows.Forms.Button();
            this.secretKeyTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(16, 585);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(125, 64);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(16, 124);
            this.InputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(664, 452);
            this.InputText.TabIndex = 2;
            this.InputText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type text you want to encrypt or ";
            // 
            // FileReadButton1
            // 
            this.FileReadButton1.Location = new System.Drawing.Point(528, 75);
            this.FileReadButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileReadButton1.Name = "FileReadButton1";
            this.FileReadButton1.Size = new System.Drawing.Size(149, 42);
            this.FileReadButton1.TabIndex = 4;
            this.FileReadButton1.Text = "Read from the file";
            this.FileReadButton1.UseVisualStyleBackColor = true;
            this.FileReadButton1.Click += new System.EventHandler(this.FileReadButton1_Click);
            // 
            // FileWriteButton2
            // 
            this.FileWriteButton2.Location = new System.Drawing.Point(1379, 585);
            this.FileWriteButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileWriteButton2.Name = "FileWriteButton2";
            this.FileWriteButton2.Size = new System.Drawing.Size(175, 64);
            this.FileWriteButton2.TabIndex = 5;
            this.FileWriteButton2.Text = "Write to the file";
            this.FileWriteButton2.UseVisualStyleBackColor = true;
            this.FileWriteButton2.Click += new System.EventHandler(this.FileWriteButton2_Click);
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(855, 124);
            this.EncryptedText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(697, 452);
            this.EncryptedText.TabIndex = 6;
            this.EncryptedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1195, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type text you want to decrypt or ";
            // 
            // FileReadButton2
            // 
            this.FileReadButton2.Location = new System.Drawing.Point(1404, 75);
            this.FileReadButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileReadButton2.Name = "FileReadButton2";
            this.FileReadButton2.Size = new System.Drawing.Size(149, 42);
            this.FileReadButton2.TabIndex = 8;
            this.FileReadButton2.Text = "Read from the file";
            this.FileReadButton2.UseVisualStyleBackColor = true;
            this.FileReadButton2.Click += new System.EventHandler(this.FileReadButton2_Click);
            // 
            // FileWriteButton1
            // 
            this.FileWriteButton1.Location = new System.Drawing.Point(507, 585);
            this.FileWriteButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileWriteButton1.Name = "FileWriteButton1";
            this.FileWriteButton1.Size = new System.Drawing.Size(175, 64);
            this.FileWriteButton1.TabIndex = 9;
            this.FileWriteButton1.Text = "Write to the file";
            this.FileWriteButton1.UseVisualStyleBackColor = true;
            this.FileWriteButton1.Click += new System.EventHandler(this.FileWriteButton1_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(855, 585);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(125, 64);
            this.DecryptButton.TabIndex = 10;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyrillicToolStripMenuItem,
            this.latinToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.selectToolStripMenuItem.Text = "Select alphabet ";
            // 
            // cyrillicToolStripMenuItem
            // 
            this.cyrillicToolStripMenuItem.Name = "cyrillicToolStripMenuItem";
            this.cyrillicToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.cyrillicToolStripMenuItem.Text = "Cyrillic";
            this.cyrillicToolStripMenuItem.Click += new System.EventHandler(this.cyrillicToolStripMenuItem_Click);
            // 
            // latinToolStripMenuItem
            // 
            this.latinToolStripMenuItem.Name = "latinToolStripMenuItem";
            this.latinToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.latinToolStripMenuItem.Text = "Latin";
            this.latinToolStripMenuItem.Click += new System.EventHandler(this.latinToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter a secret key";
            // 
            // SecretKeyButton
            // 
            this.SecretKeyButton.Location = new System.Drawing.Point(791, 59);
            this.SecretKeyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecretKeyButton.Name = "SecretKeyButton";
            this.SecretKeyButton.Size = new System.Drawing.Size(68, 26);
            this.SecretKeyButton.TabIndex = 14;
            this.SecretKeyButton.Text = "OK";
            this.SecretKeyButton.UseVisualStyleBackColor = true;
            this.SecretKeyButton.Click += new System.EventHandler(this.SecretKeyButton_Click);
            // 
            // SecretKeyCancelButton
            // 
            this.SecretKeyCancelButton.Location = new System.Drawing.Point(867, 57);
            this.SecretKeyCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecretKeyCancelButton.Name = "SecretKeyCancelButton";
            this.SecretKeyCancelButton.Size = new System.Drawing.Size(68, 28);
            this.SecretKeyCancelButton.TabIndex = 15;
            this.SecretKeyCancelButton.Text = "Cancel";
            this.SecretKeyCancelButton.UseVisualStyleBackColor = true;
            this.SecretKeyCancelButton.Click += new System.EventHandler(this.SecretKeyCancelButton_Click);
            // 
            // secretKeyTextBox
            // 
            this.secretKeyTextBox.Location = new System.Drawing.Point(790, 30);
            this.secretKeyTextBox.Name = "secretKeyTextBox";
            this.secretKeyTextBox.Size = new System.Drawing.Size(80, 22);
            this.secretKeyTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 692);
            this.Controls.Add(this.secretKeyTextBox);
            this.Controls.Add(this.SecretKeyCancelButton);
            this.Controls.Add(this.SecretKeyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.FileWriteButton1);
            this.Controls.Add(this.FileReadButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncryptedText);
            this.Controls.Add(this.FileWriteButton2);
            this.Controls.Add(this.FileReadButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Task3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FileReadButton1;
        private System.Windows.Forms.Button FileWriteButton2;
        private System.Windows.Forms.RichTextBox EncryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FileReadButton2;
        private System.Windows.Forms.Button FileWriteButton1;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latinToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SecretKeyButton;
        private System.Windows.Forms.Button SecretKeyCancelButton;
        private System.Windows.Forms.TextBox secretKeyTextBox;
    }
}


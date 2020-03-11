using System;

namespace Task2
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
            this.FileWriteButton1 = new System.Windows.Forms.Button();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrillicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChangeLetterButton = new System.Windows.Forms.Button();
            this.originalLetterTextBox = new System.Windows.Forms.TextBox();
            this.targetLetterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StaticLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaticFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(16, 585);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(125, 64);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Decrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(16, 124);
            this.InputText.Margin = new System.Windows.Forms.Padding(4);
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
            this.label1.Text = "Type text you want to decrypt or ";
            // 
            // FileReadButton1
            // 
            this.FileReadButton1.Location = new System.Drawing.Point(528, 75);
            this.FileReadButton1.Margin = new System.Windows.Forms.Padding(4);
            this.FileReadButton1.Name = "FileReadButton1";
            this.FileReadButton1.Size = new System.Drawing.Size(149, 42);
            this.FileReadButton1.TabIndex = 4;
            this.FileReadButton1.Text = "Read from the file";
            this.FileReadButton1.UseVisualStyleBackColor = true;
            this.FileReadButton1.Click += new System.EventHandler(this.FileReadButton1_Click);
            // 
            // FileWriteButton2
            // 
            this.FileWriteButton2.Location = new System.Drawing.Point(1256, 585);
            this.FileWriteButton2.Margin = new System.Windows.Forms.Padding(4);
            this.FileWriteButton2.Name = "FileWriteButton2";
            this.FileWriteButton2.Size = new System.Drawing.Size(175, 64);
            this.FileWriteButton2.TabIndex = 5;
            this.FileWriteButton2.Text = "Write to the file";
            this.FileWriteButton2.UseVisualStyleBackColor = true;
            this.FileWriteButton2.Click += new System.EventHandler(this.FileWriteButton2_Click);
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(734, 124);
            this.EncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(697, 452);
            this.EncryptedText.TabIndex = 6;
            this.EncryptedText.Text = "";
            // 
            // FileWriteButton1
            // 
            this.FileWriteButton1.Location = new System.Drawing.Point(505, 585);
            this.FileWriteButton1.Margin = new System.Windows.Forms.Padding(4);
            this.FileWriteButton1.Name = "FileWriteButton1";
            this.FileWriteButton1.Size = new System.Drawing.Size(175, 64);
            this.FileWriteButton1.TabIndex = 9;
            this.FileWriteButton1.Text = "Write to the file";
            this.FileWriteButton1.UseVisualStyleBackColor = true;
            this.FileWriteButton1.Click += new System.EventHandler(this.FileWriteButton1_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChangeLetterButton
            // 
            this.ChangeLetterButton.Location = new System.Drawing.Point(1132, 615);
            this.ChangeLetterButton.Name = "ChangeLetterButton";
            this.ChangeLetterButton.Size = new System.Drawing.Size(55, 34);
            this.ChangeLetterButton.TabIndex = 12;
            this.ChangeLetterButton.Text = "OK";
            this.ChangeLetterButton.UseVisualStyleBackColor = true;
            this.ChangeLetterButton.Click += new System.EventHandler(this.ChangeLetterButton_Click);
            // 
            // originalLetterTextBox
            // 
            this.originalLetterTextBox.Location = new System.Drawing.Point(982, 606);
            this.originalLetterTextBox.Name = "originalLetterTextBox";
            this.originalLetterTextBox.Size = new System.Drawing.Size(49, 22);
            this.originalLetterTextBox.TabIndex = 13;
            // 
            // targetLetterTextBox
            // 
            this.targetLetterTextBox.Location = new System.Drawing.Point(1071, 606);
            this.targetLetterTextBox.Name = "targetLetterTextBox";
            this.targetLetterTextBox.Size = new System.Drawing.Size(46, 22);
            this.targetLetterTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1037, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Decrypted text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "CHANGE LETTER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaticLetter,
            this.StaticFrequency,
            this.Letter,
            this.Frequency});
            this.dataGridView1.Location = new System.Drawing.Point(1463, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 525);
            this.dataGridView1.TabIndex = 18;
            // 
            // StaticLetter
            // 
            this.StaticLetter.HeaderText = "Static Letter";
            this.StaticLetter.MinimumWidth = 6;
            this.StaticLetter.Name = "StaticLetter";
            this.StaticLetter.Width = 125;
            // 
            // StaticFrequency
            // 
            this.StaticFrequency.HeaderText = "Static Frequency";
            this.StaticFrequency.MinimumWidth = 6;
            this.StaticFrequency.Name = "StaticFrequency";
            this.StaticFrequency.Width = 125;
            // 
            // Letter
            // 
            this.Letter.HeaderText = "Letter";
            this.Letter.MinimumWidth = 6;
            this.Letter.Name = "Letter";
            this.Letter.Width = 125;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetLetterTextBox);
            this.Controls.Add(this.originalLetterTextBox);
            this.Controls.Add(this.ChangeLetterButton);
            this.Controls.Add(this.FileWriteButton1);
            this.Controls.Add(this.EncryptedText);
            this.Controls.Add(this.FileWriteButton2);
            this.Controls.Add(this.FileReadButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Task2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button FileWriteButton1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latinToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ChangeLetterButton;
        private System.Windows.Forms.TextBox originalLetterTextBox;
        private System.Windows.Forms.TextBox targetLetterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaticLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaticFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
    }
}


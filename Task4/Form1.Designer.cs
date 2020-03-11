namespace Task4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 475);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(94, 52);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 101);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(499, 368);
            this.InputText.TabIndex = 2;
            this.InputText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type text you want to encrypt or ";
            // 
            // FileReadButton1
            // 
            this.FileReadButton1.Location = new System.Drawing.Point(396, 61);
            this.FileReadButton1.Name = "FileReadButton1";
            this.FileReadButton1.Size = new System.Drawing.Size(112, 34);
            this.FileReadButton1.TabIndex = 4;
            this.FileReadButton1.Text = "Read from the file";
            this.FileReadButton1.UseVisualStyleBackColor = true;
            this.FileReadButton1.Click += new System.EventHandler(this.FileReadButton1_Click);
            // 
            // FileWriteButton2
            // 
            this.FileWriteButton2.Location = new System.Drawing.Point(937, 475);
            this.FileWriteButton2.Name = "FileWriteButton2";
            this.FileWriteButton2.Size = new System.Drawing.Size(131, 52);
            this.FileWriteButton2.TabIndex = 5;
            this.FileWriteButton2.Text = "Write to the file";
            this.FileWriteButton2.UseVisualStyleBackColor = true;
            this.FileWriteButton2.Click += new System.EventHandler(this.FileWriteButton2_Click);
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(544, 101);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(524, 368);
            this.EncryptedText.TabIndex = 6;
            this.EncryptedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type text you want to decrypt or ";
            // 
            // FileReadButton2
            // 
            this.FileReadButton2.Location = new System.Drawing.Point(956, 61);
            this.FileReadButton2.Name = "FileReadButton2";
            this.FileReadButton2.Size = new System.Drawing.Size(112, 34);
            this.FileReadButton2.TabIndex = 8;
            this.FileReadButton2.Text = "Read from the file";
            this.FileReadButton2.UseVisualStyleBackColor = true;
            this.FileReadButton2.Click += new System.EventHandler(this.FileReadButton2_Click);
            // 
            // FileWriteButton1
            // 
            this.FileWriteButton1.Location = new System.Drawing.Point(380, 475);
            this.FileWriteButton1.Name = "FileWriteButton1";
            this.FileWriteButton1.Size = new System.Drawing.Size(131, 52);
            this.FileWriteButton1.TabIndex = 9;
            this.FileWriteButton1.Text = "Write to the file";
            this.FileWriteButton1.UseVisualStyleBackColor = true;
            this.FileWriteButton1.Click += new System.EventHandler(this.FileWriteButton1_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(544, 475);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(94, 52);
            this.DecryptButton.TabIndex = 10;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1610, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyrillicToolStripMenuItem,
            this.latinToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.selectToolStripMenuItem.Text = "Select alphabet ";
            // 
            // cyrillicToolStripMenuItem
            // 
            this.cyrillicToolStripMenuItem.Name = "cyrillicToolStripMenuItem";
            this.cyrillicToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cyrillicToolStripMenuItem.Text = "Cyrillic";
            this.cyrillicToolStripMenuItem.Click += new System.EventHandler(this.cyrillicToolStripMenuItem_Click);
            // 
            // latinToolStripMenuItem
            // 
            this.latinToolStripMenuItem.Name = "latinToolStripMenuItem";
            this.latinToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.latinToolStripMenuItem.Text = "Latin";
            this.latinToolStripMenuItem.Click += new System.EventHandler(this.latinToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Code});
            this.dataGridView1.Location = new System.Drawing.Point(1117, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 426);
            this.dataGridView1.TabIndex = 12;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 562);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Form1";
            this.Text = "Task4";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FileReadButton2;
        private System.Windows.Forms.Button FileWriteButton1;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrillicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latinToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}


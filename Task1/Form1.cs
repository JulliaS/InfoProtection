using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Language _language = Language.English;
        private int secretKey = 0;

        private readonly ICrypter _crypter;

        public Form1()
        {
            InitializeComponent();
            _crypter = new Crypter(new CaesarCoder());

        }

        private void FileReadButton1_Click(object sender, EventArgs e)
        {
            ReadFromFileViaDialogWindow(InputText);
        }

        private void FileReadButton2_Click(object sender, EventArgs e)
        {
            ReadFromFileViaDialogWindow(EncryptedText);
        }

        private void FileWriteButton1_Click(object sender, EventArgs e)
        {
            SaveFileViaDialogWindow(InputText);
        }

        private void FileWriteButton2_Click(object sender, EventArgs e)
        {
            SaveFileViaDialogWindow(EncryptedText);
        }

        private void ReadFromFileViaDialogWindow(RichTextBox textBox)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = FileOperations.ReadFromFile(fileDialog.FileName);
            }
        }

        private void SaveFileViaDialogWindow(RichTextBox textBox)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "|*.txt";
            fileDialog.FileName = "result";
            fileDialog.Title = "Save a Text File";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                FileOperations.WriteToFile(textBox.Text, fileDialog.FileName);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptedText.Text = _crypter.Encrypt(InputText.Text, secretKey, _language);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            InputText.Text = _crypter.Decrypt(EncryptedText.Text, secretKey, _language);
        }

        private void cyrillicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectToolStripMenuItem.Text = cyrillicToolStripMenuItem.Text;
            _language = Language.Ukrainian;
        }

        private void latinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectToolStripMenuItem.Text = latinToolStripMenuItem.Text;
            _language = Language.English;
        }

        private void SecretKeyButton_Click(object sender, EventArgs e)
        {
            SecretKeyButton.Enabled = false;
            secretKey = (int)numericUpDown1.Value;
        }

        private void SecretKeyCancelButton_Click(object sender, EventArgs e)
        {
            SecretKeyButton.Enabled = true;
            numericUpDown1.Value = 0;
            secretKey = 0;
        }
    }
}

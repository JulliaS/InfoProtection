using System;
using System.Windows.Forms;
using Common;

namespace Task3
{
    public partial class Form1 : Form
    {
        private Language _language = Language.English;
        private string secretKey = "";

        private readonly ICrypter _crypter;

        public Form1()
        {
            InitializeComponent();
            _crypter = new Crypter(new VigenerCoder());

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
            EncryptedText.Text = _crypter.Encrypt(
                InputText.Text,
                new ComplexKey 
                {
                    Key = secretKey, 
                    Encrypting = true
                },
                _language
                );
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            InputText.Text = _crypter.Decrypt(
                EncryptedText.Text,
                new ComplexKey
                {
                    Key = secretKey,
                    Encrypting = false
                },
                _language
                );
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
            secretKey = secretKeyTextBox.Text;
            if (string.IsNullOrEmpty(secretKey))
            {
                MessageBox.Show("Wrong secret key!");
            }
            else
            {
                SecretKeyButton.Enabled = false;
            }
        }

        private void SecretKeyCancelButton_Click(object sender, EventArgs e)
        {
            SecretKeyButton.Enabled = true;
            secretKeyTextBox.Text = "";
            secretKey = "";
        }
    }
}

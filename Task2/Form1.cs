using System;
using System.Linq;
using System.Windows.Forms;
using Common;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Language _language = Language.English;

        private readonly ICrypter _crypter;

        public Form1()
        {
            InitializeComponent();
            _crypter = new Crypter(new Coder(dataGridView1));
            

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
            EncryptedText.Text = _crypter.Encrypt(InputText.Text, null, _language);
        }

        private void ChangeLetterButton_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptedText.Text = _crypter.Decrypt(EncryptedText.Text,
                    new ComplexKey
                    {
                        OriginalLetter = Convert.ToChar(originalLetterTextBox.Text),
                        TargetLetter = Convert.ToChar(targetLetterTextBox.Text)
                        
                    },
                    _language);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        
    }
}

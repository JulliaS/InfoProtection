using Common;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private readonly HuffmanTree _huffmanCoder;

        public Form1()
        {
            InitializeComponent();

            try
            {
                _huffmanCoder = new HuffmanTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = "|*.txt", FileName = "result", Title = "Save a Text File"
            };
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                FileOperations.WriteToFile(textBox.Text, fileDialog.FileName);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            _huffmanCoder.Build(InputText.Text);
             var bitArray = _huffmanCoder.Encode(InputText.Text);
             foreach (bool bit in bitArray)
             {
                 EncryptedText.Text += bit ? 1 : 0;
             }

             FillGridView();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            var bitArray = new BitArray(EncryptedText.Text.Select(c => c == '1').ToArray()); ;
            InputText.Text = _huffmanCoder.Decode(bitArray);
        }

        private void cyrillicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectToolStripMenuItem.Text = cyrillicToolStripMenuItem.Text;
        }

        private void latinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectToolStripMenuItem.Text = latinToolStripMenuItem.Text;
        }

        private void FillGridView()
        {
            var symbolsCodes = _huffmanCoder.GetSymbolsCodes();
            dataGridView1.Rows.Add(symbolsCodes.Count);

            int i = 0;

            foreach (var symbolCode in symbolsCodes)
            {
                switch (symbolCode.Key)
                {
                    case ' ':
                        dataGridView1.Rows[i].Cells[0].Value = "SPACE";
                        break;
                    case '\t':
                        dataGridView1.Rows[i].Cells[0].Value = "TAB";
                        break;
                    case '\n':
                        dataGridView1.Rows[i].Cells[0].Value = "ENTER";
                        break;
                    default:
                        dataGridView1.Rows[i].Cells[0].Value = symbolCode.Key;
                        break;
                }
               
                dataGridView1.Rows[i].Cells[1].Value = SymbolsOperations.BoolListToBitString(symbolCode.Value);
                i++;
            }
        }
    }
}

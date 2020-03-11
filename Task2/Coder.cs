using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    public class Coder : ICoder
    {
        private const string ukLetterFrequencyFilePath = @"UkLetterFrequency.txt";
        private const string engLetterFrequencyFilePath = @"EngLetterFrequency.txt";

        public Coder(DataGridView dataGridView)
        {
            DataGridView = dataGridView;
        }
        private DataGridView DataGridView { get; set; }

        public string CodeEncode(string text, object key, Language language)
        {
            var result = new StringBuilder();
            var onlyLetters = new StringBuilder();

            foreach(var letter in text)
            {
                if (char.IsLetter(letter))
                {
                    onlyLetters.Append(letter);
                }
            }

            var frequencyTable = GetLetterFrequencyTable(language);
            frequencyTable = frequencyTable.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            var customFrequencyTable = GetLetterFrequenceTableForText(text, onlyLetters.ToString());
            customFrequencyTable = customFrequencyTable.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            AddValuesToGrid(DataGridView, frequencyTable, customFrequencyTable);

            foreach (var letter in text)
            {
                if (!char.IsLetter(letter))
                {
                    result.Append(letter);
                }
                else
                {
                    onlyLetters.Append(letter);
                    var letterPosition = GetIndex(customFrequencyTable, char.ToLower(letter));
                    var codedLetter = frequencyTable.ElementAt(letterPosition).Key;
                    codedLetter = SymbolsOperations.GetLetterWithProperRegister(letter, codedLetter);

                    result.Append(codedLetter);
                }
            }

            return result.ToString();
        }

        private int GetIndex<T,S>(Dictionary<T, S> dictionary, T key)
        {
            for (int index = 0; index < dictionary.Count; index++)
            {
                if (dictionary.ElementAt(index).Key.Equals(key))
                    return index; // We found the item
            }

            return -1;
        }

        private void AddValuesToGrid(DataGridView dataGridView, Dictionary<char, double> frequentTable, Dictionary<char, double> customFrequentTable)
        {
            var lenght = frequentTable.Count > customFrequentTable.Count ? frequentTable.Count : customFrequentTable.Count;
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(lenght);

            int i = 0;
            foreach (var item in frequentTable)
            {
                dataGridView.Rows[i].Cells[0].Value = item.Key;
                dataGridView.Rows[i].Cells[1].Value = item.Value;
                i++;
            }

            i = 0;
            foreach (var item in customFrequentTable)
            {
                dataGridView.Rows[i].Cells[2].Value = item.Key;
                dataGridView.Rows[i].Cells[3].Value = item.Value;
                i ++;
            }
        }

        private Dictionary<char, double> GetLetterFrequencyTable(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return FileOperations.ReadLetterFrequencyTable(Path.GetFullPath(engLetterFrequencyFilePath));
                case Language.Ukrainian:
                     return FileOperations.ReadLetterFrequencyTable(Path.GetFullPath(ukLetterFrequencyFilePath));
                default:
                    throw new Exception("Sorry, we don't speak your language!");
            }
        }

        private Dictionary<char, double> GetLetterFrequenceTableForText(string text, string onlyLetters)
        {
            var dictionary = new Dictionary<char, double>();
            foreach (var letter in text)
            {
                var unicLetter = letter;
                if (char.IsLetter(letter))
                {
                    unicLetter = char.ToLower(letter);
                    if (dictionary.ContainsKey(unicLetter))
                    {
                        dictionary[unicLetter]++;
                    }
                    else
                    {
                        dictionary.Add(unicLetter, 1);
                    }
                }
            }

            var keys = dictionary.Keys.ToList();

            foreach (var key in keys)
            {
                dictionary[key] = dictionary[key] /onlyLetters.Length * 100;
            }

            var values = dictionary.Values.Sum();

            return dictionary;
        }
    }
}

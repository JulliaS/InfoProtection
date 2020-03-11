using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public class FileOperations
    {
        public static string ReadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("There is no file with a such directory");

            return File.ReadAllText(filePath);
        }

        public static Dictionary<char, double> ReadLetterFrequencyTable(string filePath)
        {
            var dictionary = new Dictionary<char, double>();

            if (!File.Exists(filePath))
                throw new FileNotFoundException("There is no file with a such directory");

            try
            {
                dictionary = File.ReadLines(filePath)
                .Select(line => line.Split(' '))
                .ToDictionary(key => Convert.ToChar(key[0]), value => Convert.ToDouble(value[1]));
            }
            catch (FileLoadException ex)
            {
                throw new FileLoadException(ex.Message);
            }

            return dictionary;
        }

        public static void WriteToFile(string message, string filePath)
        {
            File.WriteAllText(filePath, message);
        }
    }
}

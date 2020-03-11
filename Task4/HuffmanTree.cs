using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class HuffmanTree
    {
        public Node Root { get; set; }
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        private readonly List<Node> _nodes = new List<Node>();

        public BitArray Encode(string source)
        {
            var encodedSource = new List<bool>();

            var symbolsCodes = GetSymbolsCodes();

            foreach (var symbol in source)
            {
                if (symbolsCodes.ContainsKey(symbol))
                {
                    encodedSource.AddRange(symbolsCodes[symbol]);
                }
            }

            return new BitArray(encodedSource.ToArray());
        }

        public string Decode(BitArray bits)
        {
            var current = this.Root;
            var decoded = "";

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }

            return decoded;
        }

        public void Build(string source)
        {
            foreach (var symbol in source)
            {
                if (!Frequencies.ContainsKey(symbol))
                {
                    Frequencies.Add(symbol, 0);
                }

                Frequencies[symbol]++;
            }

            foreach (var symbol in Frequencies)
            {
                _nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }

            while (_nodes.Count > 1)
            {
                var orderedNodes = _nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {

                    var taken = orderedNodes.Take(2).ToList<Node>();


                    var parent = new Node()
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    _nodes.Remove(taken[0]);
                    _nodes.Remove(taken[1]);
                    _nodes.Add(parent);
                }

                this.Root = _nodes.FirstOrDefault();
            }
        }

        private bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

        public Dictionary<char, List<bool>> GetSymbolsCodes()
        {
            var values = Frequencies.Keys.ToList();

            var symbolsCodes = new Dictionary<char, List<bool>>();

            foreach (var value in values)
            {
                var encodedSymbol = this.Root.Traverse(value, new List<bool>());
                symbolsCodes.Add(value, encodedSymbol);
            }

            return symbolsCodes;
        }
    }
}

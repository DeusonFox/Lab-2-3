using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextToVector
{
    public class Vector
    {
        private List<double> Values { get; }
        public Vector(List<double> values)
        {
            Values = values;
        }
        public Vector(List<double> values, double length)
        {
            Values = values.Select((x) => x / length).ToList();
        }
        public double Length => Math.Sqrt(Values.Select((x) => x * x).Sum());
        public static double operator *(Vector left, Vector right)
        {
            return left.Values.Zip(right.Values, (x, y) => x * y).Sum();
        }
        public static double Cos(Vector left, Vector right)
        {
            return (left.Length > 0 && right.Length > 0) ? (left * right) / left.Length / right.Length : 0;
        }
    }
    public class TextFile
    {
        private SortedDictionary<string, int> Dict = new SortedDictionary<string, int>();
        private HashSet<string> Set = new HashSet<string>();
        private double Length; //количество слов
        public TextFile(string fileName)
        {
            Length = 0;
            Add(fileName);
        }
        // добавление текста из файла
        public void Add(string filename)
        {
            StreamReader input = new StreamReader(filename);
            while (!input.EndOfStream)
            {
                string text = input.ReadLine();
                string[] textArr = Regex.Replace(
                new string(text.Where(x => char.IsWhiteSpace(x) || char.IsLetter(x)).Select(char.ToLower).ToArray()), @"\s+", " ").Split();
                Length += textArr.Length;
                foreach (string word in textArr)
                {
                    if (Dict.ContainsKey(word)) Dict[word]++;
                    else Dict[word] = 1;
                    Set.Add(word);
                }
            }
            input.Close();
        }
        // косинус
        public static double Cos(TextFile first, TextFile second)
        {
            List<double> temp1 = new List<double>();
            List<double> temp2 = new List<double>();
            foreach (var word in first.Set.Intersect(second.Set).ToHashSet())
            {
                temp1.Add(first.Dict[word]);
                temp2.Add(second.Dict[word]);
            }
            foreach (var word in first.Set.Except(second.Set).ToHashSet())
            {
                temp1.Add(first.Dict[word]);
                temp2.Add(0);
            }
            foreach (var word in second.Set.Except(first.Set).ToHashSet())
            {
                temp1.Add(0);
                temp2.Add(second.Dict[word]);
            }
            var vector1 = new Vector(temp1, first.Length);
            var vector2 = new Vector(temp2, second.Length);
            return Vector.Cos(vector1, vector2);
        }
        public int Count => Dict.Count;
    }
}

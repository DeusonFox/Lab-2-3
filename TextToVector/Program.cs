using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToVector
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile text_1 = new TextFile("../../TextFile1.txt");
            TextFile text_2 = new TextFile("../../TextFile2.txt");
            Console.WriteLine(TextFile.Cos(text_1, text_2));
        }
    }
}

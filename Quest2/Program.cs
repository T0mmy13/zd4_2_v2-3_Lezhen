using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd4_2_v2_3_Lezhen;

namespace Quest2
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            if (FunctionalClassQuest2.InputIsRight(input))
            {
                char[] output = input.ToCharArray();

                output = FunctionalClassQuest2.PermutationChars(output);

                StreamWriter sw = new StreamWriter("output.txt");
                sw.Write(string.Concat(output));
                sw.Close();
            }
            else
            {
                Console.WriteLine("Неправильный ввод в файле input.txt");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using zd4_2_v2_3_Lezhen;

namespace Quest2
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            string input = FunctionalClassQuest2.InputIsRight("input.txt");
            if (input != null)
            {
                char[] output = input.ToCharArray();

                int count = output.Length / 2;

                for (int i = count, j = 0; i < output.Length; i++, j++)
                {
                    char replacement = output[j];
                    output[j] = output[i];
                    output[i] = replacement;
                }
                for (int i = count - 1, j = output.Length - 1; i > 0; j--, i--)
                {
                    char replacement = output[j];
                    output[j] = output[j - 1];
                    output[j - 1] = replacement;
                }
                File.WriteAllText("output.txt", string.Concat(output));
            }
            else
            {
                Console.WriteLine("Неправильный ввод в файле input.txt");
            }
        }
    }
}

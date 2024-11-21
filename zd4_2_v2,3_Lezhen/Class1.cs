using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4_2_v2_3_Lezhen
{
    static public class FunctionalClassQuest2
    {
        public static bool InputIsRight(string line)
        {
            if (line.Length < 1 || line.Length > 26)
            {
                return false;
            }
            foreach (char c in line)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static char[] PermutationChars(char[] chars)
        {
            int count = chars.Length / 2;
            for (int i = count, j = 0; i < chars.Length; i++, j++)
            {
                char replacement = chars[j];
                chars[j] = chars[i];
                chars[i] = replacement;
            }
            for (int i = count - 1, j = chars.Length - 1; i > 0; j--, i--)
            {
                char replacement = chars[j];
                chars[j] = chars[j - 1];
                chars[j - 1] = replacement;
            }
            return chars;
        }
    }
    static public class FunctionalClassQuest3
    {
        public static int[] ReadCoordinatesFromFile(string file)
        {
            int[] cord = new int[8];
            try
            {
                string[] lines = File.ReadAllLines(file);
                if (lines == null) return null;

                int index = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new char[] { ' ', 't' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string part in parts)
                    {
                        if (index < cord.Length && int.TryParse(part, out int number))
                        {
                            cord[index] = number;
                            index++;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                if (index != 8) return null;
            }
            catch
            {
                Console.WriteLine($"Ошибка при чтении файла");
                return null;
            }
            return cord;
        }

    }
}

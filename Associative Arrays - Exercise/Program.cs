using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < line.Length; i++)
            {

                foreach (var chars in line[i])
                {
                    if (!charCount.ContainsKey(chars))
                    {
                        charCount[chars] = 1;
                    }
                    else
                    {
                        charCount[chars]++;
                    }

                }
            }
                foreach (var item in charCount)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }                            
        }
    }
}

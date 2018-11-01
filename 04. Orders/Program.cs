using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[][]> products = new Dictionary<string, int[][]>();
            
            while (true)
            {
                string[] line = Console.ReadLine()
                .Split();
                if (!products.ContainsKey(line[0]))
                {
                    products.Add(line[0], int.Parse(line[1]));
                }
                products[line[0]]

            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resurse = "";
            int quantity = 0;
            Dictionary<string, int> resurses = new Dictionary<string, int>();

            while (true)
            {
                resurse = Console.ReadLine();               
                if (resurse=="stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                if (!resurses.ContainsKey(resurse))
                {
                    resurses[resurse] = 0;
                }
                resurses[resurse] += quantity;
            }

            foreach (var item in resurses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
           

        }
    }
}

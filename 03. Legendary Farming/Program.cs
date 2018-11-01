using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

//  Shadowmourne – requires 250 Shards;
// Valanyr – requires 250 Fragments;
// Dragonwrath – requires 250 Motes;
            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();
            Dictionary<string, int> keyMaterials =new Dictionary <string, int>();
            keyMaterials.Add("shards",0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split();
                for (int i = 0; i < commands.Length; i+=2)
                {
                    int quantity =int.Parse( commands[i]);
                    string material = commands[i+1].ToLower();

                    if (material=="shards" || material == "fragments" || material == "motes")
                    {


                    }



                }

            }
        }
    }
}

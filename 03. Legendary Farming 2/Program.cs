using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Legendary_Farming_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> junks = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            bool flag = true;
            while (flag)
            {
                string[] commands = Console.ReadLine()
                    .Split();
                for (int i = 0; i < commands.Length; i += 2)
                {
                    int quantity = int.Parse(commands[i]);
                    string material = commands[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {

                        keyMaterials[material] += quantity;
                        if (keyMaterials[material]>=250)
                        {
                            keyMaterials[material] -= 250;
                        
                            switch (material)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");

                                    PrintResult(keyMaterials,junks);
                                    
                                    flag = false;
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    PrintResult(keyMaterials, junks);
                                    flag = false;
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    PrintResult(keyMaterials, junks);
                                    flag = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(material))
                        {
                            junks[material] = 0;
                        }
                        junks[material] += quantity;
                    }



                }

            }
        }

        private static void PrintResult(Dictionary<string, int> keyMaterials,Dictionary<string,int>junks)
        {
            foreach (var item in keyMaterials.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Skills
    {
        public static void SkillMenu()
        {
            Console.Clear();

            List<string> skill = new List<string>();
            using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Skills.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    for (int i = 0; i < values.Length; i++)
                    {
                        skill.Add(values[i]);
                    }
                }
            }
            Console.WriteLine("Skills\n");
            int count = 1;
            for (int i = 0; i < skill.Count; i++)
            {
                Console.WriteLine(count + "." + skill[i]);
                count++;
            }

            Console.WriteLine("\nPress on any key to exit");
            Console.ReadKey();
        }
    }
}

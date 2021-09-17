using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Technological_Skills
    {
        public static void TechnologicalSkill()
        {
            Console.Clear();

            List<string> technologicalskill = new List<string>();
            using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\TechnologicalSkills.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    for (int i = 0; i < values.Length; i++)
                    {
                        technologicalskill.Add(values[i]);
                    }
                }
            }
            Console.WriteLine("Technological Skills\n");
            int count = 1;
            for (int i = 0; i < technologicalskill.Count; i++)
            {
                Console.WriteLine(count + "." + technologicalskill[i]);
                count++;
            }

            Console.WriteLine("\nPress on any key to exit");
            Console.ReadKey();
        }
    }
}

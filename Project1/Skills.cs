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
            bool exit = true;
            do
            {
                Console.Clear();
                Console.WriteLine("0.Go back");

                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Skills.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        int lol = values.Length - 1;

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (i <= (lol / 2))
                            {
                                listA.Add(values[i]);
                            }
                            if (i > (lol / 2))
                            {
                                listB.Add(values[i]);
                            }
                        }
                    }
                }
                for (int i = 0; i < listA.Count; i++)
                {
                    Console.WriteLine(listA[i]);
                }
                for (int i = 0; i < listB.Count; i++)
                {
                    Console.WriteLine(listB[i]);
                }

                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    exit = false;
                }
            } while (exit);
        }
    }
}

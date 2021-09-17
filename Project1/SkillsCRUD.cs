using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class SkillsCRUD
    {
        public static void CRUDSkill()
        {
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

            Console.WriteLine("Add Skill:");

            string input = Console.ReadLine();

            skill.Add(input);
            //before your loop
            var csv = new StringBuilder();

            //in your loop
            for (int i = 0;i < skill.Count; i++)
            {
                var first = skill[i].ToString();
                var newLine = string.Format("{0},{1}{2}", first, "", Environment.NewLine);
                csv.Append(newLine);
            }
            //after your loop
            File.WriteAllText(@"C:\Users\pparv\source\repos\Project1\CSVs\Skills.csv", csv.ToString());

            Console.WriteLine("\nPress on any key to exit");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

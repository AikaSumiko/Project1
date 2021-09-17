using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class SkillAdd
    {
        public static void AddSkill()
        {
            bool exit2 = true;

            do
            {
                List<string> skill = new List<string>();
                using (TextFieldParser parser = new TextFieldParser(@"C:\Users\pparv\source\repos\Project1\CSVs\Skills.csv"))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] values = parser.ReadFields();
                        for (int i = 0; i < values.Length; i++)
                        {
                            skill.Add(values[i]);
                            skill.Remove("");
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

                Console.WriteLine("\nAdd new Skill or Enter 0 Exit");

                string input = Console.ReadLine();

                if (input != "0")
                {
                    skill.Add(input);

                    var csv = new StringBuilder();

                    for (int i = 0; i < skill.Count; i++)
                    {
                        var first = skill[i].ToString();
                        var newLine = string.Format("{0},{1}{2}", first, "", Environment.NewLine);
                        csv.Append(newLine);
                    }

                    File.WriteAllText(@"C:\Users\pparv\source\repos\Project1\CSVs\Skills.csv", csv.ToString());

                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    exit2 = false;
                }
            } while (exit2);
        }
    }
}

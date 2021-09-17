using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class SkillDelete
    {
        public static void DeleteSkill()
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

                Console.WriteLine("\nSelect the Skill to delete or Enter 0 Exit");

                int userinput = 0;

                bool checkinput;
                do
                {
                    try
                    {
                        userinput = int.Parse(Console.ReadLine());

                        if (userinput < (skill.Count+1) && userinput >= 0)
                        {
                            checkinput = true;
                        }
                        else
                        {
                            Console.WriteLine("\nSelect the Skill to delete or Enter 0 Exit");
                            Console.WriteLine("Wrong option, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nSelect the Skill to delete or Enter 0 Exit");
                        Console.WriteLine("Wrong option, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);

                if (userinput != 0)
                {
                    skill.RemoveAt(userinput-1);

                    var csv = new StringBuilder();

                    for (int i = 0; i < skill.Count; i++)
                    {
                        var value = skill[i];
                        var newLine = string.Format("{0},{1}{2}", value, "", Environment.NewLine);
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

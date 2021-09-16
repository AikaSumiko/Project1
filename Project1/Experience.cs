using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Experience
    {
        public static void Job(int value)
        {
            bool exit = true;
            do
            {
                Console.WriteLine("Select\n1.Ceridian\n0.Go back");

                int userinput = int.Parse(Console.ReadLine());

                switch ((OptionJob)userinput)
                {
                    case OptionJob.Ceridian:
                        Console.Clear();
                        List<string> listA = new List<string>();
                        List<string> listB = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Experience.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                listA.Add(values[0]);
                                listB.Add(values[1]);
                            }
                        }
                        for (int i = 0; i < listA.Count; i++)
                        {
                            Console.WriteLine(listA[i]);
                        }
                        break;
                    case OptionJob.Exit:
                        Console.Clear();
                        exit = false;
                        break;
                }
            } while (exit);
            
        }
    }
}
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Experience
    {
        public static void Job()
        {
            bool exit = true;
            do
            {
                Console.WriteLine("Select\n1.Ceridian\n0.Go back\n");
                Console.WriteLine("Enter option:");

                int userinput = 0;

                bool checkinput;
                do
                {
                    try
                    {
                        userinput = int.Parse(Console.ReadLine());

                        if (userinput < 2 && userinput >= 0)
                        {
                            checkinput = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Select\n1.Ceridian\n0.Go back\n");
                            Console.WriteLine("Wrong option, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Select\n1.Ceridian\n0.Go back\n");
                        Console.WriteLine("Wrong option, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);

                switch ((OptionJob)userinput)
                {
                    case OptionJob.Ceridian:
                        Console.Clear();

                        List<string> Content = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Experience.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    Content.Add(values[i]);
                                }
                            }
                        }
                        string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
                        for (int i = 0; i < chars.Length; i++)
                        {
                            if (Content.Contains(chars[i]))
                            {
                                Content.Remove(chars[i]);
                            }
                        }
                        for (int i = 0; i < Content.Count; i++)
                        {
                            Console.WriteLine(Content[i]);
                        }
                        Console.WriteLine("\nPress on any key to exit");
                        Console.ReadKey();
                        Console.Clear();
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
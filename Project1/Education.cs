using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Education
    {
        public static void EducationMeun()
        {
            bool exit = true;
            do
            {
                Console.WriteLine("Select\n1.Software Engineering (Year 1)\n2.Software Engineering (Year 2)\n3.Software Engineering (Year 3)\n0.Go back");
                Console.WriteLine("\nEnter option:");

                int userinput = 0;

                bool checkinput;
                do
                {
                    try
                    {
                        userinput = int.Parse(Console.ReadLine());

                        if (userinput < 4 && userinput >= 0)
                        {
                            checkinput = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Select\n1.Software Engineering (Year 1)\n2.Software Engineering (Year 2)\n3.Software Engineering (Year 3)\n0.Go back");
                            Console.WriteLine("\nWrong option, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Select\n1.Software Engineering (Year 1)\n2.Software Engineering (Year 2)\n3.Software Engineering (Year 3)\n0.Go back");
                        Console.WriteLine("\nWrong option, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);

                switch ((EducationOption)userinput)
                {
                    case EducationOption.Year1:
                        Console.Clear();

                        List<string> year1module = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year1Modules.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year1module.Add(values[i]);
                                }
                            }
                        }
                        Console.WriteLine("Year 1 Modules\n");
                        int count = 1;
                        for (int i = 0; i < year1module.Count; i++)
                        {
                            Console.WriteLine(count + "." + year1module[i]);
                            count++;
                        }
                        Console.WriteLine("\nYear 1 Projects\n");
                        List<string> year1project = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year1Projects.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year1project.Add(values[i]);
                                }
                            }
                        }
                        int count2 = 1;
                        for (int i = 0; i < year1project.Count; i++)
                        {
                            Console.WriteLine(count2 + "." + year1project[i]);
                            count++;
                        }
                        Console.WriteLine("\nPress on any key to exit");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case EducationOption.Year2:
                        Console.Clear();

                        List<string> year2module = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year2Modules.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year2module.Add(values[i]);
                                }
                            }
                        }
                        Console.WriteLine("\nYear 2 Modules\n");
                        int count3 = 1;
                        for (int i = 0; i < year2module.Count; i++)
                        {
                            Console.WriteLine(count3 + "." + year2module[i]);
                            count3++;
                        }
                        Console.WriteLine("\nYear 2 Projects\n");
                        List<string> year2project = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year2Projects.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year2project.Add(values[i]);
                                }
                            }
                        }
                        int count4 = 1;
                        for (int i = 0; i < year2project.Count; i++)
                        {
                            Console.WriteLine(count4 + "." + year2project[i]);
                            count4++;
                        }
                        Console.WriteLine("\nPress on any key to exit");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case EducationOption.Year3:
                        Console.Clear();

                        List<string> year3module = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year3Modules.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year3module.Add(values[i]);
                                }
                            }
                        }
                        Console.WriteLine("\nYear 3 Modules\n");
                        int count5 = 1;
                        for (int i = 0; i < year3module.Count; i++)
                        {
                            Console.WriteLine(count5 + "." + year3module[i]);
                            count5++;
                        }
                        Console.WriteLine("\nYear 3 Projects\n");
                        List<string> year3project = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year3Projects.csv"))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                for (int i = 0; i < values.Length; i++)
                                {
                                    year3project.Add(values[i]);
                                }
                            }
                        }
                        int count6 = 1;
                        for (int i = 0; i < year3project.Count; i++)
                        {
                            Console.WriteLine(count6 + "." + year3project[i]);
                            count6++;
                        }
                        Console.WriteLine("\nPress on any key to exit");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case EducationOption.Exit:
                        Console.Clear();
                        exit = false;
                        break;
                }
            } while (exit);
        }
    }
}

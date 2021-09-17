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
                Console.WriteLine("Select\n1.Software Engineering Year 1\n2.Software Engineering Year 2\n3.Software Engineering Year 3\n0.Go back");

                int userinput = int.Parse(Console.ReadLine());

                switch ((EducationOption)userinput)
                {
                    case EducationOption.Year1:
                        Console.Clear();

                        List<string> listA = new List<string>();
                        List<string> listB = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year1.csv"))
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
                        break;
                    case EducationOption.Year2:
                        Console.Clear();

                        List<string> listC = new List<string>();
                        List<string> listD = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year2.csv"))
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
                                        listC.Add(values[i]);
                                    }
                                    if (i > (lol / 2))
                                    {
                                        listD.Add(values[i]);
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < listC.Count; i++)
                        {
                            Console.WriteLine(listC[i]);
                        }
                        for (int i = 0; i < listD.Count; i++)
                        {
                            Console.WriteLine(listD[i]);
                        }
                        break;
                    case EducationOption.Year3:
                        Console.Clear();

                        List<string> listE = new List<string>();
                        List<string> listF = new List<string>();
                        using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Year3.csv"))
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
                                        listE.Add(values[i]);
                                    }
                                    if (i > (lol / 2))
                                    {
                                        listF.Add(values[i]);
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < listE.Count; i++)
                        {
                            Console.WriteLine(listE[i]);
                        }
                        for (int i = 0; i < listF.Count; i++)
                        {
                            Console.WriteLine(listF[i]);
                        }
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

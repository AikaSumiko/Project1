using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class SkillsCRUD
    {
        public delegate void mode();
        public static void CRUDSkill()
        {
            bool exit = true;

            do
            {
                Console.WriteLine("Select\n1.Add\n2.Update\n3.Delete\n0.Go Back\n");
                Console.WriteLine("Enter option:");

                bool checkinput;

                int userinput = 0;

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
                            Console.WriteLine("Select\n1.Add\n2.Update\n3.Delete\n0.Go back\n");
                            Console.WriteLine("Wrong mode, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Select\n1.Add\n2.Update\n3.Delete\n0.Go back\n");
                        Console.WriteLine("Wrong mode, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);

                mode select;

                switch ((SkillEdit)userinput)
                {
                    case SkillEdit.Add:
                        Console.Clear();
                        select = new mode(SkillAdd.AddSkill);
                        select();
                        break;
                    case SkillEdit.Update:
                        Console.Clear();
                        select = new mode(SkillUpdate.UpdateSkill);
                        select();
                        break;
                    case SkillEdit.Delete:
                        Console.Clear();
                        select = new mode(SkillDelete.DeleteSkill);
                        select();
                        break;
                    case SkillEdit.Exit:
                        Console.Clear();
                        exit = false;
                        break;
                }
            } while (exit);        
        }
    }
}

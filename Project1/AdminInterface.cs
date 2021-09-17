using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class AdminInterface
    {
        public delegate void mode();
        public static void AdminMode()
        {
            bool guestmenu = true;

            do
            {
                mode menuselect;
                Console.WriteLine("Welcome to Admin Mode\n");
                Console.WriteLine("Select\n1.Edit Experience / Job History\n2.Edit Education / Training\n3.Edit Skills\n4.Edit Technological SKills\n5.Edit Contact Details\n0.Go back\n");
                Console.WriteLine("\nEnter option:");

                int userinput = 0;

                bool checkinput;
                do
                {
                    try
                    {
                        userinput = int.Parse(Console.ReadLine());

                        if (userinput < 6 && userinput >= 0)
                        {
                            checkinput = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Select\n1.Edit Experience / Job History\n2.Edit Education / Training\n3.Edit Skills\n4.Edit Technological SKills\n5.Edit Contact Details\n0.Go back\n");
                            Console.WriteLine("Wrong option, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Select\n1.Edit Experience / Job History\n2.Edit Education / Training\n3.Edit Skills\n4.Edit Technological SKills\n5.Edit Contact Details\n0.Go back\n");
                        Console.WriteLine("Wrong option, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);

                switch ((Admin)userinput)
                {
                    case Admin.Experience:
                        Console.Clear();
                        menuselect = new mode(Experience.Job);
                        menuselect();
                        break;
                    case Admin.Education:
                        Console.Clear();
                        menuselect = new mode(Education.EducationMeun);
                        menuselect();
                        break;
                    case Admin.Skills:
                        Console.Clear();
                        menuselect = new mode(SkillsCRUD.CRUDSkill);
                        menuselect();
                        break;
                    case Admin.TechnologicalSkills:
                        menuselect = new mode(Technological_Skills.TechnologicalSkill);
                        menuselect();
                        break;
                    case Admin.ContactDetails:
                        menuselect = new mode(Contact_Details.Contact);
                        menuselect();
                        break;
                    case Admin.Exit:
                        Console.Clear();
                        guestmenu = false;
                        break;
                }
            } while (guestmenu);
        }
    }
}

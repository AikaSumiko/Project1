using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class GuestInterface
    {
        public delegate void mode();
        public static void GuestMode()
        {
            bool guestmenu = true;

            Console.WriteLine("Hardworking Student looking for work. Ready to put my skills and passion to work in support of a company's"
                    + "objective.Technologically savvy, with experience on a variety of office software, and sophisticated computer "
                    + "skills.Developing a good mindset as well as the desire and motivation to learn new programs.");

            do
            {
                mode menuselect;

                Console.WriteLine("Select\n1.Experience / Job History\n2.Education / Training\n3.Skills\n4.Technological SKills\n5.Contact Details\n0.Go back");

                int userinput = int.Parse(Console.ReadLine());

                switch ((GuestOption)userinput)
                {
                    case GuestOption.Experience:
                        Console.Clear();
                        menuselect = new mode(Experience.Job);
                        menuselect();
                        break;
                    case GuestOption.Education:
                        Console.Clear();
                        menuselect = new mode(Education.EducationMeun);
                        menuselect();
                        break;
                    case GuestOption.Skills:
                        Console.Clear();
                        menuselect = new mode(Skills.SkillMenu);
                        menuselect();
                        break;
                    case GuestOption.TechnologicalSkills:
                        menuselect = new mode(Technological_Skills.TechnologicalSkill);
                        menuselect();
                        break;
                    case GuestOption.ContactDetails:
                        menuselect = new mode(Contact_Details.Contact);
                        menuselect();
                        break;
                    case GuestOption.Exit:
                        Console.Clear();
                        guestmenu = false;
                        break;
                }
            } while (guestmenu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class GuestInterface
    {
        public delegate void mode(int userinput);
        public static void GuestMode(int value)
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
                        menuselect(userinput);
                        break;
                    case GuestOption.Education:
                        break;
                    case GuestOption.Skills:
                        break;
                    case GuestOption.TechnologicalSkills:
                        break;
                    case GuestOption.ContactDetails:
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

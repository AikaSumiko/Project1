using System;

namespace Project1
{
    class MainProgram
    {
        public delegate void mode(string userinput);
        static void Main(string[] args)
        {
            bool checkAdminGuest = true;

            do
            {
                Console.WriteLine("Enter 1 for Admin\nEnter 2 for Guest\nEnter 0 to exit");

                int userinput = int.Parse(Console.ReadLine());

                mode modeselected;

                switch ((Modes)userinput)
                {
                    case Modes.GUEST:
                        Console.Clear();
                        modeselected = new mode(GuestInterface.GuestMode);
                        modeselected(userinput.ToString());
                        break;
                    case Modes.ADMIN:
                        break;
                    case Modes.EXIT:
                        checkAdminGuest = false;
                        break;
                }

            } while (checkAdminGuest);
        }
    }
}

using System;

namespace Project1
{
    class MainProgram
    {
        public delegate void mode();
        static void Main(string[] args)
        {
            bool checkAdminGuest = true;

            do
            {
                Console.WriteLine("Select Mode to Enter\n1.Admin mode\n2.Guest mode\n0.Exit");

                int userinput = int.Parse(Console.ReadLine());

                mode modeselected;

                switch ((MainOption)userinput)
                {
                    case MainOption.Admin:
                        Console.Clear();
                        modeselected = new mode(AdminInterface.AdminMode);
                        modeselected();
                        break;
                    case MainOption.Guest:
                        Console.Clear();
                        modeselected = new mode(GuestInterface.GuestMode);
                        modeselected();
                        break;
                    case MainOption.Exit:
                        Console.Clear();
                        checkAdminGuest = false;
                        break;
                }
            } while (checkAdminGuest);
        }
    }
}

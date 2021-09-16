using System;

namespace Project1
{
    class MainProgram
    {
        public delegate void mode(int userinput);
        static void Main(string[] args)
        {
            bool checkAdminGuest = true;

            do
            {
                Console.WriteLine("Press on\n1.Admin\n2.Guest\n0.Exit");

                int userinput = int.Parse(Console.ReadLine());

                mode modeselected;

                switch ((MainOption)userinput)
                {
                    case MainOption.Admin:
                        Console.Clear();
                        modeselected = new mode(AdminInterface.AdminMode);
                        modeselected(userinput);
                        break;
                    case MainOption.Guest:
                        Console.Clear();
                        modeselected = new mode(GuestInterface.GuestMode);
                        modeselected(userinput);
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

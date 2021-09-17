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
                Console.WriteLine("Select a Mode:\n1.Admin mode\n2.Guest mode\n0.Exit\n");
                Console.WriteLine("Enter mode:");

                int userinput = 0;
                
                bool checkinput;
                do
                {
                    try
                    {
                        userinput = int.Parse(Console.ReadLine());

                        if (userinput < 3 && userinput >= 0)
                        {
                            checkinput = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Select a Mode:\n1.Admin mode\n2.Guest mode\n0.Exit\n");
                            Console.WriteLine("Wrong mode, try again:");
                            checkinput = false;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Select a Mode:\n1.Admin mode\n2.Guest mode\n0.Exit\n");
                        Console.WriteLine("Wrong mode, try again:");
                        checkinput = false;
                    }

                } while (!checkinput);
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

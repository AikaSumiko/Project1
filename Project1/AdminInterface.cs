using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class AdminInterface
    {
        public delegate void mode(int userinput);
        public static void AdminMode(int value)
        {
            Console.WriteLine("Hello");
            Console.Clear();
        }
    }
}

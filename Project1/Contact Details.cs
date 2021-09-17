using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Contact_Details
    {
        public static void Contact()
        {
            Console.Clear();

            List<string> contact = new List<string>();
            using (var reader = new StreamReader(@"C:\Users\pparv\source\repos\Project1\CSVs\Contact.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    int lol = values.Length - 1;

                    for (int i = 0; i < values.Length; i++)
                    {
                        contact.Add(values[i]);
                    }
                }
            }
            Console.WriteLine("Contact Details\n");
            for (int i = 0; i < contact.Count; i++)
            {
                Console.WriteLine(contact[i]);
            }

            Console.WriteLine("\nPress on any key to exit");
            Console.ReadKey();
        }
    }
}

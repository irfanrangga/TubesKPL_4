using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SELAMAT DATANG DI APLIKASI MANAJEMEN PERPUSTAKAAN");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Call method to add book
                    break;
                case "2":
                    // Call method to view books
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

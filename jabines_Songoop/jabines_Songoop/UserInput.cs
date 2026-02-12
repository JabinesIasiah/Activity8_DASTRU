using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jabines_Songoop
{
    public class UserInput
    {
       public static int UserChoice()
       {
            Console.WriteLine("1. Add Song");
            Console.WriteLine("2. Remove Song by Title");
            Console.WriteLine("3. Display Songs");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
                return -1; // Indicate invalid choice
   
       }

        public static Songs GetSongDetails()
        {
            Console.Write("Enter Song Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Artist Name: ");
            string artist = Console.ReadLine();
            Console.Write("Enter Album Name: ");
            string album = Console.ReadLine();
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();
            Console.Write("Enter Duration: ");
            string duration = Console.ReadLine();
            return new Extrasong(title, artist, album, genre, duration);
        }
    }
}

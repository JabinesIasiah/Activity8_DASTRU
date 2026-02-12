using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jabines_Songoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            linkedNode Manage = new linkedNode();
            bool running = true;


            while (running) 
            {
                Console.Clear();
                int choice = UserInput.UserChoice();

                Console.Clear();
                switch (choice) 
                {
                    case 1:
                        Songs newSong = UserInput.GetSongDetails();
                        Manage.InsertSong(newSong);
                        break;
                    case 2:
                        Console.Write("Enter the title of the song to remove: ");
                        string titleToRemove = Console.ReadLine();
                        Manage.RemoveTitle(titleToRemove);
                        break;
                    case 3:
                        Manage.ToString();
                        break;
                    case 4:
                        running = false;
                        Console.WriteLine("Program Ended");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;


                }
                
                        
                
            }

        }
    }
}

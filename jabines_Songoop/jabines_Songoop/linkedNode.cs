using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jabines_Songoop
{
    public class linkedNode
    {
        private LinkedList<Songs> songList = new LinkedList<Songs>();

        public void InsertSong(Songs song)
        {
            if (song != null)
            {
                songList.AddLast(song);
                Console.WriteLine("Song Added to the light");
            }
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
        }



        public bool RemoveTitle(string title)
        {
            var node = songList.First;
            while (node != null)
            {
                if (node.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    songList.Remove(node);
                    Console.WriteLine("Song was Removed");
                    return true; // Song found and removed
                }
                node = node.Next;
            }

            Console.WriteLine("Song not Found.");
            return false; // Song not found

        }
   

    }
}


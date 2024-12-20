using Assignment129;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment129
{
    public partial class CDs :DVDs
    {
       public int NumberOfTracks { get; set; }
        public CDs(string title, string creator, int releaseyear, string genre, int duration, int track)
            :base(title, creator, releaseyear, genre, duration)
        {
            NumberOfTracks = track;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Number of Tracks : {NumberOfTracks}");
        }
    }

    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment129
{
    public partial class DVDs : Books
    {
        //Implementing inheritance as common attributes like title,creator,year are present in them.
        public int Duration { get; set; }
        public DVDs(string title, string creator, int releaseyear, string genre, int duration)
            : base(title, creator, releaseyear, genre)
        {
            Duration = duration;
           

        }
        //overrriding Display method from base class - implementing polymorphism
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Duration : {Duration}");
        }
    }
   
}
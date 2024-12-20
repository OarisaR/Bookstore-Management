using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment129
{
    public partial class Books
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public int ReleaseYear {
            get => ReleaseYear;
            set
            {
                if (value > DateTime.Now.Year) 
                {
                    throw new ArgumentException("Invalid year");
                    //Implementing Exception handling.
                }
                ReleaseYear = value;
            }
        }
        public string Genre { get; set; }

        public Books(string title, string creator, int releaseYear, string genre)
        {
            Title = title;
            Creator = creator; //the author
            ReleaseYear = releaseYear;
            Genre = genre;
        }
       public virtual void Display()
        {
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Creator}");
            Console.WriteLine($"Release Year : {ReleaseYear}");
            Console.WriteLine($"Genre : {Genre}");
            
        }
       


    }
}
   
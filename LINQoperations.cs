using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment129
{  //seperate file for linq implementations..done by partial classes
    public partial class Books
    {
        public static IEnumerable<Books> byCreator(IEnumerable<Books> books, string author)
        {
            return books.Where(book => book.Creator == author);
        }
        public static Dictionary<string, int> byGenre(IEnumerable<Books> books)
        {
            return books.GroupBy(book => book.Genre).ToDictionary(Group => Group.Key, Group => Group.Count());
            //displays the genre of the book and counts how many book of same genre are there in the inventory
        }
        public static IEnumerable<string> GetTitles(IEnumerable<Books> books)
        {
            return books.Select(books => books.Title);
        }

    }
    public partial class DVDs
    {
        public static double AverageDuration(IEnumerable<DVDs> dvds)
        {
                return dvds.Average(dvd => dvd.Duration);            
            
        }

    }
    public partial class CDs
    {
        public static int TotalCDTracks(IEnumerable<CDs> cds)
        {
            return cds.Sum(cd => cd.NumberOfTracks);
        }

    }

}

using Assignment129;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        //I have used seperate Inventories in order to handle the media items in an organized way
        Media<Books> bookinventory = new Media<Books>();

        bookinventory.Add(new Books("Harry Potter", "J.K Rowling", 1997, "Fantasy"));
        bookinventory.Add(new Books("To Kill a Mockingbird", "Harper Lee", 1960, "Fiction"));
        bookinventory.Add(new Books("The Great Gatsby", "George Orwell", 1949, "Dystopian"));
        bookinventory.Add(new Books("The Catcher in the Rye", "J.D. Salinger", 1951, "Realistic Fiction"));
        bookinventory.Add(new Books("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Classic"));
        bookinventory.Add(new Books("Pride and Prejudice", "Jane Austen", 1813, "Classic"));
        bookinventory.Add(new Books("Sense and Sensibility", "Jane Austen", 1811, "Fiction"));
       

        Media<DVDs> dvdinventory = new Media<DVDs>();
        dvdinventory.Add(new DVDs("Wonder", "Alice Productions", 2021, "Fantasy", 120));
        dvdinventory.Add(new DVDs("Jurassic Park", "Steven Spielberg", 1993, "Science Fiction", 127));
        dvdinventory.Add(new DVDs("Inception", "Alice Productions", 2010, "Science Fiction", 148));
        dvdinventory.Add(new DVDs("The Matrix", "Lana Wachowski", 1999, "Science Fiction", 136));
        dvdinventory.Add(new DVDs("Wonderland", "Quentin Tarantino", 1994, "Crime", 154));



        Media<CDs> cdinventory = new Media<CDs>();
        cdinventory.Add(new CDs("ASMR Relaxation", "Bliss Productions", 2021, "ASMR", 45, 200));
        cdinventory.Add(new CDs("Soothing Serenade", "Harmony Harmonics", 2022, "Classical", 60, 15));
        cdinventory.Add(new CDs("Mindful Moments", "Serenity Sounds", 2023, "Meditation", 50, 12));
        cdinventory.Add(new CDs("Echoes of Nature", "Harmony Harmonics", 2019, "Nature Sounds", 70, 10));
        cdinventory.Add(new CDs("Melodic Musings", "Tune Harmony", 2005, "Instrumental", 55, 14));
        cdinventory.Add(new CDs("Rhythmic Reverie", "Bliss Productions", 2017, "Drums", 45, 10));
        cdinventory.Add(new CDs("Dreamy Harmonies", "Tune Harmony", 2014, "Ambient", 48, 13));
        cdinventory.Add(new CDs("Harmonic Horizons", "Tune Harmony", 2008, "Orchestral", 65, 16));







        while (true)
        {

            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Add a Media Item");
            Console.WriteLine("2. Remove a Media Item");
            Console.WriteLine("3. Update a Media Item");
            Console.WriteLine("4. Operations");
            Console.WriteLine("5. Display all the items");
            Console.WriteLine("6. Exit");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("What type of media do you want to Add?");
                    Console.WriteLine("a.Book");
                    Console.WriteLine("b.DVD");
                    Console.WriteLine("c.CD");
                    string option = Console.ReadLine();

                    if (option == "a")
                    {
                        Console.Write("Title: ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Author: ");
                        string bookAuthor = Console.ReadLine();
                        Console.Write("Release Year: ");
                        
                        int bookReleaseYear = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Genre: ");
                        string bookGenre = Console.ReadLine();
                        bookinventory.Add(new Books(bookTitle, bookAuthor, bookReleaseYear, bookGenre));

                    }
                    if (option == "b")
                    {
                        Console.Write("Title: ");
                        string dvdTitle = Console.ReadLine();
                        Console.Write("Director: ");
                        string dvdDirector = Console.ReadLine();
                        Console.Write("Release Year: ");
                        int dvdReleaseYear = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Genre: ");
                        string dvdGenre = Console.ReadLine();
                        Console.Write("Duration (minutes): ");
                        int dvdDuration = Convert.ToInt32(Console.ReadLine());


                        dvdinventory.Add(new DVDs(dvdTitle, dvdDirector, dvdReleaseYear, dvdGenre, dvdDuration));
                    }
                    if (option == "c")
                    {
                        Console.Write("Title: ");
                        string cdTitle = Console.ReadLine();
                        Console.Write("Artist: ");
                        string cdArtist = Console.ReadLine();
                        Console.Write("Release Year: ");
                        int cdReleaseYear = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Genre: ");
                        string cdGenre = Console.ReadLine();
                        Console.Write("Number of Tracks: ");
                        int cdNumberOfTracks = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Duration (minutes): ");
                        int cdDuration = Convert.ToInt32(Console.ReadLine());

                        cdinventory.Add(new CDs(cdTitle, cdArtist, cdReleaseYear, cdGenre, cdDuration, cdNumberOfTracks));
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the ID of the item to remove:");
                    int itemIndexToRemove = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the media type (a.Books,b.DVDs,c.CDs):");
                    char mediaType = Convert.ToChar(Console.ReadLine());



                    switch (mediaType)
                    {
                        case 'a':

                            var bookToRemove = bookinventory.Mediaitems[itemIndexToRemove];
                            bookinventory.Remove(bookToRemove);
                            break;

                        case 'b':

                            var dvdToRemove = dvdinventory.Mediaitems[itemIndexToRemove];
                            dvdinventory.Remove(dvdToRemove);


                            break;

                        case 'c':

                            var cdToRemove = cdinventory.Mediaitems[itemIndexToRemove];
                            cdinventory.Remove(cdToRemove);
                            break;

                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Update a Media Item:");
                    Console.WriteLine("a. Update a Book");
                    Console.WriteLine("b. Update a DVD");
                    Console.WriteLine("c. Update a CD");

                    string update = Console.ReadLine();

                    switch (update)
                    {
                        case "a":
                            Console.WriteLine("Enter the title of the book to update:");
                            string existingBookTitle = Console.ReadLine();
                            var existingBook = bookinventory.Mediaitems.Find(book => book.Title == existingBookTitle);

                            if (existingBook != null)
                            {
                                Console.WriteLine("Enter updated information:");
                                Console.Write("New Title: ");
                                string newBookTitle = Console.ReadLine();
                                Console.Write("New Author: ");
                                string newBookAuthor = Console.ReadLine();
                                Console.Write("New Release Year: ");
                                int newBookReleaseYear = Convert.ToInt32(Console.ReadLine());
                                Console.Write("New Genre: ");
                                string newBookGenre = Console.ReadLine();

                                var updatedBook = new Books(newBookTitle, newBookAuthor, newBookReleaseYear, newBookGenre);
                                bookinventory.Update(existingBook, updatedBook);
                                Console.WriteLine("Book updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;

                        case "b":
                            Console.WriteLine("Enter the title of the DVD to update:");
                            string existingdvdTitle = Console.ReadLine();
                            var existingdvd = dvdinventory.Mediaitems.Find(dvd => dvd.Title == existingdvdTitle);

                            if (existingdvd != null)
                            {
                                Console.WriteLine("Enter updated information:");
                                Console.Write("New Title: ");
                                string newdvdTitle = Console.ReadLine();
                                Console.Write("New Author: ");
                                string newdvdAuthor = Console.ReadLine();
                                Console.Write("New Release Year: ");
                                int newdvdReleaseYear = Convert.ToInt32(Console.ReadLine());
                                Console.Write("New Genre: ");
                                string newdvdGenre = Console.ReadLine();
                                Console.WriteLine("New Duration: ");
                                int duration = int.Parse(Console.ReadLine());

                                var updatedDvd = new DVDs(newdvdTitle, newdvdAuthor, newdvdReleaseYear, newdvdGenre, duration);
                                dvdinventory.Update(existingdvd, updatedDvd);
                                Console.WriteLine("DVD updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("DVD not found.");
                            }


                            break;

                        case "c":

                            Console.WriteLine("Enter the title of the CD to update:");
                            string existingcdTitle = Console.ReadLine();
                            var existingcd = cdinventory.Mediaitems.Find(cd => cd.Title == existingcdTitle);

                            if (existingcd != null)
                            {
                                Console.WriteLine("Enter updated information:");
                                Console.Write("New Title: ");
                                string newcdTitle = Console.ReadLine();
                                Console.Write("New Artist: ");
                                string newcdArtist = Console.ReadLine();
                                Console.Write("New Release Year: ");
                                int newcdReleaseYear = Convert.ToInt32(Console.ReadLine());
                                Console.Write("New Genre: ");
                                string newcdGenre = Console.ReadLine();
                                Console.WriteLine("New Duration: ");
                                int duration = int.Parse(Console.ReadLine());
                                Console.WriteLine("New Track: ");
                                int track = int.Parse(Console.ReadLine());

                                var updatedcd = new CDs(newcdTitle, newcdArtist, newcdReleaseYear, newcdGenre, duration, track);
                                cdinventory.Update(existingcd, updatedcd);
                                Console.WriteLine("CD updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("CD not found.");
                            }
                            break;


                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    break;

                case 4:

                    Console.WriteLine("1.Books By Author");
                    Console.WriteLine("2.Books By Genre");
                    Console.WriteLine("3.Books By Titles");
                    Console.WriteLine("4.DVDs By Artists");
                    Console.WriteLine("5.Average Duration of DVDs");
                    Console.WriteLine("6.CDs By Artists"); 
                    Console.WriteLine("7.Total Tracks in CDs");
                   


                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Enter Author name: ");
                            string author = Console.ReadLine();
                            var booksbyauthor = Books.byCreator(bookinventory.Mediaitems, author);
                            Console.WriteLine("Books by Author: ");
                            foreach (var book in booksbyauthor)
                            {
                                book.Display();
                                Console.WriteLine();
                            }

                            break;
                        case 2:
                            var booksGroupedbyGenre = Books.byGenre(bookinventory.Mediaitems);
                            Console.WriteLine("Books by genre: ");
                            foreach (var entry in booksGroupedbyGenre)
                            {
                                Console.WriteLine($"Genre: {entry.Key}, Count: {entry.Value}");
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            var bookstitles = Books.GetTitles(bookinventory.Mediaitems);
                            Console.WriteLine("Books by Titles: ");
                            foreach (var title in bookstitles)
                            {
                                Console.WriteLine(title);
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter Artist/Productions name: ");
                            string artist = Console.ReadLine();
                            var dvdsbyartists = DVDs.byCreator(dvdinventory.Mediaitems, artist);
                            Console.WriteLine("DVDs by Author: ");
                            foreach (var dvd in dvdsbyartists)
                            {
                                dvd.Display();
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                           
                            double averageDuration = DVDs.AverageDuration(dvdinventory.Mediaitems);
                            Console.WriteLine($"Average duration of DVDs: {averageDuration} minutes");

                            break;
                        case 6:
                            Console.WriteLine("Enter Artist/Productions name: ");
                            string artist1 = Console.ReadLine();
                            var cdsbyartists = DVDs.byCreator(cdinventory.Mediaitems, artist1);
                            Console.WriteLine("CDs by Artists: ");
                            foreach (var dvd in cdsbyartists)
                            {
                                dvd.Display();
                                Console.WriteLine();
                            }
                            break;

                        case 7:
                            
                            int TotalTracks = CDs.TotalCDTracks(cdinventory.Mediaitems);
                            Console.WriteLine($"Total number of tracks: {TotalTracks}");
                            break;

                        default: break;


                    }
                    break;
                case 5:
                    Console.WriteLine("a.Display Books");
                    Console.WriteLine("b.Display DVDs");
                    Console.WriteLine("c.Display CDs");
                    string o = Console.ReadLine();
                    switch (o)
                    {
                        case "a":
                            Console.WriteLine("Books: ");
                            Console.WriteLine();
                            foreach (var book in bookinventory.Mediaitems)
                            {
                                book.Display();
                                Console.WriteLine();
                            }
                            break;
                        case "b":
                            Console.WriteLine("DVDs: ");
                            Console.WriteLine();
                            foreach (var dvd in dvdinventory.Mediaitems)
                            {
                                dvd.Display();
                                Console.WriteLine();
                            }
                           
                            break;
                        case "c":
                            Console.WriteLine("CDs: ");
                            Console.WriteLine();
                            foreach (var cd in cdinventory.Mediaitems)
                            {
                                cd.Display();
                                Console.WriteLine();
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;


                    }
                    break;
                case 6:
                    Environment.Exit(0);
                    break;


            }
        }
    }
}


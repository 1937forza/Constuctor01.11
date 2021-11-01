using System;

namespace Constructor01._11
{
    class Program
    {
        static void Main(string[] args)                  // Library'la elaqelendirmede sefler var ...
        {
            Console.WriteLine("Kitablarin sayini daxil edin");
            string str = Console.ReadLine();
            int count = Convert.ToInt32(str);


            Library library = new Library();

            if (count > 0)
            {
                library.Books = new Book[0];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine($"{i + 1}. Kitabin melumatini daxil edin");
                    Console.WriteLine("===========================\n");

                    string name = GetInputName("Name", 1, 50);
                    string genre = GetInputGenre("Genre", 3, 20);
                    int price = GetInputInt("Qiymet :");
                    int no = GetInputInt("No");

                    Book book = new Book(genre, no, name, price);
                    library.AddBook(book);
                }

            }

            
            {
                string answer;
                do
                {
                    Console.WriteLine("Filtirlemek isteyirsinizmi ?  y/n");
                    answer = Console.ReadLine();

                } while (answer != "y" && answer != "n");

                if (answer == "y")
                {
                    string answer1;
                    do
                    {
                        Console.WriteLine("Genre adina gore - 1 , Qiymet intervalina gore - 2 duymesini secin !");
                        answer1 = Console.ReadLine();

                    } while (answer1 != "1" && answer1 != "2");
                    if (answer1 == "1")
                    {
                        foreach (var item in library.Books)
                        {
                            Console.WriteLine("Genre");
                        }
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("Minimum Price daxil edin");
                        string minstr = Console.ReadLine();
                        double min = Convert.ToDouble(minstr);

                        Console.WriteLine("Maximum Price daxil edin");
                        string maxstr = Console.ReadLine();
                        double max = Convert.ToDouble(maxstr);

                        var filtererdBooks = library.GetFiltererdBooks(min, max);

                        Console.WriteLine("Araliq : ");
                        foreach (var item1 in filtererdBooks)
                        {
                            Console.WriteLine("Filtr");
                        }
                    }
                }
                else
                {
                    Library[] book = new Library[count];

                    Console.WriteLine("Kitablarin siyahisi");
                    foreach (var item in book)
                    {
                        Console.WriteLine(item.GetInfo(books);
                    }
                }

            }

            
        }


        static string GetInputName(string inputName , int minLenght=1 , int maxLenght=int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin ");
                input = Console.ReadLine();

            } while (input.Length < minLenght || input.Length>maxLenght);
            return input;


        }

        static string GetInputGenre(string inputName, int minLenght = 3, int maxLenght = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin ");
                input = Console.ReadLine();

            } while (input.Length < minLenght || input.Length > maxLenght);
            return input;


        }

        static int GetInputInt(string InputName , int min=0)
        {
            int input;
            string inputstr;
            do
            {
                Console.WriteLine($"{InputName} deyerini daxil edin");
                inputstr = Console.ReadLine();
                input = Convert.ToInt32(inputstr);

            } while (input ==0 || input <0);
            return input;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor01._11
{
    class Library
    {
        public Book[] Books;


        public void AddBook(Book book)
        {

            var temp = this.Books;
            Book[] newBooks = new Book[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                newBooks[i] = temp[i];
            }
            newBooks[newBooks.Length-1] = book;
            this.Books = newBooks;

           

        }

        public Book [] GetFilteredBooks(string genre)
        {
            int count = 0;

            foreach (var search in Books)
            {
                if (search.Genre == genre) count++;
            }

            Book[] addGenre = new Book[count];
            int index = 0;

            foreach (var srch in Books)
            {
                if(srch.Genre == genre)
                {
                    addGenre[index] = srch;
                    index++;
                }
            }

            return addGenre;

        }

        public Book[] GetFiltererdBooks(double minPrice , double maxPrice)
        {
            int count = 0;

            foreach (var item in Books)
            {
                if (item.Price > minPrice && item.Price < maxPrice) count++;
            }

            Book[] filteredbook = new Book[count];

            int index = 0;

            foreach (var srch in Books)
            {
                if (srch.Price > minPrice && srch.Price < maxPrice)
                {
                    filteredbook[index] = srch;
                    index++;
                }
            }
            return filteredbook;
            




        }

        public Book GetInfo(Book book)
        {
            Console.WriteLine($"Kitabin adi : {book.Name} - kitabin nomresi : {book.No} - kitabin Janri : {book.Genre} - kitabin qiymeti : {book.Price} - Kitabin sayi : {book.Count}");

            return book;
        }



        


    }


}

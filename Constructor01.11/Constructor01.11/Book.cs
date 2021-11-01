using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor01._11
{
    class Book:Product
    {
        public Book(string genre , int no, string name, double price):base(no , name , price)
        {
            Genre = genre;
        }


        public string Genre;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    internal class Book :Product
    {
        public string Genre;

        public Book(double price, string no, string name, string genre):base(price, no, name)
        {
            Genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Price}, {No}, {Name}, {Genre}");
        }
    }
}

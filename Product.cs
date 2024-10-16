using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    internal class Product
    {

        private double _price;  
        public double Price 
        { 
            get 
            { 
                return _price; 
            } 
            set 
            { 
                if(value > 0) 
                {
                    _price = value;
                }
            } 
        }

        private double _count;
        public double Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value < 0)
                {
                    _count = value;
                }
            }
        }

        public string No;
        public string Name;

        public Product(double price, string no, string name)
        {
            Price = price;         
            No = no;
            Name = name;
        }
    }
}

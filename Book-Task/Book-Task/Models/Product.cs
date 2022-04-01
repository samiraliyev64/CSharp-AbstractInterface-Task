using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Task.Models
{
    class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

        public Product(int No, string Name, int Price)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
        }

        public Product()
        {

        }
    }
}

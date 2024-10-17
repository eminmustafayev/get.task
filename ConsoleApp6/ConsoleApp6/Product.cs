using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Product
    {
        protected int Price;
        protected int Count;

        public int price { 
            get
            {
                return Price;
            }
            set {  
            if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Qiymet menfi ola bilmez");
                }
                }
        
        }
        public int count
        {
            get
            {
                return Count;
            }
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
                else
                {
                    Console.WriteLine("Sira menfi ola bilmez");
                }
            }

        }
        public int No;
        public string Name;
        

        public    Product(int no, string name , int count , int price)
        {
            No = no;
             Name = name;
            Price = price;
            Count = count;
        }
    }
}

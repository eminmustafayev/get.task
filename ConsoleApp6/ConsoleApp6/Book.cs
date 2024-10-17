using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book :Product
    {
        public string Genre;

        public  Book(int no , string name , int count , int price , string genre) : base(no , name ,count ,price)
        { 
        Genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine("no : " + No + "name : " + Name + "count : " + count + "pice : " + price + "genre : " + Genre);
        }


       
    }
}

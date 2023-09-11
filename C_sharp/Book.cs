using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCamp
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public int count;
        private string rating;
        //private variable only can be excuted in class code
        

        public Book(string name)
        {
            //Contructor
            //like python class's __init__()
            author = name;
            Console.WriteLine("It is " + name + "created");
            Console.WriteLine("creating a book");
            sayhi();
        }
        public void sayhi()
        {
            Console.WriteLine("hi");
        }
        //setter and getter in C sharp
        public string Rating
        {
            get
            {
                return rating;
            }
            set {
                if (value == "G" || value == "PG")
                {
                     
                }
            }
        }
    }
}

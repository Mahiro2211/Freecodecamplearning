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
        //public int count;
        private string rating;
        //private variable only can be excuted in class code
        public static int count = 0; // belong to the class not to a class variable
       
        public Book(string name)
        {
            //Contructor
            //like python class's __init__()
            author = name;
            Console.WriteLine("It is " + name + "created");
            Console.WriteLine("creating a book");
            sayhi();
            count++;
        }
        public void sayhi()
        {
            Console.WriteLine("hi");
        }
        public static void test_simple()
        {
            Console.WriteLine("this is a test of static attribute");
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
                     rating = value;
                }
                else
                {
                    Console.WriteLine("illegal value!");
                }
            }
        }
    }
}

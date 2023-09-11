// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace FreeCodeCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello_world");
            Console.ReadLine(); // like getchar() in C 
            
            //Variable in C sharp
            string a = "Hello";
            int b = 2;
            float c = 0.3F;
            long d = 1912929L;
            double e = 0.1231213124D;
            char f = 'c';
            bool g = true;
            bool h = false;

            Console.WriteLine(a,b,c,d,d,f);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            
            //C sharp String method
            Console.WriteLine("Dou\nHuan \bMin");
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.Contains('l'));
            Console.WriteLine(a[0]); // string in c sharp can be index
            Console.WriteLine(a.IndexOf('l'));  // return index if it is not exist return minus one
            Console.WriteLine(a.Substring(2)); // grap the string from (start_index,number)
            //processing number
            Console.WriteLine(Math.Max(450, 1)); // more like C programming
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));//must > x.5 -> x + 1
            //C sharp input
            //Console.Write("Enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //C sharp array
            //int[] number = { 1, 2, 3, 4, };
            //Console.WriteLine(number);
            //for(int i = 0 ; i < number.Length; i++)
            ////{
            //    Console.Write(number[i] + " ");
            //}
            //method in c sharp
            //method is like a container Main method is special
            //sayHi();
            //two dimensional array
            int[,] numbers = { { 1, 2, 3, 4, }, { 2, 3, 4, 5, } };
            for ( int i = 0 ; i < numbers.GetLength(0); i++)
            {
                for(int j = 0 ; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i,j] + " ");
                }
            } 
            
           
            // Exception Handling
            try
            {
                //type transformation
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(Exception ab) // Exception can be more specified
            {
                Console.WriteLine(ab.Message);
            } // there are also can be some catch blocks after
            finally { Console.ReadLine(); }//whatever it is ,it is always excuted

            Book book = new Book("Mike");//class is a data type
            book.title = "RealWorld";
            Console.WriteLine(book.title);
            //C sharp class Construtor
            book.Rating = "sdsk";
            Console.WriteLine(book.Rating);
            Book.test_simple();
            
            //static arrtribute in c sharp
            

        }
        static void sayHi()
        {
            Console.WriteLine("hello");
        }


    }
}
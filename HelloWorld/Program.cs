using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Profile();
            Day();
            Finish();
            Console.ReadLine();
        }

        public static void Hello()
        {
            Console.WriteLine("Hello World");
        }

        public static void Profile()
        {
            Console.WriteLine("I am Ngo Hong Phuc");
        }

        public static void Day()
        {
            Console.WriteLine("Today is " + DateTime.Now.ToShortDateString());
        }

        public static void Finish()
        {
            Console.WriteLine("END");
        }
    }
}

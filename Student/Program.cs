
//using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_in
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //Student1 s1 = new Student1("pratik", 123, 27, Stream.Mech);
            //Console.WriteLine(s1.ToString());
            string[] name = new string[5] { "Elon", "Jeff", "Rasika", "Janki", "Susim" };
            string[] mobile = new string[6] { "Apple", "Samsung", "Redmi", "Oppo", "OnePlus" ,""};

            foreach(string s in name)
            {
                Console.WriteLine(s);
            }

            Array.Sort(mobile);
            Console.WriteLine("------after sort------");
            foreach (var s in mobile) 
            {
                Console.WriteLine(s);
            }

            Array.Reverse(mobile);
            Console.WriteLine("------after reverse------");
            foreach(var s in mobile)
            {
                Console.WriteLine(s);
            }

            Array.Copy(name,2,mobile,2,1);
            Console.WriteLine("------------------");
            foreach (var item in mobile)
            {
                Console.WriteLine(item);
            }

        }
    }
}
      
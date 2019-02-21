using _21._02._19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._19
{
    class Program
    {

        static void Main(string[] args)
        {
           

            Class1 obj1 = new Class1(x: 10, y: 12);
            Console.WriteLine("obj1: ");
            obj1.rewrite();
            Console.WriteLine("{0}+{1}={2}", obj1.x,obj1.y, obj1.Sum());
            test(obj1);

        }

        public static void test(ITest ts)
        {


        }
    }
}

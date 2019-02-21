using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._19.Model
{
    public class Class1 : ITest
    {

        public int x { get; set; }

        public int y { get; set; }

        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Del()
        {
            return x / y;
        }

        public int Otr()
        {
            return x - y;
        }

        public int Prz()
        {
            return x * y;
        }

        public virtual int Sum()
        {
            return x + y;
        }

        public virtual void rewrite()
        {
            Console.WriteLine("{0} / {1}", x, y);
        }
    }
}

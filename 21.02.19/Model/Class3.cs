using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._19.Model
{
    public class Class3:Class1, ITest
    {
        public int Sqr(int x)
        {
            return x * x;
        }
        public int Sqrt(int x)
        {
            return (int)Math.Sqrt((double)x);
        }




    }
}

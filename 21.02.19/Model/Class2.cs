using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._19.Model
{
    public class Class2:Class1
    {
        public Class2(int z, int x, int y): base(x,y)
        {
            this.z = z;
        }

        public int z { get; set; }

        public override int Sum()
        {
            return base.x + base.y + this.z;
        }

        public override void rewrite()
        {
            base.rewrite();
            Console.WriteLine("{0}",z);
        }
    }
}

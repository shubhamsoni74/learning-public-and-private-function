using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPublicPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            SONI soni = new SONI();
            soni.Value_of_a();
            Soni so = new Soni();
            so.Value_of_b();
            so.b = 8;
            so.Value_of_b();
            Console.ReadKey();

        }
    }
    class SONI
    {
        private int a = 9;
        public void Value_of_a()
        {
         
            Console.WriteLine("Value of a is {0}",a);
        }
    }
    class Soni
    {
        public int b = 5;
        public void Value_of_b()
        {
            Console.WriteLine("value of b is {0}", b);
        }
    }

}

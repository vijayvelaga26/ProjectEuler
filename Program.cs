using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
       public static int count;
        static void Main(string[] args)
        {
            for(int x=1; x < 10; x++)
            {
                if(x%3==0 || x % 5 == 0)
                {
                    count += x;
                }

            }
            Console.WriteLine(count);
            Console.Read();
        }
    }
}

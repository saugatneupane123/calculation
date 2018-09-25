using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirthmeticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            int sum = add(a, b);
            Console.WriteLine("sum:{0}",sum);
        }

        static int add(int a,int b)
        {
          return(a+b);  
        }

   
    }
}

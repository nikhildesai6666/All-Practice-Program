using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Print_valueAraisToB
    {
        static void Main(string[] args)
        {
            int result = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                result = a * result;
            }
            Console.WriteLine(result);
            //result = a * b;
            //Console.WriteLine(result);
        }
        
    }
}

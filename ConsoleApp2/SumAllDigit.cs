using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SumAllDigit
    {
        static void Main(string[]args)
        {
            int num,rem, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}

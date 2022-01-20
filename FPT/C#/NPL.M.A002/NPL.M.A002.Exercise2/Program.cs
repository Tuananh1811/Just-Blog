using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A002.Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, m, j, result = 1;
            Console.WriteLine("nhap n; ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap m; ");
            m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                j = n;
            }
            else
            {
                j = m;
            }
            for (int i = 1; i <= j; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    result = i;

                }
            }
            Console.WriteLine("UCLN {0} và {1} = {2}", n, m, result);
            Console.ReadKey();
        }
    }
}

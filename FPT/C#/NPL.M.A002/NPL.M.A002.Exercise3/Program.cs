using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A002.Exercise3
{
    class Program
    {
        //nhap mang
        static void Nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        //xuat mang
        static void Xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
        //tìm ucln 
        static int UCLNInAraay(int []a,int n)
        {
            int min = a[0];
            int result = 1;
            //tìm giá trị bé nhất trong mảng
            for(int i = 0; i < n; i++)
            {
                if (min >= a[i])
                {
                    min = a[i];
                }
            }
            //duyệt vòng lặp 
            for(int i = 1; i <= min; i++)
            {
                if (min % i == 0 )
                {
                    result = i;

                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so phan tu mang: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhap(a, n);
            Console.WriteLine("Mang da nhap: ");
            Xuat(a, n);
           Console.WriteLine( "UCLN trong mang= {0}",UCLNInAraay(a, n));
            Console.ReadKey();
        }
    }
}

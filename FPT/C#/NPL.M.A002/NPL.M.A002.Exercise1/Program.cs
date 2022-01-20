using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Exercise 1: Find max and min elements in an array
Write code to find maximum and minimum of the inputted array.
Example: [5, 8, 12, -10, 6, 4]
Maximum is: 12
Minimum is: -10
Complete your code inside NPL.M.A002.Exercise1.
 */
namespace NPL.M.A002.Exercise1
{
    class Program
    {
        //nhap mang
        static void Nhap(int []a,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        //xuat mang
        static void Xuat(int []a , int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i]+"\t");
            }
        }
        static void Invert(int[] a, int n)
        {
            for (int i = n-1; i >=0; i--)
            {
                Console.Write(a[i] + "\t");
            }
        }
        static int SumOfArray(int []a,int n)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static int LastIndex(int []a,int n)
        {

            for(int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    return i;
                }
            }
            return -1;
        }
        //tìm max min
        static void checkMax(int []a, int n)
        {
            int max = a[0];
            int min = a[0];
            for(int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                else
                {
                    min = a[i];
                }

            }
            Console.WriteLine("max= " + max);
            Console.WriteLine("min= " + min);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so phan tu mang: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhap(a,n);
            Console.WriteLine("Mang da nhap: ");
            Xuat(a, n);
            checkMax(a, n);
            Console.Write("sum= " + SumOfArray(a, n));
            Console.WriteLine("mang sau khi dao: ");
            Invert(a, n);
            Console.WriteLine("last index= " + LastIndex(a, n));
            Console.ReadLine();



        }
    }
}

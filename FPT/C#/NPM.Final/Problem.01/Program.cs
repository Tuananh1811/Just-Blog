using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._01
{
    class Program
    {
        private static decimal[] DrawCircleChart(int[] charInput)
        {
            decimal[] output = new decimal[charInput.Length];
            int charInputLength = charInput.Length;
            int sum = 0;
            for(int i=0;i< charInputLength; i++)
            {
                sum += charInput[i];
            }
            for(int i = 0; i < charInputLength; i++)
            {
                output[i] = (decimal)(charInput[i]) / sum * 100;
            }
            return output;
        }

        static void Main(string[] args)
        {
            try
            {

            Console.WriteLine("nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
               Console.Write("arr[" + i + "]= ");
                arr[i] =int.Parse( Console.ReadLine());

            }
            Console.WriteLine("===========Array============");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            decimal[] arrOutput = DrawCircleChart(arr);
            Console.WriteLine("\n===========Output============");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0:F2}",arrOutput[i]);  //em lấy 2 chữ số sau dấu , nên bị làm tròn chữ số cuối cùng
            }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }

    }
}

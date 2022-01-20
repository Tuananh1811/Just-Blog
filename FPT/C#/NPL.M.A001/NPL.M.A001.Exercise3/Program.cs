using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A001.Exercise3
{
    class Program
    {
        static void  PrintFibonacci()
        {
            int firstNumber=1, secondNumber=1, nextNumber, number;
          
            Console.WriteLine("Nhap so phan tu dai Fibonacci= ");
            number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine("should not be less than 2 ");
            }
            else
            {
                //in ra so đầu tiên và thứ 2 dãy
                Console.Write(firstNumber +"\t"+ secondNumber+"\t");
                //duyệt vòng lặp đến số n
                for(int i = 2; i < number; i++)
                {
                    nextNumber = firstNumber + secondNumber; //số tieps theo bằng tổng 2 số trước đó
                    Console.Write(nextNumber+"\t");//in ra 
                    //gán lại số đầu tiên và số thứ 2
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
        }
        static void Main(string[] args)
        {
          
            PrintFibonacci();
            Console.ReadKey();

        }
    }
}

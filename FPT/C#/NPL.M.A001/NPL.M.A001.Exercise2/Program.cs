using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A001.Exercise2
{
    class Program
    {
      static void ConvertToBinary(long dec)
        {
            long  sum = 0, soDu, i = 1;//khai báo 
           
            do
            {
                soDu = dec % 2;  //thực hiện chia dư cho 2 vào gán số dư vào biến - do chia cho 2 nne dư sẽ là 0 hoặc 1
                sum = sum + (i * soDu); //cộng các số dư
                dec =dec/2; //chia nguyên cho 2
                i = i * 10; 
            }
            while (dec > 0); //tiếp tục lặp nếu dec còn lớn 0
            Console.WriteLine(" base 10 and convert base 2 is ={0}" ,sum);

        }
        static void Main(string[] args)
        {
            long n=13;
            ConvertToBinary(n);
            long m = 14;
            ConvertToBinary(m);
            Console.ReadKey();



        }
    }
}

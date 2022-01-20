using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A001.Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dem = 0; //khai báo biến n, dem và gán biến dem=0
            
            do
            {
                Console.Write("nhap n: ");//hiện thị ra màn hình
                n = int.Parse(Console.ReadLine());//nhập và gán giá trị cho n

                if (n > 0)
                {

                    if (n < 2) //nếu <2 hiện thị ko là số nguyên tố
                    {
                        Console.WriteLine("n={0} ko la so nguyen to", n);
                    }
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(n); i++)
                        {
                            if (n % i == 0)  //nếu giá trị nhập vào chia hết cho 1 số khác 1 và chính nó
                            {
                                dem++; //biến đếm tăng lên 1 

                            }
                        }
                        if (dem == 0) //nếu đếm=0 
                        {
                            Console.WriteLine("n={0} la so nguyen to", n);

                        }
                        else //dem!=0
                        {
                            Console.WriteLine("n={0} khong la so nguyen to", n);
                        }
                    }
                }

            } while (n < 0); //lặp nếu nhập n<0
           
            Console.ReadKey();
        }
    }
}

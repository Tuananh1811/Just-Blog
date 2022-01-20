using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NPL.M.A001.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //y = 2x3 – 6x2 + 2x -1
            try
            {

            float x; //khai báo biến
            Console.Write("nhap x: "); //câu lệnh hiển thị ra màn hình
            x = float.Parse(Console.ReadLine()); // nhập dữ liệu và gán giá trị cho biến
            float y = (float)(2 * Math.Pow(x, 3) - 6 * x * x + 2 * x - 1); //khai báo biến và gán
            Console.WriteLine("y = 2x3 – 6x2 + 2x -1 \n x={0}, y={1}", x, y); //in ra màn hình 
           
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); //hiện thị lỗi nếu xảy ra ngoại lệ
            }
            Console.ReadKey(); //dừng màn hình
        }
    }
}

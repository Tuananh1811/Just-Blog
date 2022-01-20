using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A005.Exercise1
{
    class Program
    {
        public static string NormalizeName(string name)
        {


            if (String.IsNullOrEmpty(name)) return name;

            string result = "";
            //lấy chuỗi
            string[] words = name.Split(' ');
            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                    {
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    }

                    else
                    {
                        result += word.ToUpper() + " ";
                    }
                }
            }
            return result.Trim();
        }
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("nhap chuoi can chuyen doi: ");
            s = Console.ReadLine();

            if (string.IsNullOrEmpty(s) == true || string.IsNullOrWhiteSpace(s) == true)
            {
                Console.WriteLine("chuoi khong hop le");
            }

            if (string.IsNullOrWhiteSpace(s) == false)
            {

                Console.WriteLine("chuoi sau khi chuyen doi: " + NormalizeName(s));
            }

            Console.ReadKey();
        }
    }
}

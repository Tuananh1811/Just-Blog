using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A005.Exercise3
{
    class Program
    {


        //ham chuan hoa
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
        //đổi chỗ
        static void Swap(ref string a, ref string b)
        {

            string tg = a;
            a = b;
            b = tg;
        }
        static void SortName(string[] arrName)
        {
            int nameLength = arrName.Length;
            for (int i = 0; i < nameLength; i++)
            {
                for (int j = i + 1; j < nameLength; j++)
                {
                    string Name = arrName[i];
                    string[] subName = Name.Split(' ');//tách chỗi

                    string fisrtCharLastName = "";
                    //check fullname có đủ họ tên nếu đủ thì lấy chữ cái đầu của từ thứ 2 trong mảng
                    if (subName.Length >= 1)
                    {
                        fisrtCharLastName = subName[subName.Length - 1].Substring(0, 1).ToUpper();
                    }
                    if (subName.Length == 1)
                    {
                        fisrtCharLastName = subName[0].Substring(0, 1).ToUpper();
                    }
                    Console.WriteLine(fisrtCharLastName);
                    string nextName = arrName[j];
                    string[] nextSubName = nextName.Split(' '); //tách chuỗi
                    string nexFirstCharName = "";
                    //check từ đã tách
                    if (nextSubName.Length >= 1)
                    {
                        nexFirstCharName = nextSubName[nextSubName.Length - 1].Substring(0, 1).ToUpper();
                    }

                    if (nextSubName.Length == 1)
                    {
                        nexFirstCharName = nextSubName[0].Substring(0, 1).ToUpper();
                    }
                    Console.WriteLine(nexFirstCharName);
                    //so sánh
                    if (string.Compare(fisrtCharLastName, nexFirstCharName) > 0)
                    {
                        //đổi chỗ

                        Swap(ref arrName[i], ref arrName[j]);
                    }

                }
            }
        }
        static void Main(string[] args)
        {

            int n;


            do
            {

                Console.WriteLine("nhap so phan tu mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            string[] fullName = new string[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("string[" + i + "]= ");
                fullName[i] = Console.ReadLine();
            }
            SortName(fullName);
            for (int i = 0; i < fullName.Length; i++)
            {

                Console.WriteLine(NormalizeName(fullName[i]));
            }


            Console.ReadKey();

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._02
{
    class Program
    {
        static public List<string> GenerateEmailAddress(List<string> listEmployees)
        {
            string domail = "@fsoft.com.vn";
            List<string> listEmp = new List<string>();
            for (int i = 0; i < listEmployees.Count; i++)
            {

                int count = 0;
                string[] arrName = listEmployees[i].Split(' ');
                // Console.WriteLine(arrName[0]);
                string name = arrName[arrName.Length - 1];
                for (int j = 0; j < arrName.Length - 1; j++)
                {
                    name = name + arrName[j].Substring(0, 1).ToUpper();
                }
                string name2 = name;
                //tim ten trung
                while (listEmp.Contains(name))
                {
                    count++;
                    name = name2 + count.ToString();
                };
                //add vào list
                listEmp.Add(name);
            }
            for (int i = 0; i < listEmp.Count; i++)
            {
                listEmp[i] += domail;
            }
            return listEmp;


        }
        static void Main(string[] args)
        {
            try
            {

                int n;
                Console.WriteLine("nhap so phan tu mang");
                n = int.Parse(Console.ReadLine());
                string[] arr = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("name[" + i + "]= ");
                    arr[i] = Console.ReadLine();
                }

                Console.WriteLine("==============Output==========");
                List<string> listEmpl = GenerateEmailAddress(arr.ToList());
                for (int i = 0; i < listEmpl.Count; i++)
                {
                    Console.WriteLine(listEmpl[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

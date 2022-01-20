using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._03
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PhoneBookManagement PBM = new PhoneBookManagement();
            var book = new List<PhoneBook>();
            while (true)
            {
                Console.WriteLine("Phone Book App");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Remove Book");
                Console.WriteLine("3.Sort Book");
                Console.WriteLine("4.Find Book");
                Console.WriteLine("5.Display all contact");
                Console.WriteLine("\n\t\tEnter option");
                int option = int.Parse(Console.ReadLine());
               
                switch (option)
                {
                    case 1:
                        PBM.Add();

                        break;
                    //case 2:
                    //    PBM.Remove("C++");
                    //    break;
                    //case 3:
                    //    PBM.Sort();
                    //    break;
                    //case 4:
                    //    PBM.Find();
                    //    break;
                    case 5:
                        PBM.ShowInForBook();
                        break;
                    default:
                        return;


                }
            }
           
            Console.ReadKey();

        }
    }
}

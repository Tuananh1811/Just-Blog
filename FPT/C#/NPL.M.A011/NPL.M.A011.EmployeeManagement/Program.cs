using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A011.EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Handle handle = new Handle();
            while (true)
            {
                try
                {

                    Console.WriteLine("========Employee Management=======");
                    Console.WriteLine("1. Display All");
                    Console.WriteLine("2. Search Employee");
                    Console.WriteLine("3. Delete Employee");
                    Console.Write("Emter menu option: ");
                    string input = Console.ReadLine();
                    switch (int.Parse(input))
                    {
                        case 1:
                            handle.Output();

                            break;
                        case 2:
                            handle.Search();
                            break;
                        case 3:
                            handle.DeleteEmployee();
                            break;
                        default: return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
       

        }
    }
}

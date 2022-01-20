using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A011.EmployeeManagement
{
    public class Handle
    {

        static EmployeeQueryRepository employeeQuery = new EmployeeQueryRepository();
        static EmployeeMethodRepository EmployeeMethod = new EmployeeMethodRepository();
        public Handle()
        {

        }
        public void Output()
        {
            var emp = employeeQuery.Employees;
            foreach (var item in emp)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void Search()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("======Search Employee==========");
                    Console.WriteLine("1. Search by ID");
                    Console.WriteLine("2. Search by Name (First name of Last name)");
                    Console.WriteLine("3. Search by Status");
                    Console.WriteLine("4. Search top employee by salary");
                    Console.WriteLine("5 Check if employee exist");
                    Console.Write("Enter menu option number: ");
                    string input = Console.ReadLine();
                    switch (int.Parse(input))
                    {
                        case 1:
                            EmployeeById();

                            break;
                        case 2:
                            EmployeeSearchByName();
                            break;
                        case 3:
                            EmployeeByStatus();
                            break;
                        case 4:
                            EmployeeBySalary();
                            break;
                        case 5:
                            Exist();
                            break;
                        default: return;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public void DeleteEmployee()
        {

            try
            {
                Console.WriteLine("enter your Id with delete:: ");
                int input = int.Parse(Console.ReadLine());
                var delete = EmployeeMethod.Delete(input);
               
                if (delete)
                {

                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
        public void EmployeeById()
        {
            Console.WriteLine("Enter your ID: ");
            int IdInput = int.Parse(Console.ReadLine());
            //var employee=   employeeQuery.FindEmployeeById(IdInput);
            //Console.WriteLine(employee.ToString());  
            //method
            var idEmployee = EmployeeMethod.FindEmployeeById(IdInput);
            Console.WriteLine(idEmployee);

        }
        public void EmployeeSearchByName()
        {
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();
            //query
            
           /*   var nameEmployee = employeeQuery.FindEmployeesByName(input);
            foreach (var item in nameEmployee)
            {
                if (item is Employee e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("No");
            }*/
             //method
            var nameEmployee = EmployeeMethod.FindEmployeesByName(input);
            foreach (var item in nameEmployee)
            {
                if (item is Employee e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("No");
            }


        }
        public void EmployeeByStatus()
        {
            Console.WriteLine("Enter status true or false: ");
            string input = Console.ReadLine();
            //var listStatus = employeeQuery.FindEmployeesByStatus(Convert.ToBoolean(input));
            //if (listStatus.Count() == 0)
            //{
            //    Console.WriteLine("Not status");
            //}
            //else
            //{
            //    foreach (var item in listStatus)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}
            var listStatus = EmployeeMethod.FindEmployeesByStatus(Convert.ToBoolean(input));
            if (listStatus.Count() == 0)
            {
                Console.WriteLine("Not status");
            }
            else
            {
                foreach (var item in listStatus)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public void EmployeeBySalary()
        {
            Console.WriteLine("Enter size: ");
            int input = int.Parse(Console.ReadLine());
            //query

            var listSalary = employeeQuery.FindTopEmployeesBySalary(input);
            foreach (var item in listSalary)
            {
                if (item is Employee e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("End");
            }
            //method

            //var listSalary = EmployeeMethod.FindTopEmployeesBySalary(input);
            //foreach (var item in listSalary)
            //{
            //    if (item is Employee e)
            //    {
            //        Console.WriteLine(e.ToString());
            //    }
            //    Console.WriteLine("End");
            //}
        }
        public void Exist()
        {
            Console.WriteLine("Enter your ID: ");
            int IdInput = int.Parse(Console.ReadLine());
            //query
            //var Exist = employeeQuery.Exist(IdInput);
           // Console.WriteLine(Exist);
           //method
            var Exist = EmployeeMethod.Exist(IdInput);
            Console.WriteLine(Exist);
        }
    }
}

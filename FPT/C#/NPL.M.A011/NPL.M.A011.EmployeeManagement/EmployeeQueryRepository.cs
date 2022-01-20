using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A011.EmployeeManagement
{
    class EmployeeQueryRepository : IEmployeeRepository
    {
        
        public List<Employee> Employees { get; set; }

        public EmployeeQueryRepository()
        {
            Employees = DbEmployee();
        }

        public List<Employee> DbEmployee()
        {

            return new List<Employee> {
                new Employee()
                {
                    Id=1,
                    FirstName="Do",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=12345,
                    Level="1",
                    DepartmentName="HaUI"
                },
                 new Employee()
                {
                    Id=2,
                    FirstName="Nguyen",
                    LastName="Anh",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=1200000,
                    Level="1",
                    DepartmentName="FPT23"
                },
                  new Employee()
                {
                    Id=3,
                    FirstName="Tran",
                    LastName="Phuc",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=3450000,
                    Level="1",
                    DepartmentName="FPT"
                },
                   new Employee()
                {
                    Id=4,
                    FirstName="Do",
                    LastName="Dung",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=1034500,
                    Level="1",
                    DepartmentName="FPT22"
                },
                       new Employee()
                {
                    Id=4,
                    FirstName="Mai",
                    LastName="Ngan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=908700,
                    Level="1",
                    DepartmentName="FPT21"
                },
                 new Employee()
                {
                    Id=6,
                    FirstName="Luc",
                    LastName="Hai",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=10000000,
                    Level="1",
                    DepartmentName="FPT20"
                },
                new Employee()
                {
                    Id=7,
                    FirstName="Hoang",
                    LastName="Mai",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=1536789,
                    Level="1",
                    DepartmentName="FPT"
                },
                 new Employee()
                {
                    Id=8,
                    FirstName="Hoang",
                    LastName="Hang",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=108700,
                    Level="1",
                    DepartmentName="FPT15"
                },
                 new Employee()
                {
                    Id=9,
                    FirstName="Nguyen",
                    LastName="Binh",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                   Status=false,
                    Salary=164235,
                    Level="1",
                    DepartmentName="FPT13"
                },
                new Employee()
                {
                    Id=10,
                    FirstName="Pham",
                    LastName="Manh",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=3000000,
                    Level="1",
                    DepartmentName="FPT11"
                },
                  new Employee()
                {
                    Id=11,
                    FirstName="Vu",
                    LastName="Kim",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=16831,
                    Level="1",
                    DepartmentName="FPT10"
                },
                   new Employee()
                {
                    Id=12,
                    FirstName="Pham",
                    LastName="Linh",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=240000,
                    Level="1",
                    DepartmentName="FPT9"
                },
                new Employee()
                {
                    Id=13,
                    FirstName="Phung",
                    LastName="Dai",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=600000,
                    Level="1",
                    DepartmentName="FPT7"
                },
                 new Employee()
                {
                    Id=14,
                    FirstName="Nguyen",
                    LastName="Phuong",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=12322,
                    Level="1",
                    DepartmentName="FPT6"
                },
                 new Employee()
                {
                    Id=15,
                    FirstName="Mai",
                    LastName="Ngan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=123432,
                    Level="1",
                    DepartmentName="FPT4"
                },
                  new Employee()
                {
                    Id=16,
                    FirstName="Ha ",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=12425,
                    Level="1",
                    DepartmentName="Fpt3"
                },
                    new Employee()
                {
                    Id=17,
                    FirstName="Do",
                    LastName="Quan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=12450,
                    Level="2",
                    DepartmentName="FPT2"
                },

                      new Employee()
                {
                    Id=18,
                    FirstName="Do",
                    LastName="Anh",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=12345,
                    Level="1",
                    DepartmentName="FPT1"
                },
            new Employee()
                {
                    Id=19,
                    FirstName="Nguyen",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=12345,
                    Level="1",
                    DepartmentName="Donvi1"
                },

                  new Employee()
                {
                    Id=20,
                    FirstName="Anh",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=12345,
                    Level="1",
                    DepartmentName="FTU"
                },

                 new Employee()
                {
                    Id=21,
                    FirstName="Do",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=true,
                    Salary=12345,
                    Level="1",
                    DepartmentName="HaUI"
                },

                  new Employee()
                {
                    Id=22,
                    FirstName="Do",
                    LastName="Tuan",
                    Email="abc@gmail.com",
                    DateOfBirth= new DateTime(2021,10,20),
                    Status=false,
                    Salary=12345,
                    Level="1",
                    DepartmentName="NEU"
                },



            };
        }

        public bool Delete(int id)
        {
            Employee emp = new Employee();
            var a = from e in Employees
                    where e.Id == id
                    select e;
            foreach (var item in a)
            {
               emp=item;
            }
         return   Employees.Remove(emp);

        }

        public bool Exist(int id)
        {
            Employee e = null;
            var ListEmp = from emp in Employees
                          where emp.Id == id
                          select emp;
            bool check = false;
            foreach (var item in ListEmp)
            {
                e = item;
            }
            if (e != null)
            {
                check = true;
            }
            return check;
        }

        public Employee FindEmployeeById(int id)
        {
            Employee e = new Employee();
            var ListEmp = from emp in Employees where emp.Id == id 
                          select emp;
          
            foreach (var item in ListEmp)
            {
                e = item;
            }
            return e;
        
        }

        public IEnumerable<Employee> FindEmployeesByName(string name)
        {
           
            var ListEmpByName = from e in Employees where e.FirstName  == name || e.LastName==name 
                                select e;
            
            return ListEmpByName;
        }

        public IEnumerable<Employee> FindEmployeesByStatus(bool status)
        {
            var ListEmpByStatus = from e in Employees where e.Status == status 
                                  select e;
            return ListEmpByStatus;
        }

        public IEnumerable<Employee> FindTopEmployeesBySalary(int size)
        {
            var ListEmpByStatus = from e in Employees where e.Id <= size
                                  orderby e.Salary descending
                                  select e;
            return ListEmpByStatus;
        }

    }
}

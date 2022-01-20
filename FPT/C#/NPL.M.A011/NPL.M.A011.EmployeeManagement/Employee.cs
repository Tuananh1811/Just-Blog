using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Id: int
- FirstName: string
- LastName: string.
- Email: string.
- DateOfBirth: Date.
- Status: bool (0 - working, 1 - out).
- Salary: decimal.
- Level: string.
- DepartmentName: string
 */
namespace NPL.M.A011.EmployeeManagement
{
    class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime dateOfBirth;
        private bool status;
        private decimal salary;
        private string level;
        private string departmentName;

        public Employee()
        {

        }

        public Employee(int id, string firstName, string lastName, string email, DateTime dateOfBirth, bool status, decimal salary, string level, string departmentName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            Status = status;
            Salary = salary;
            Level = level;
            DepartmentName = departmentName;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool Status { get => status; set => status = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public string Level { get => level; set => level = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }


        public override string ToString()
        {
            return "ID: "+Id+"\t"+"First name: "+FirstName+"\t"+"Last Name: "+LastName+"\t"+"Email: "+Email+"\t"
                +"Date of birth: "+(DateOfBirth.Day+"/"+DateOfBirth.Month+"/"+DateOfBirth.Year)+"\t "+"Status"+Status+"\t"+"Salary:"+Salary+"\t"+"Level: "+Level+"\t"+"Deparment Name: "+DepartmentName+"\n";
        }


    }

}

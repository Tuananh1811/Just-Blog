using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A008.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Name", "Class", "Gender", "Relationship", "Age", "Grade"));

            Student str1 = new Student(name: "Anh", @class: "httt", gender: "male", age: 21);
            Student str2 = new Student("Tuan anh", "cntt", "female", 21, "Single", 5.8m);
            Student str3 = new Student("Tuan anh", "cntt", "female", 21, "Single", 62);
            str1.Graduate();
            Console.WriteLine(str1.ToString());
            str2.Graduate(2.0);
            Console.WriteLine(str2.ToString());
            Console.WriteLine(str3.ToString("tuana", "httt", "nam", "Single", 20, str3.Graduate(2.8)));
            Console.ReadKey();
        }
    }
}

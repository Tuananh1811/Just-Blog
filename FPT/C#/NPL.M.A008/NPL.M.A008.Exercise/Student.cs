using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A008.Exercise
{
    /*
     * Build Student class with the following properties:
- Name: string
- Class: string.
- Gender: string.
- Relationship: string.
- EntryDate: Date.
- Age: int.
- Address: string.
- Mark: decimal.
- Grade: string.
     */
    public class Student
    {
        private string Name;
        private string Class;
        private string Gender;
        private string Relationship;
        private DateTime EntryDate;
        private int Age;
        private string Address;
        private decimal Mark;
        private string Grade;

        public Student()
        {
        }

        public Student(string name, string @class, string gender, int age,
            string relationship = "Single", decimal mark = 0, string grade = "F")
        {
            Name = name;
            Class = @class;
            Gender = gender;
            Age = age;
            Relationship = relationship;
            Mark = mark;
            //   grade = Graduate();
        }

        public string Graduate(double gradePoint = 0)
        {
            if (gradePoint >= 0 && gradePoint < 1)
            {
                Grade = "F";
            }
            else if (gradePoint < 2)
            {
                Grade = "D";
            }
            else if (gradePoint < 2.3)
            {
                Grade = "C";
            }
            else if (gradePoint < 2.7)
            {
                Grade = "C+";
            }
            else if (gradePoint < 3)
            {
                Grade = "B-";
            }
            else if (gradePoint <= 3.3)
            {
                Grade = "B";
            }
            else if (gradePoint < 3.7)
            {
                Grade = "B+";
            }
            else if (gradePoint < 4)
            {
                Grade = "A-";
            }
            else if (gradePoint == 4)
            {
                Grade = "A-";
            }
            return Grade;
        }
        //public Student(string name, string @class, string gender, int age,
        //   string relationship = "Single", double gradePoint = 0, string grade = "F")
        //{
        //    Name = name;
        //    Class = @class;
        //    Gender = gender;
        //    Age = age;
        //    Relationship = relationship;
        //    Grade = grade;

        //}
        public string ToString()
        {
            // Console.WriteLine(string.Format("{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Name", "Class", "Gender", "Relationship", "Age", " Grade"));
            return string.Format("{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", Name, Class, Gender, Relationship, Age, Grade);

        }
        public string ToString(string name, string @class, string gender, string relationship, int age, string grade)
        {
            return string.Format("{0,-20}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", name, @class, gender, relationship, age, grade);
        }


    }

}

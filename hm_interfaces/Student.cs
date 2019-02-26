using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_interfaces
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName, int grades)
        {
            this.Name = name;
            this.FullName = fullName;
            Grades = new int[grades];
        }
        public double GetAvgGrade()
        {
            int sum = 0;
            foreach (int i in Grades)
            {
                sum += i;
            }
            return Convert.ToDouble(sum/Grades.Length);
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

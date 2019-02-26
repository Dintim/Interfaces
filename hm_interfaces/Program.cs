using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Student s = new Student("Ivan", "Ivanov", 7);
            for (int i = 0; i < s.Grades.Length; i++)
            {
                s.Grades[i] = rnd.Next(12);                
            }
            Console.WriteLine("Average grades: {0}", s.GetAvgGrade());

            
        }
    }
}

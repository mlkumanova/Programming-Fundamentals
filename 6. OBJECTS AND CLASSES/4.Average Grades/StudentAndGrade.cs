using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    public class StudentAndGrade
    {
        public string StudentName { get; set; }
        public List<double> StudentGrades { get; set; }
        public double AvarageGrade => StudentGrades.Sum() / StudentGrades.Count();
    }
    
    }

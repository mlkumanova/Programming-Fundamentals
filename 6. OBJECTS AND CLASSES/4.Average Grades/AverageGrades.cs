using _4.Average_Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AverageGrades
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        List<StudentAndGrade> students = new List<StudentAndGrade>();

        for (int i = 0; i < n; i++)
        {
            StudentAndGrade firstStudent = new StudentAndGrade();

            List<string> data = Console.ReadLine().Split(' ').ToList();

            string studentName = data[0];
            firstStudent.StudentName = studentName;

            List<double> firstStudentGrades = new List<double>();

            for (int j = 1; j < data.Count; j++)
            {
                double studentGrade = double.Parse(data[j]);
                firstStudentGrades.Add(studentGrade);
            }
            firstStudent.StudentGrades = firstStudentGrades;
            students.Add(firstStudent);
        }

        List<StudentAndGrade> notAbleStudents = students
            .OrderBy(student => student.StudentName)
            .ThenByDescending(student => student.AvarageGrade)
            .ToList();

        foreach (var student in notAbleStudents)
        {
            if (student.AvarageGrade >= 5)
            {
                Console.WriteLine($"{student.StudentName} -> {student.AvarageGrade:f3}");
            }
        }
    }
}



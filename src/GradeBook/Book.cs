using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }

           private List<double> grades;
    }
}
}
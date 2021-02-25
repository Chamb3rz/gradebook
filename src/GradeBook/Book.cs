namespace GradeBook
{

    class Book
    {
        public void AddGrade(double grade)
        {
            if (grade >=0 && grade <= 100) 
            {
                Book.Add(grade);
            }
        }
    }
}
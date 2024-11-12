namespace MyApp.Models;

public class StudentRepository : IStudentRepository
{
    private static List<Student> DataSource()
    {
        return
        [
            new Student { StudentId = 101, Name = "Ram", Branch = "BCA", Section = "A", Gender = "Male" },
            new Student { StudentId = 103, Name = "Sita", Branch = "BCA", Section = "A", Gender = "Female" }
        ];
    }

    public Student GetStudentById(int studentId)
    {
        return DataSource().FirstOrDefault(e => e.StudentId == studentId) ?? new Student();
    }

}
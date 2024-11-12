namespace MyApp.Models;

public interface IStudentRepository
{
    Student GetStudentById(int studentId);
}
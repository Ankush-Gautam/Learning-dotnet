using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers;

public class StudentController : Controller
{
    public JsonResult GetStudentDetails(int id)
    {
        var repository = new StudentRepository();
        var studentDetails = repository.GetStudentById(id);

        return Json(studentDetails);
    }
}
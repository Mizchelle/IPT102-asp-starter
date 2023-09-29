using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Mizchelle Rose Sabangan", StudentId = "S001", StudentAge = "21" },
            new StudentInfoModel { Name = "Roselle Mae Dellomas", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Milby Dellomas", StudentId = "S003", StudentAge = "20" }
        };

        return View(studentInfoArray);
    }
}

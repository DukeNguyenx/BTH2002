using Microsoft.AspNetCore.Mvc;
namespace BTH2002.Controllers;
{
    public class EmployeeController : Controller
    {
       public IActionResult About()
    {
        return View();
    }
    }
}
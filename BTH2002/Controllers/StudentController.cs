using Microsoft.AspNetCore.Mvc;
namespace BTH2002.Controllers;

  public class StudentController : Controller
    {
      public IActionResult Index()
      {
        return View();
      }
      [HttpPost]
       public IActionResult Index( string name)
    {
      string strReturn = " Hello, " + name;
      // gui du lieu ve view
      ViewBag.abc = strReturn;
        return View();
    }
}  

    




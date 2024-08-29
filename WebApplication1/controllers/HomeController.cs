using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home(int? id, string? name, Employee emp)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Home with id = {id}";
            //result.ContentType = "text/html" ;
            //result.StatusCode = 200 ;
            return Content($"Home with id = {id}\nName = {name}\nEmployee = {emp}", "text/html");
        }

        public IActionResult Index(int? id)
        {
            return RedirectToAction("Home", new {id = 10});
        }
    }
}

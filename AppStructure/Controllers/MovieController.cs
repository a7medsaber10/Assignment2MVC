using Microsoft.AspNetCore.Mvc;

namespace AppStructure.Controllers
{
    public class MovieController : Controller
    {
        // Action --> Public non static function => Movie/GetMovie
        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with id = {id}";

            return Content($"Movie with id = {id}");
        }

        [ActionName("index")]
        [HttpPost]
        [AcceptVerbs("Post", "Get")]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(GetMovie), new { id = 10 });
        }
    }
}

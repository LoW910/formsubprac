using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    public class User : Controller{

        [HttpGet("")]
        public IActionResult Register() {
            return View();
        }
    }
}
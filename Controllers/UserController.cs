using FormSubmission.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    public class UserController : Controller{

        [HttpGet("")]
        public IActionResult Register() {
            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(User user){
            if(ModelState.IsValid) {
                return RedirectToAction("Success");
            } else {
                return View("Register");
            }
        }

        [HttpGet("success")]
        public IActionResult Success(){
            return View();
        }

    }
}
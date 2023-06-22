using Microsoft.AspNetCore.Mvc;
using ProjectTrackingSoftware.Models;
using ProjectTrackingSoftware.Repo;
namespace ProjectTrackingSoftware.Controllers
{
    public class LoginController : Controller
    {
        private ILogin _login;
        public LoginController(ILogin login)
        {
            _login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnPost(LoginModel model)
        {
            _login.OnPostLogin(model);         
            return RedirectToAction("Index");
        }

    }
}

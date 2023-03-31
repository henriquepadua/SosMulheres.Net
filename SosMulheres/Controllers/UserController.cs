using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SosMulheres.Config;
using SosMulheres.Models;

namespace SosMulheres.Controllers
{
    //[Route("[controller]")]
    public class UserController : Controller
    {
        private readonly SosMulheresContext _context;
        public UserController(SosMulheresContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("Login")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                var UsuarioReturn = _context.User.Any(e => e.Senha == user.Senha && e.Email == user.Email);
                if (UsuarioReturn) return View("/Views/Home/Index.cshtml");
                return View("Login");
            }
            return View("Login");
        }
    }
}
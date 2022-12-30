using Microsoft.AspNetCore.Mvc;
using SosMulheres.Config;
using SosMulheres.Models;
using System.Diagnostics;

namespace SosMulheres.Controllers
{
    public class HomeController : Controller
    {
        private readonly SosMulheresContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SosMulheresContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }


        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id", "Usuario", "Senha")] User user)
        {
            if (ModelState.IsValid)
            {
                var UsuarioReturn = _context.User.Any(e => e.Usuario == user.Usuario && e.Senha == user.Senha);
                if (UsuarioReturn) return View("Index");
                return View();
            }
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
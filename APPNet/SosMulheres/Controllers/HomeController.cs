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
            return View("Index");
        }


        [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Id", "Senha", "Email")] User user)
        {
            if (ModelState.IsValid)
            {
                var UsuarioReturn = _context.User.Any(e => e.Senha == user.Senha && e.Email == user.Email);
                if (UsuarioReturn) return View("Index");
                return View("Login");
            }
            return View("Login");
        }

        [HttpPost]
        [Route("Cadastro")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro( User user)
        {
            if (ModelState.IsValid)
            {
                var UsuarioReturn = _context.User.Any(e => e.Email == user.Email || e.Senha == user.Senha);

                if (UsuarioReturn) return BadRequest();

                _context.User.Add(user);
                _context.SaveChanges();

                return View("Login");
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("Relato")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Relatos(Relatos relatos)
        {
            return View("Relato");
        }

        [HttpPost]
        [Route("Relato")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Relato(Relatos relatos)
        {
            if (ModelState.IsValid)
            {
                _context.Relatos.Add(relatos);
                _context.SaveChanges();
                return View();
            }
            return BadRequest();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
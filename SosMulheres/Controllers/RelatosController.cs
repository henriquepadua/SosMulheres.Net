using Microsoft.AspNetCore.Mvc;
using SosMulheres.Config;
using SosMulheres.Models;
using System.Diagnostics;

namespace SosMulheres.Controllers
{
    public class RelatosController : Controller
    {
        private readonly SosMulheresContext _context;

        public RelatosController(SosMulheresContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("Relato")]
        //[ValidateAntiForgeryToken]
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
    }
}

using Microsoft.AspNetCore.Mvc;

namespace APPNet.Controllers
{
    public class ProdutoController : Controller{
       
        [HttpGet]
        [Route("Cadastrar")]
        public ActionResult Index()
        {
            return View("Views/Start/Index.cshtml");
        }

        [HttpGet]
        [Route("login")]
        public ActionResult Criar()
        {
            return View("Views/Start/Login.cshtml");
        }

        [HttpGet]
        [Route("Relatos")]
        public ActionResult Atualizar()
        {
            return View("Views/Start/Relatos.cshtml");
        }
   }
}
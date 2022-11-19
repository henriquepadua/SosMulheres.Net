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
        [Route("Criar")]
        public ActionResult Criar()
        {
            return View("Views/Start/Criar.cshtml");
        }

        [HttpGet]
        [Route("Atualizar")]
        public ActionResult Atualizar()
        {
            return View("Views/Start/Atualizar.cshtml");
        }

        [HttpGet]
        [Route("ListarProdutos")]
        public ActionResult ListarProdutos(){
            return View("Views/Start/Listar.cshtml");
        }
    }
}
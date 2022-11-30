using Microsoft.AspNetCore.Mvc;
using APPNet.Models;
using APPNet.Interface;
using APPNet.Service;
using APPNet.DAO;

namespace APPNET.Controllers
{
    public class ProdutoController : Controller{
        [HttpGet]
        [Route("Cadastrar")]
        public ActionResult Index()
        {
            return View("Views/Start/Index.cshtml");
        }

        [HttpPost]
        [Route("localhost:5500/relato")]
        public ActionResult CriarRelatos()
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

        [HttpGet]
        [Route("Conexao")]
        public ActionResult Conectar(Produto produto)
        {
            Conectar c = new Conectar();
            ProdutoService service = new ProdutoService(c);
            service.Read(produto);                
            return Ok(StatusCode(200));
            //return BadRequest(StatusCode(404));
            
        }
   }
}
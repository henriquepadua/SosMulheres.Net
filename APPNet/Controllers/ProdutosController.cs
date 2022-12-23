using Microsoft.AspNetCore.Mvc;
using APPNet.Models;
using APPNet.Interface;

namespace APPNET.Controllers
{
    public class UserController : Controller{
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("Index.html")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("login.html")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("Relatos.html")]
        public ActionResult Relatos()
        {
            return View();
        }

        [HttpGet]
        [Route("User/Create")]
        public ActionResult Create(Usuarios user)
        {
            _userService.Create(user);
            return Ok(StatusCode(200));
        }

        [HttpGet]
        [Route("User/Read")]
        public ActionResult Read(Usuarios user)
        {
            _userService.Read(user);
            return Ok(StatusCode(200));
        }

        [HttpGet]
        [Route("User/Delete")]
        public ActionResult Delete(Usuarios user)
        {
            _userService.Delete(user);
            return Ok(StatusCode(200));
        }
    }
}
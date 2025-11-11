using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_caldas.Models;
using proyecto_caldas.Services;

namespace proyecto_caldas.Controllers
{

    [Route("user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                await usuarioService.CrearUsuario(usuario);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
/*

*/
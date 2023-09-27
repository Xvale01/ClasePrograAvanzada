using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramacionNet.Entities;
using WebProgramacionNet.Models;

namespace WebProgramacionNet.Controllers
{
    public class LoginController : Controller
    {
        UsuarioModel classUsuario = new UsuarioModel();

        public ActionResult Index()
        {
            return View();
        }

        //Se utiliza para abrir la vista 
        [HttpGet]
        public ActionResult IniciarSesion()
        {

            return View();
        }

        //Se utiliza para ejecutar la accion de iniciar sesion
        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            classUsuario.IniciarSesion(entidad);
            return View();
        }

        [HttpGet]
        public ActionResult RecuperarCuenta()
        {

            return View();
        }
        

        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            classUsuario.RecuperarCuenta(entidad);
            return View();
        }




        [HttpGet]
        public ActionResult RegistrarCuenta()
        {

            return View();
        }

        [HttpPost]
        public ActionResult RegistrarCuenta(UsuarioEnt entidad)
        {
            classUsuario.RegistarCuenta(entidad);
            return View();
        }


    }
}
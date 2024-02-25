﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            listaUsuarios = new CN_Usuarios().Listar();

            return Json(new { data = listaUsuarios }, JsonRequestBehavior.AllowGet);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalMVC.Controllers
{
    public class FapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DetalleDeuda(int id = 0)
        {
            return View("ListaDeudas");
        }
    }
}

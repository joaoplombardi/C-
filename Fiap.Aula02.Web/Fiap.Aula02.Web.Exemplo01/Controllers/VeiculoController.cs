using Fiap.Aula02.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Controllers
{
    public class VeiculoController : Controller
    {
        private static List<Veiculo> _banco = new List<Veiculo>();
        private static int id;
        public IActionResult Index()
        {
            return View(_banco);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            id++;
            veiculo.ID = id;
            _banco.Add(veiculo);
            TempData["msg"] = "Veículo cadastrado!";
            return RedirectToAction("cadastrar");
        }
    }
}

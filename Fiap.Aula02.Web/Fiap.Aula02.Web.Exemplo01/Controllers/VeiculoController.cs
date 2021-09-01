using Fiap.Aula02.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Controllers
{
    public class VeiculoController : Controller
    {
        private static List<Veiculo> _banco = new List<Veiculo>();
        private void CarregarCores()
        {
            var lista = new List<string>(new string[] { "Prata",
                                                        "Preto",
                                                        "Vermelho",
                                                        "Azul Metálico",
                                                        "Branco",
                                                        "Marrom" });
            ViewBag.cores = new SelectList(lista);
        }
        private static int id;
        public IActionResult Index()
        {
            return View(_banco);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarCores();
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

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarCores();
            var veiculo = _banco.Find(v => v.ID == id);

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {
            _banco[_banco.FindIndex(v => v.ID == veiculo.ID)] = veiculo;
            TempData["msg"] = "Veículo Atualizado!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _banco.RemoveAt(_banco.FindIndex(v => v.ID == id));
            TempData["msg"] = "Veículo removido!";
            return RedirectToAction("index");
        }
    }
}

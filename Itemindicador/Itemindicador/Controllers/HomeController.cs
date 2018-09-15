using Itemindicador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itemindicador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Criando uma ViewBag com uma lista de Indicadors.
            // Utilizo o nome da ViewBag com IndicadorId apenas
            // para facilitar o entendimento do código
            // new SelectList significa retornar uma
            // estrutura de DropDownList
            ViewBag.Indicador_Id = new SelectList
                (
                    new Indicador().ListaIndicador(),
                    "Indicador_Id",
                    "Nome"
                );

            return View();
        }
        [HttpPost]
        public ActionResult Index(string Indicador_Id)
        {
            // O quarto parametro "IndicadorId" diz qual é o ID
            // que deve vir pré-selecionado ao montar o DropDownList
            ViewBag.Indicador_Id = new SelectList
                (
                    new Indicador().ListaIndicador(),
                    "Indicador_Id",
                    "Nome",
                    Indicador_Id
                );

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using Itemindicador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itemindicador.Controllers
{
    public class ItemController : Controller
    {

        public static List<ItemIndicador> listaItemIndicador = new List<ItemIndicador>{
             new ItemIndicador{
             Id = 1,
             Nome = "Erro de Thread não iniciada",
             Descricao = "Alguma Thread não está iniciando suas operações"
             },
             new ItemIndicador{
             Id = 2,
             Nome = "Cadastro aceita espaço em branco",
             Descricao = "Provavél falta de restrição em relação a string vazia \"\" no banco de dados"
             }
         };


        // GET: Item
        public ActionResult Index()
        {
            var item = from i in listaItemIndicador
            orderby i.Id
            select i;

            // Viewbag da dropdownlist
            // Criando uma ViewBag com uma lista de clientes.
            // Utilizo o nome da ViewBag com ClienteId apenas
            // para facilitar o entendimento do código
            // new SelectList significa retornar uma
            // estrutura de DropDownList

            ViewBag.Indicador_Id = new SelectList
                (
                    new Indicador().ListaIndicador(),
                    "Indicador_Id",
                    "Nome"
                );

            return View(item);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Index(FormCollection collection, string Indicador_Id)
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
            try
            {
                ItemIndicador item = new ItemIndicador();
                item.Id = listaItemIndicador.Count+1;
                item.Nome = collection["Nome"];
                item.Descricao = collection["Descricao"];
                listaItemIndicador.Add(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            var itemIndicador = listaItemIndicador.Single(p => p.Id == id);
            return View(itemIndicador);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var itemIndicador = listaItemIndicador.Single(p => p.Id == id);
                if (TryUpdateModel(itemIndicador))
                {
                    // TODO: Add update logic here
                    return RedirectToAction("Index");
                }
                return View(itemIndicador);
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

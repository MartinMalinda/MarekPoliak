using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;

namespace BankAccount.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Show")]
        public IActionResult Show()
        {
            var simbaAccount = new AnimalsAccount("gooad guy", "Simba", 2000, "lion",true);
            return View(simbaAccount);
        }

        [Route("HTML")]
        public IActionResult Html()
        {
            ViewBag.String = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View(ViewBag);
        }

        [Route("List")]
        public IActionResult List()
        {
            return View(ListModel.list);
        }

        [HttpPost]
        [Route("increase")]
        public IActionResult Increase(int index)
        {
            ListModel.list[index].Balance += 10;
            return RedirectToAction("List");
        }

        [HttpPost]
        [Route("increaseKing")]
        public IActionResult IncreaseKing(int index)
        {
            ListModel.list[index].Balance += 100;
            return RedirectToAction("List");
        }

        [HttpPost]
        [Route("NewAnimal")]
        public IActionResult NewAnimal(string moral, string name, int balance, string animalType, int indexer)
        {
            if (indexer <= ListModel.list.Count)
            {
                ListModel.list.Insert(indexer, new AnimalsAccount(moral, name, balance, animalType,false));
            }
            return RedirectToAction("List");
        }
    }
}
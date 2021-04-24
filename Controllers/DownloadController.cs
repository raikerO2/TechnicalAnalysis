using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Core.Factory;
using TechnicalAnalysis.Models;

namespace TechnicalAnalysis.Controllers
{
    public class DownloadController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        static List<DigitalContractModel> _digitalContractModels = new List<DigitalContractModel>()
        {
            new DigitalContractModel {
              Id = 01,
                FirstName = "Mark",
                LastName = "Anthony",
                Age = 25,
                Email = "example@example.com",
                OnlineSignature = "AA1101"
            },
            new DigitalContractModel
            {
                 Id = 02,
                FirstName = "Fox",
                LastName = "Mulder",
                Age = 25,
                Email = "example@example.com",
                OnlineSignature = "AA1102"
            },
                new DigitalContractModel
            {
                 Id = 03,
                FirstName = "John",
                LastName = "Cena",
                Age = 25,
                Email = "example@example.com",
                OnlineSignature = "AA1103"
            },
        };

        
        [HttpGet]
        public IActionResult Download()
        {
            return View(_digitalContractModels);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var contract = _digitalContractModels.FirstOrDefault(item => item.Id.Equals(Id));
            return View(contract);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Modify(DigitalContractModel contract)
        {
            var oldContract = _digitalContractModels.FirstOrDefault(x => x.Id.Equals(contract.Id));
            var indexOf = _digitalContractModels.IndexOf(oldContract);

            _digitalContractModels[indexOf] = contract;
            return View("Download",_digitalContractModels);
        }

        [HttpGet]
        public IActionResult Modify(int Id)
        {
            var contract = _digitalContractModels.FirstOrDefault(item => item.Id.Equals(Id));
            return View(contract);
        }
        
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var contract = _digitalContractModels.Find(x => x.Id.Equals(Id));
            return View(contract);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteContract(int Id)
        {
            var contract = _digitalContractModels.Find(x => x.Id.Equals(Id));
            _digitalContractModels.Remove(contract);
            return View("Download",_digitalContractModels);
        }
    }
}

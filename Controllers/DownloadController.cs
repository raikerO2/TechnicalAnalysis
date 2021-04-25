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
    public static class SharedModels
    {
        public static List<DigitalContractModel> _digitalContractModels = new List<DigitalContractModel>()
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
    }
    public class DownloadController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        

        
        [HttpGet]
        public IActionResult Download()
        {
            return View(SharedModels._digitalContractModels);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var contract = SharedModels._digitalContractModels.FirstOrDefault(item => item.Id.Equals(Id));
            return View(contract);
        }


        [HttpPost]
        public IActionResult Modify(DigitalContractModel contract)
        {
            var oldContract = SharedModels._digitalContractModels.FirstOrDefault(x => x.Id.Equals(contract.Id));
            var indexOf = SharedModels._digitalContractModels.IndexOf(oldContract);

            SharedModels._digitalContractModels[indexOf] = contract;
            return View("Download", SharedModels._digitalContractModels);
        }

        [HttpGet]
        public IActionResult Modify(int Id)
        {
            var contract = SharedModels._digitalContractModels.FirstOrDefault(item => item.Id.Equals(Id));
            return View(contract);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var contract = SharedModels._digitalContractModels.Find(x => x.Id.Equals(Id));
            return View(contract);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ActionName("New")]
        public IActionResult CreateNew(DigitalContractModel contract)
        {
            var numberOfContracts = SharedModels._digitalContractModels.Count();
            contract.Id = numberOfContracts + 1;

            SharedModels._digitalContractModels.Add(contract);
            return View("Download", SharedModels._digitalContractModels);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteContract(int Id)
        {
            var contract = SharedModels._digitalContractModels.Find(x => x.Id.Equals(Id));
            SharedModels._digitalContractModels.Remove(contract);
            return View("Download", SharedModels._digitalContractModels);
        }
    }
}

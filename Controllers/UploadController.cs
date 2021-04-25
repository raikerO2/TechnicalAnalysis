using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TechnicalAnalysis.Models;

namespace TechnicalAnalysis.Controllers
{
    public class UploadController : Controller
    {
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }


        //
        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            if (files.FirstOrDefault().ContentType == "application/json")
            {
                foreach (var file in files)
                {
                    string fileContent = null;
                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    var result = JsonConvert.DeserializeObject<DigitalContractModel>(fileContent);
                    SharedModels._digitalContractModels.Add(result);
                }
                return View("Uploaded");
            }

            return View("Error422");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Core.Interfaces;

namespace TechnicalAnalysis.Models
{
    public class DigitalContractModel : IContract
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string OnlineSignature { get; set; }
    }
}

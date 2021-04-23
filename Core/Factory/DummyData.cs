using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Models;
namespace TechnicalAnalysis.Core.Factory
{
    public static class DummyData
    {
        public static DigitalContractModel DummyDigitalContract()
        {
            return new DigitalContractModel
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Age = 25,
                Email = "example@example.com",
                OnlineSignature = "AA1100"
            };
        }
    }
}

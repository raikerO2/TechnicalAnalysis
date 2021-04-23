using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Core.Types;

namespace TechnicalAnalysis.Core.Interfaces
{
    public interface IContract
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        ContractType Type { get; set; }
    }
}

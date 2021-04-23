using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Core.Types;

namespace TechnicalAnalysis.Core.Interfaces
{
    interface IContract
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Email { get; set; }
    }
}

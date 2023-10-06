using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Domain.Entities
{
    public class IncomeCategory : Status
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}

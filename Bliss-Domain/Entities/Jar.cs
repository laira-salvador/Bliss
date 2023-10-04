using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Domain.Entities
{
    public class Jar : Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PercentOfIncomeAlloted { get; set; }
        public decimal AllottedAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public bool IsDigital { get; set; }
        public Bank Bank { get; set; }
    }
}

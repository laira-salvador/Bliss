using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Domain.Entities
{
    public class Income : Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int? CategoryId { get; set; }
        public IncomeCategory Category { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

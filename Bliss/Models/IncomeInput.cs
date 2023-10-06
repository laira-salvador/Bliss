using Bliss_Domain.Entities;

namespace Bliss.Models
{
    public class IncomeInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
    }
}

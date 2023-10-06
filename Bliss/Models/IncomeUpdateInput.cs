namespace Bliss.Models
{
    public class IncomeUpdateInput
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public int? CategoryId { get; set; }
    }
}

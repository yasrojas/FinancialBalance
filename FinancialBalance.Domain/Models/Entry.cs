namespace FinancialBalance.Domain.Models
{
    public class Entry
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
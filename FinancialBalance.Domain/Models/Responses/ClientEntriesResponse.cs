using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialBalance.Domain.Models.Responses
{
    public class ClientEntriesResponse
    {
        public DateTime EntryDate { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}

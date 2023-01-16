using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialBalance.Domain.Models.Requests
{
    public abstract class ClientEntryRequest
    {
        public Guid ClientId { get; set; }
        public DateTime? BeginningDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
    }
}

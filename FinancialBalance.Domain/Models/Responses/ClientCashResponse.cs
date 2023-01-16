using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialBalance.Domain.Models.Responses
{
    public class ClientCashResponse
    {
        public decimal Cash { get; set; }
        public DateTime FromDate { get; set; }
    }
}

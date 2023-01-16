using FinancialBalance.Domain.Models.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialBalance.Domain.Models.Commands
{
    public class ClientCashRequest : IRequest<ClientCashResponse>
    {
        public Guid ClientId { get; set; }
    }
}

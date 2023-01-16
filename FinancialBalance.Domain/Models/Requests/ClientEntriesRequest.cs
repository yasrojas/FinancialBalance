using FinancialBalance.Domain.Models.Responses;
using MediatR;

namespace FinancialBalance.Domain.Models.Requests
{
    public class ClientEntriesRequest : ClientEntryRequest, IRequest<ClientEntriesResponse>
    {
    }
}

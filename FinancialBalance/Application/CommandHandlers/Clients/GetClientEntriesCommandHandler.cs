using FinancialBalance.Domain.Models.Requests;
using FinancialBalance.Domain.Models.Responses;
using MediatR;

namespace FinancialBalance.API.Application.CommandHandlers.Clients
{
    public class GetClientEntriesCommandHandler : IRequestHandler<ClientEntriesRequest, ClientEntriesResponse>
    {
        public GetClientEntriesCommandHandler() { }
        public Task<ClientEntriesResponse> Handle(ClientEntriesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

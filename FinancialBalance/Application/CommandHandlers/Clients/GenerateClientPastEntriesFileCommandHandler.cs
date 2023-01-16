using FinancialBalance.Domain.Models.Requests;
using MediatR;

namespace FinancialBalance.API.Application.CommandHandlers.Clients
{
    public class GenerateClientPastEntriesFileCommandHandler : IRequestHandler<ClientPastEntriesRequest, bool>
    {
        public Task<bool> Handle(ClientPastEntriesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

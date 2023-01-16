using FinancialBalance.Domain.Models.Commands;
using FinancialBalance.Domain.Models.Responses;
using MediatR;

namespace FinancialBalance.API.Application.CommandHandlers.Clients
{
    public class GetCashCommandHandler : IRequestHandler<ClientCashRequest, ClientCashResponse>
    {
        public GetCashCommandHandler()
        {

        }

        public Task<ClientCashResponse> Handle(ClientCashRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}


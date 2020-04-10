using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediTest.Commands.RequestCommands;
using MediTest.Commands.ResponseCommands;

namespace MediTest.Handlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestCommand, MakeOrderResponseCommand>
    {
        public async Task<MakeOrderResponseCommand> Handle(MakeOrderRequestCommand request, CancellationToken cancellationToken)
        {
            var result = new MakeOrderResponseCommand
            {
                IsSuccess = true,
                OrderId = new Guid("6aeb18da-f7eb-4a63-a9aa-77fcc4a876ba")
            };
            return result;
        }
    }
}
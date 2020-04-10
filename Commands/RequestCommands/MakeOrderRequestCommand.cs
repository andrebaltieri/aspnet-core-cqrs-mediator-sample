using System;
using MediatR;
using MediTest.Commands.ResponseCommands;

namespace MediTest.Commands.RequestCommands
{
    public class MakeOrderRequestCommand : IRequest<MakeOrderResponseCommand>
    {
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOrder { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public Guid OrderPersonId { get; set; }

    }
}
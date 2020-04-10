using System;

namespace MediTest.Commands.ResponseCommands
{
    public class MakeOrderResponseCommand
    {
        public bool IsSuccess { get; set; }
        public Guid OrderId { get; set; }
    }
}
using System;
using MediatR;
using MediTest.Queries.ResponseQueries;

namespace MediTest.Queries.RequestQueries
{
    public class GetOrderByIdRequest : IRequest<GetOrderByIdResponse>
    {
        public Guid OrderId { get; set; }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediTest.Queries.RequestQueries;
using MediTest.Queries.ResponseQueries;

namespace MediTest.Handlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequest, GetOrderByIdResponse>
    {

        public async Task<GetOrderByIdResponse> Handle(GetOrderByIdRequest request, CancellationToken cancellationToken)
        {
            var order = new GetOrderByIdResponse();
            return order;
        }
    }
}
using MediatR;
using MediTest.Commands.RequestCommands;
using MediTest.Queries.RequestQueries;
using Microsoft.AspNetCore.Mvc;

namespace MediTest.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromServices]IMediator mediator,
            [FromQuery]GetOrderByIdRequest command
        )
        {
            var result = mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult MakeOrder(
            [FromServices]IMediator mediator,
            [FromBody]MakeOrderRequestCommand command
        )
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}

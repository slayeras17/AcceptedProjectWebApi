using AcceptedProject.Application.Interfaces;
using AcceptedProject.Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchManager _manager;
        public MatchController(IMatchManager manager)
        {
            _manager = manager;
        }


        [HttpPost]
        public IActionResult AddMatch(Game match)
        {

            _manager.AddMatch(match);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMatch(int id, [FromBody]Game game)
        {
            _manager.UpdateMatch(id,game);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _manager.DeleteMatch(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMatch(int id)
        {
            var game = _manager.GetMatch(id);
            return Ok(game);
        }
    }
}

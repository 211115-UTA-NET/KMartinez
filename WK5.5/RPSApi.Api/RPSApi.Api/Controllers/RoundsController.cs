using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpsApi.DataStorage;
using RpsApi.Logic;

namespace RPSApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundsController : ControllerBase
    {
        private readonly IRepository _repository;
        public RoundsController(IRepository repository)
        {
            _repository = repository;
        }


        //GET /api/rounds/fred
        [HttpGet]
        public async Task<IActionResult> GetAllByPlayerAsync([FromQuery] string player)
        {
            IEnumerable<Round>? rounds = await _repository.GetAllRoundsOfPlayerAsync(player);
            return new JsonResult(rounds);
           
        }
    }
}

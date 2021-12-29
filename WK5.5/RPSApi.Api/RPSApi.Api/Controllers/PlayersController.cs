using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpsApi.DataStorage;

namespace RPSApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IRepository _repository;
        public PlayersController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]

        public IActionResult GetAll()
        {
            // new SqlRepository(File()); //this make it less unit testable so use a constructor
            return null;
        }
    }
}

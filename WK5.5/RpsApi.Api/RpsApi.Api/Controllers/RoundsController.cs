using Microsoft.AspNetCore.Mvc;

namespace RpsApi.Api.Controllers
{
    public class RoundsController : Controller
    {
        public RoundsController(IRepository reposotiry)
        {
            _repository = reposotiry;
            
            
        }

        //GET /api/rounds/?player=fred
        [HttpGet]
        public IActionResult GetAllByPlayer(string name)
        {
            IEnumerable<Logic.Round>? rounds = await _repositiyr.GetAllRoundsOfPLayerAsync(player);

            return new JsonResult(rounds);
        }
    }
}

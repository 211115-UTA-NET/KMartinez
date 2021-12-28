using Microsoft.AspNetCore.Mvc;

namespace RpsApi.Api.Controllers
{
    public class PlayersController : Controller
    {

        private readonly IRepository _repository;
        [Route("api/[controllers]")]
        [ApiController]

        //GET /api/players
        [HttpGet]
        public IActionResult GetAll()
        {
            
            return View();
        }
    }
}

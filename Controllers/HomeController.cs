using GuidonApp.Models;
using GuidonApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuidonApp.Controllers
{
    public class HomeApiController : ControllerBase
    {
        private readonly GameService _gameService;

        public HomeApiController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("create-new-game")]
        [Produces("application/json")]
        public async Task<ActionResult> StartGame()
        {
            var game = _gameService.CreateNewGame();
            return Ok(game);
        }

    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

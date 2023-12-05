using GameStore.BLL.Interfaces;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;
using GameStore.WEB.ViewModels.Games;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers;

public class GamesController : Controller
{
    private readonly IGameService _gameService;
    private readonly IGameRepository _gameRepository;

    public GamesController(
        IGameService gameService,
        IGameRepository gameRepository
    )
    {
        _gameService = gameService;
        _gameRepository = gameRepository;
    }


    [HttpGet]
    public IActionResult Index()
    {
        var games = _gameService.Read();

        var indexViewModel = new IndexViewModel
        {
            Games = games
        };

        return View(indexViewModel);
    }

    [HttpGet("{id}/deleteGame")]
    public IActionResult Delete(int id)
    {
        var game = _gameService.Read(id);

        var indexViewModel = new DeleteViewModel
        {
            Game = game
        };

        return View(indexViewModel);
    }


    [HttpPost("{id}/deleteGame")]
    public ActionResult SubmitDelete(int id)
    {
        _gameRepository.Delete(id);

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(string gameName)
    {
        _gameRepository.Create(new Game
        {
            Name = gameName
        });
        return RedirectToAction("Index");
    }
}
using GameStore.BLL.Interfaces;
using GameStore.DAL.Interfaces;
using GameStore.WEB.ViewModels.Genres;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers;

public class GenresController : Controller
{
    private readonly IGenreService _genreService;
    private readonly IGenreRepository _genreRepository;

    public GenresController(
        IGenreService genreService, 
        IGenreRepository genreRepository
    )
    {
        _genreService = genreService;
        _genreRepository = genreRepository;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var genres = _genreService.Read();
        
        var indexViewModel = new IndexViewModel
        {
            Genres = genres
        };

        return View(indexViewModel);
    }
    
    [HttpGet("{id}/deleteGenre")]
    public IActionResult Delete(int id)
    {
        var genre = _genreService.Read(id);

        var indexViewModel = new DeleteViewModel
        {
            Genre = genre
        };

        return View(indexViewModel);
    }


    [HttpPost("{id}/deleteGenre")]
    public ActionResult SubmitDelete(int id)
    {
        _genreRepository.Delete(id);

        return RedirectToAction("Index");
    }
}
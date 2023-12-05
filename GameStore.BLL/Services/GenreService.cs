using GameStore.BLL.Interfaces;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;

namespace GameStore.BLL.Services;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(
        IGenreRepository genreRepository
    )
    {
        _genreRepository = genreRepository;
    }

    public void Create(Genre genre)
    {
        _genreRepository.Create(genre);
    }

    public Genre Read(int id)
    {
        var genre = _genreRepository.Read(id);

        return genre;
    }

    public IList<Genre> Read()
    {
        var genres = _genreRepository.Read();

        return genres;
    }

    public void Update(Genre genre)
    {
        _genreRepository.Update(genre);
    }

    public void Delete(int genreId)
    {
        _genreRepository.Delete(genreId);
    }
}
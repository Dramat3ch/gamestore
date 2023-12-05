using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;

namespace GameStore.DAL.Repositories;

public class GenreRepository : IGenreRepository
{
    private readonly DataContext _dataContext;

    public GenreRepository(
        DataContext dataContext
        
    )
    {
        _dataContext = dataContext;
    }
    
    public void Create(Genre genre)
    {
       
        throw new NotImplementedException();
    }

    public Genre Read(int id)
    {
        var genre = _dataContext.Genres
            .First(genre => genre.Id == id);

        return genre;
    }

    public IList<Genre> Read()
    {
        var genres = _dataContext.Genres
            .ToList();

        return genres;
    }

    public void Update(Genre genre)
    {
        throw new NotImplementedException();
    }

    public void Delete(int genreId)
    {
        var genre = _dataContext.Genres.First(g => g.Id == genreId);

        _dataContext.Genres.Remove(genre);
        _dataContext.SaveChanges();
    }
}
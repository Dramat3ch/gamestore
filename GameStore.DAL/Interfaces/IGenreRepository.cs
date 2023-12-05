using GameStore.DAL.Models;

namespace GameStore.DAL.Interfaces;

public interface IGenreRepository
{
    public void Create(Genre genre);
    public Genre Read(int id);
    public IList<Genre> Read();
    public void Update(Genre genre);
    public void Delete(int genreId);
}
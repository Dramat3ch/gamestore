using GameStore.DAL.Models;

namespace GameStore.BLL.Interfaces;

public interface IGenreService
{
    public void Create(Genre genre);
    public Genre Read(int id);
    public IList<Genre> Read();
    public void Update(Genre genre);
    public void Delete(int genreId);
}
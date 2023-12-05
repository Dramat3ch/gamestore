using GameStore.DAL.Models;

namespace GameStore.DAL.Interfaces;

public interface IGameRepository
{
    public void Create(Game game);
    public Game Read(int id);
    public IList<Game> Read();
    public void Update(Game game);
    public void Delete(int gameId);
}
using GameStore.DAL.Models;

namespace GameStore.BLL.Interfaces;

public interface IGameService
{
    public void Create(Game game);
    public Game Read(int id);
    public IList<Game> Read();
    public void Update(Game game);
    public void Delete(int gameId);
}
using GameStore.BLL.Interfaces;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;

namespace GameStore.BLL.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;

    public GameService(
        IGameRepository gameRepository
    )
    {
        _gameRepository = gameRepository;
    }

    public void Create(Game game)
    {
        _gameRepository.Create(game);
    }

    public Game Read(int id)
    {
        var game = _gameRepository.Read(id);

        return game;
    }

    public IList<Game> Read()
    {
        var games = _gameRepository.Read();

        return games;
    }

    public void Update(Game game)
    {
        _gameRepository.Update(game);
    }

    public void Delete(int gameId)
    {
        _gameRepository.Delete(gameId);
    }
}
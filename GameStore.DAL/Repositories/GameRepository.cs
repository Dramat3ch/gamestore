using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DAL.Repositories;

public class GameRepository : IGameRepository
{
    private readonly DataContext _dataContext;

    public GameRepository(
        DataContext dataContext
    )
    {
        _dataContext = dataContext;
    }

    public void Create(Game game)
    {
        _dataContext.Games.AddAsync(game);
        _dataContext.SaveChanges();
    }

    public Game Read(int id)
    {
        var game = _dataContext.Games
            .Include(game => game.Genres)
            .First(game => game.Id == id);

        return game;
    }

    public IList<Game> Read()
    {
        var games = _dataContext.Games
            .Include(game => game.Genres)
            .ToList();

        return games;
    }

    public void Update(Game game)
    {
        throw new NotImplementedException();
    }

    public void Delete(int gameId)
    {
        var game = _dataContext.Games.First(g => g.Id == gameId);

        _dataContext.Games.Remove(game);
        _dataContext.SaveChanges();
    }
}
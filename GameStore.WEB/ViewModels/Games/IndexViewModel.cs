using System.Collections.Generic;
using GameStore.DAL.Models;

namespace GameStore.WEB.ViewModels.Games;

public class IndexViewModel
{
    public IEnumerable<Game> Games { get; set; }
}
using System.Collections.Generic;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameStore.WEB.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public SelectList Genres { get; set; }
        public string Name { get; set; }
    }
}
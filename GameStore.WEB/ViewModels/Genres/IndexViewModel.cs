using System.Collections.Generic;
using GameStore.DAL.Models;

namespace GameStore.WEB.ViewModels.Genres;

public class IndexViewModel
{
    public IList<Genre> Genres { get; set; }
}
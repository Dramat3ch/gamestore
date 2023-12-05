namespace GameStore.DAL.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
namespace GameStore.DAL.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Game> Games { get; set; }
    }
}
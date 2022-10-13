namespace VaporStore.Data.Models
{
    public class GameTag
    {
        //todo add composite primary key

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}

using CardGames.Enums;

namespace CardGames.Models
{
    public class Card
    {
        public string Name { get; set; }
        public Suit Suit { get; set; }
        public Dignity Dignity { get; set; }
    }
}
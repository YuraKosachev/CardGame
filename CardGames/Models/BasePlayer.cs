using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Models
{
    public abstract class BasePlayer
    {
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Card> Cards { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Models
{
    public class PockerGameSession
    {
        public int SessionId { get; set; }
        public IList<Card> DeskCards { get; set; }
        public Guid DealerId { get; set; }
        public IDictionary<Guid, IList<Card>> UserCards { get; set; }
    }
}
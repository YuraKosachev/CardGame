using CardGames.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Models
{
    public class PokerPlayer : BasePlayer
    {
        public Status Status { get; set; }
        public decimal Points { get; set; }
        public bool IsDealer { get; set; }
    }
}
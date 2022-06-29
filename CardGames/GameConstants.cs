using CardGames.Enums;
using CardGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CardGames.Helpers;

namespace CardGames
{
    public static class GameConstants
    {
        public static class DeckCards
        {
            public static IList<Card> TexasHoldemDeskCards
            {
                get
                {
                    return CollectionHelper.EnumToArray<Suit>()
                    .SelectMany(suit => CollectionHelper.EnumToArray<Dignity>().Select(card => new Card
                    {
                        Dignity = card,
                        Suit = suit,
                        Name = card.ToString()
                    })).ToList();
                }
            }
        }

        public static class Message
        {
            public static string StartFormat => "Game {0} started";
            public static string EndFormat => "Game {0} end";
            public static string PartyStartFormat => "Party #{0} started";
            public static string PartyEndFormat => "Party #{0} end";
        }
    }
}
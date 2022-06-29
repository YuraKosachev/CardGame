using CardGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGames.Helpers
{
    public static class CollectionHelper
    {
        public static IList<Card> Shuffle(this IList<Card> source)
        {
            var rand = new Random();
            return source.OrderBy(card => rand.Next()).ToList();
        }

        public static IList<TEnum> EnumToArray<TEnum>()
            where TEnum : struct
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
        }
    }
}
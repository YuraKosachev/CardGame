using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Games.PockerRounds
{
    public abstract class Round
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        protected IInputService _input


        public abstract void RoundAction();
    }
}
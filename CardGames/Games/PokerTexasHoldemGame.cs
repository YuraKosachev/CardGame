using CardGames.Interfaces;
using CardGames.Models;
using System;
using System.Collections.Generic;
using System.Text;
using CardGames.Helpers;
using System.Linq;
using CardGames.Enums;

namespace CardGames.Games
{
    public class PokerTexasHoldemGame : Game<PokerPlayer>, IGame
    {
        private IInputService _inputServise;
        private decimal _bank;

        public PokerTexasHoldemGame(IList<PokerPlayer> players,
            ILoggerService logger,
            IInputService inputService)
            : base(GameConstants.DeckCards.TexasHoldemDeskCards,
                  players,
                  logger)
        {
            _inputServise = inputService;
        }

        protected override void GameProccess(int interation)
        {
            if (_players.Count <= 1)
            {
                _isActive = false;
                return;
            }
            //set dealer

            var shuffle = _cards.Shuffle();

            //pre flop
            //flop
            //
        }

        //private PokerStatus

        protected override void GameStat()
        {
            foreach (var player in _players)
            {
                _logger.Info($"[id:{player.UniqueId}] {player.Name} score:{player.Points}");
            }
        }
    }
}
using CardGames.Interfaces;
using CardGames.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Games
{
    public abstract class Game<TPlayer>
        where TPlayer : BasePlayer
    {
        protected readonly IList<Card> _cards;
        protected readonly IList<TPlayer> _players;
        protected readonly ILoggerService _logger;
        protected bool _isActive = true;

        public Game(IList<Card> cards,
            IList<TPlayer> players,
            ILoggerService logger)
        {
            _cards = cards;
            _players = players;
            _logger = logger;
        }

        public void Process()
        {
            try
            {
                var name = GetType().Name;
                _logger.Info(string.Format(GameConstants.Message.StartFormat, name));
                for (var i = 0; _isActive; i++)
                {
                    _logger.Info(string.Format(GameConstants.Message.PartyStartFormat, i));
                    GameProccess(i);
                    GameStat();
                    _logger.Info(string.Format(GameConstants.Message.PartyEndFormat, i));
                }

                _logger.Info(string.Format(GameConstants.Message.EndFormat, name));
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }

        protected abstract void GameProccess(int interation);

        protected abstract void GameStat();
    }
}
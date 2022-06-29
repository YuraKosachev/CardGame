using System;
using System.Collections.Generic;
using System.Text;

namespace CardGames.Interfaces
{
    public interface IInputService
    {
        string GetUserString();

        int GetUserNum();
    }
}
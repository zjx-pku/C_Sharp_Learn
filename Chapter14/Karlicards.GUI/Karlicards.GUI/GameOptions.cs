using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karlicards.GUI
{
    [Serializable]
    public class GameOptions
    {
        public bool PlayAgainstComputer { get; set; }
        public int NumberOfPlayers { get; set; }
        public int MinutesBeforeLoss { get; set; }
        public ComputerSkillLevel ComputerSkill { get; set; }

    }


    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}

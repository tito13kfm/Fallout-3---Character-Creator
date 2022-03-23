using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallout_3___Character_Creator
{
    internal class Character
    {
        public string Name;
        public int Strength=5, Perception=5, Endurance=5, Charisma=5, Intelligence=5, Agility=5, Luck=5;
        public int StatPoints=5;
        public int Barter=15, BigGuns=15, EnergyWeapons=15, Explosives=15, Lockpick=15, Medicine=15, MeleeWeapons=15, 
            Repair=15, Science=15, SmallGuns=15, Sneak=15, Speech=15, Unarmed=15;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Game_Official
{
    public abstract class Character
    {
        //CONSTANTS
        const int MAX_ATTACK_LEVEL = 100;
        const int MAX_DEFENSE_LEVEL = 100;
        const int MIN_ATTACK_LEVEL = 0;
        const int MIN_DEFENSE_LEVEL = 0;
        const int HIGHEST_XP_LEVEL = 75;
        const int POWER_LEVEL_CLOSE_TO_DYING = 10;

        //FIELDS
        //Character Status for all characters
        int _currentPower = 100;
        int _attackLevel = 0;
        int _defenseLevel = 0;
        bool _isAlive = true;
        bool _isLowOnPower = true;
        bool _isInBonusLand = true;
        bool _hasRandomPowerUpLaser = true;

        //PROPERTIES
        public bool IsDefinitelyLowOnPower
        {
            get
            {
                return _isLowOnPower;
            }
        }
        public bool IsInBonusLand
        {
            get
            {
                return _isInBonusLand;
            }
        }
        public bool NeedsPowerDesperately
        {
            get
            {
                return _currentPower <= POWER_LEVEL_CLOSE_TO_DYING;
            }
        }

        public int CurrentPower { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    class Player
    {
        /// <summary>
        /// Discuss stylecop order: http://stackoverflow.com/questions/150479/order-of-items-in-classes-fields-properties-constructors-methods
        /// </summary>
        /*
         * Constant Fields
            Fields
            Constructors
            Enums
            Interfaces
            Properties
            Indexers
            Methods
            Structs
            Classes
         */
        //CONSTANTS
        const int MAX_ATTACK_LEVEL = 100;
        const int MAX_DEFENSE_LEVEL = 100;
        const int MIN_ATTACK_LEVEL = 0;
        const int MIN_DEFENSE_LEVEL = 0;
        const int HIGHEST_XP_LEVEL = 75;
        const int POWER_LEVEL_CLOSE_TO_DYING = 10;

        //FIELDS
        //Player Status
        int _currentPower = 100;
        int _attackLevel = 0;
        int _defenseLevel = 0;
        bool _isAlive = true;
        bool _isLowOnPower = true;
        bool _isInBonusLand = true;
        bool _hasRandomPowerUpLaser = true;        
        // Player details.
        string _firstName = null;
        string _gamerName = null;
        int _gamerLevel = 0;
        CharacterType _characterType = CharacterType.Undefined;

        // CONSTRUCTORS
        public Player(string firstName, string gamerName, CharacterType type)
        {
            this.PlayerName = firstName;
            this.GamerName = gamerName;
            this.Type = type;
        }

        //ENUMS
        // Custom type.
        public enum CharacterType
        {
            BlitzenBlopper,
            TrollCat,
            HorseMage,
            Soldier, 
            Undefined
        }

        // PROPERTIES
        public string PlayerName { get; set; }
        public string GamerName
        {
            get { return _gamerName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _gamerName = value.Trim();
            }
        } 
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
        public CharacterType Type
        {
            get
            {
                return _characterType;
            }
            set
            {
                if (value == CharacterType.Undefined)
                    throw new ArgumentException("Character Type cannot be undefined.");
                else
                    _characterType = value;
            }
        } 
 
        //METHODS
        //Attack, Defend, Heal, Respawn
        public bool Attack()
        {
            if (!this.IsDefinitelyLowOnPower)
            {
                Console.WriteLine("Ready to attack!");
                return true;
            }
            else
            {
                Console.WriteLine("You are definitely low on attack power. You can't attack.");
                return false;
            }
        }
        public bool Defend()
        {
            return true;
           //TODO
        }
        public bool AbleToHeal()
        {
            //TODO: Code
            return true;
        }

        public override string ToString() /* override so we print first name + last name when calling ToString() */
        {
            return String.Format("Player Name: {0} \nGamer Name: {1} \nPlayer Type: {2}", this.PlayerName, this.GamerName, this.Type);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Demo_Paul
{

    

    public class Player
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
        WeaponType _weaponType = WeaponType.Undefined;


        // CONSTRUCTORS
        public Player(string firstName, string gamerName, CharacterType type = CharacterType.Human)
        {
            this.PlayerName = firstName;
            this.GamerName = gamerName;
            this._gamerLevel = 0;
            this.CurrentPower = 100;
            this.Type = type;
        }

        //ENUMS
        // Custom type.
        public enum CharacterType
        {
            BlitzenBlopper = 0,
            TrollCat = 1,
            HorseMage = 2,
            Soldier = 3,
            Undefined = 4,
            Human = 5
        }

        public enum WeaponType
        {
            TheSwordOfSmigel = 0,
            TheAxeOfEvermore = 1,
            TheRingOfValkrow = 2,
            TheLaserOfLambeaux = 3,
            TheDustyStick = 4,
            Undefined = 5

        }

        /// <summary>
        /// INTERFACES
        /// </summary>
       

        
        /// PROPERTIES
        public string PlayerName { get; set; }
        public int CurrentPower { get; set; }
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
        public int PlayerPower { get; set; }

        
        //METHODS
        //Choose Character, Choose Weapon, Attack, Defend, Heal, Respawn
        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 1:
                    Console.WriteLine("Ah, a JSWizard. Pretty Ordinary.");
                    return this._characterType = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Troll Cat. What in the world is that?");
                    return this._characterType = CharacterType.TrollCat;
                case 3:
                    Console.WriteLine("A Horse Mage. Sounds like something my dog puked up.");
                    return this._characterType = CharacterType.HorseMage;
                case 4:
                    Console.WriteLine("You are a little Soldier. How charming.");
                    return this._characterType = CharacterType.Soldier;
                default:
                    Console.WriteLine("You are a Human");
                    return this._characterType = CharacterType.Human;

            }
        }

        public WeaponType ChooseWeaponType(int t)
        {
            switch (t)
            {
                case 1:
                    Console.WriteLine("The Axe.");
                    return this._weaponType = WeaponType.TheAxeOfEvermore;
                case 2:
                    Console.WriteLine("A Dusty Stick.");
                    return this._weaponType = WeaponType.TheDustyStick;
                case 3:
                    Console.WriteLine("The Laser of Lambeaux.");
                    return this._weaponType = WeaponType.TheLaserOfLambeaux;
                case 4:
                    Console.WriteLine("The Ring of Valkrom.");
                    return this._weaponType = WeaponType.TheRingOfValkrow;
                case 5:
                    Console.WriteLine("The Sword of Smigel.");
                    return this._weaponType = WeaponType.TheSwordOfSmigel;

                default:
                    Console.WriteLine("The Sword of Smigel");
                    return this._weaponType = WeaponType.TheSwordOfSmigel;

            }
        }

        public string DeclareType()
        {
            if (this.Type.ToString() == CharacterType.HorseMage.ToString())
            {
                string message = "You are a Horse Mage";
                Console.WriteLine(message);
                return message;
            }
            else
            {
                return "hey";
            }

        }

        public void AnotherDay()
        {
            Console.WriteLine("Maybe another day.");
        }

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

        public int GetPowerLevel()
        {
            Random rando = new Random();
            int power = rando.Next(1, 100);
            this.PlayerPower = power;
            Console.WriteLine(this.PlayerPower);
            return PlayerPower;
        }

        public void StatePowerLevel()
        {
            Console.WriteLine("I am a level {0}", this.PlayerPower);
        }


        public override string ToString() /* override so we print first name + last name when calling ToString() */
        {
            return String.Format("Player Name: {0} \nGamer Name: {1} \nPlayer Type: {2}", this.PlayerName, this.GamerName, this.Type);
        }

    }
}

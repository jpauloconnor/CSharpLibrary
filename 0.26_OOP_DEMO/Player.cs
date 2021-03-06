﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    public enum CharacterType
    {
        BlitzenBlopper = 0,
        TrollCat = 1,
        HorseMage = 2,
        Soldier = 3,
        Undefined = 4,
        Human = 5
    }

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
        int _attackLevel = 0;
        int _defenseLevel = 0;
        bool _isAlive = true;
        bool _isLowOnPower = true;
        bool _isInBonusLand = true;
        bool _hasRandomPowerUpLaser = true;        
        // Player details.
        string _gamerName = null;
        int _gamerLevel;
        CharacterType _characterType = CharacterType.Undefined;

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

        // PROPERTIES
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
        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 1:
                    Console.WriteLine("You are a Blizen Blopper");
                    return this._characterType = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Troll Cat");
                    return this._characterType = CharacterType.TrollCat;
                case 3:
                    Console.WriteLine("You are a Horse Mage");
                    return this._characterType = CharacterType.HorseMage;
                case 4:
                    Console.WriteLine("You are a Soldier");
                    return this._characterType = CharacterType.Soldier;
                default:
                    Console.WriteLine("You are a Human");
                    return this._characterType = CharacterType.Human;

            }
        }

        public string DeclareType()
        {
            if(this.Type == CharacterType.HorseMage)
            {
                string message = "You are a Horse Mage"; 
                Console.WriteLine(message);
                return message;
            } else
            {
                return "hey";
            }

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
        public void Attack(Enemy e)
        {
            Console.WriteLine("What would you like to do?\n" +
                                "1: Party Like A RockStar(10pt ATK)\n" +
                                "2: Flaming Jazz Hands(30pt ATK)\n" +
                                "3: Drink a Four Loko(15pt HEALTH)");
            int playerChoice = int.Parse(Console.ReadLine());

            switch (playerChoice)
            {
                case 1:
                    e.PowerLevel -= 10;
                    break;
                case 2:
                    e.PowerLevel -= 30;
                    break;
                case 3:
                    this.CurrentPower += 15;
                    break;
                default:
                    Console.WriteLine("Invalid Choice!! Lose your round");  
                    break;
            }

            Console.WriteLine("You have reduced {0}'s health to {1}", e.Name, e.PowerLevel);
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

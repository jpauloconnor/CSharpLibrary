using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Game_Official
{
    public class Player : Character
    {

        // Player fields
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

        public string PlayerName { get; set; }
        public int PlayerPower { get; set; }
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


        /// <summary>
        /// METHODS
        /// Choose Character, Choose Weapon, Attack, Defend, Heal, Respawn
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
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


        public void Attack(Creature c)
        {
            Dictionary<string, int> Attacks = new Dictionary<string, int> { { "Heroic Hammer", 10 }, { "Dusty Stick Shot", 20 }, { "Winning Joly", 30 }, { "Esteemed Suplex", 40 } };
            Random rnd = new Random();
            var singleAttack = Attacks.ElementAt(rnd.Next(Attacks.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            int r = rnd.Next(Attacks.Count);
            Console.WriteLine("Here I come!");
            Console.WriteLine("{0} attacks with {1} and gives {2} damage", this.PlayerName, attackName, attackVal);
            c.CreaturePower -= attackVal;
            Console.WriteLine("{0} health is now at {1} health", c.CreatureName, c.CreaturePower);
        }

        public int GetPowerLevel()
        {
            Random rando = new Random();
            int power = rando.Next(1, 100);
            this.PlayerPower = power;
            Console.WriteLine(this.PlayerPower);
            return PlayerPower;
        }

        public void Speak()
        {
            Console.WriteLine("What do you have to say?");
            string text = Console.ReadLine();
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

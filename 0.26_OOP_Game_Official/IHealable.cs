using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Game_Official
{
    public interface IHealable
    {
        void CheckHealth(Player player);
        void GetHealing(Wound wound);
    }
}

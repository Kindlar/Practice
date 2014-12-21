using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZachsCharacterGenerater
{
    class AbilityModifier
    {
        public string Calculate(int totalScore)
        {
            
            int abilityScore;
            int abilityMod;
            abilityScore = totalScore;

            if (abilityScore == 1)
            {
                abilityMod = -5;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 2) || (abilityScore == 3))
            {
                abilityMod = -4;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 4) || (abilityScore == 5))
            {
                abilityMod = -3;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 6) || (abilityScore == 7))
            {
                abilityMod = -2;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 8) || (abilityScore == 9))
            {
                abilityMod = -1;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 10) || (abilityScore == 11))
            {
                abilityMod = 0;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 12) || (abilityScore == 13))
            {
                abilityMod = 1;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 14) || (abilityScore == 15))
            {
                abilityMod = 2;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 16) || (abilityScore == 17))
            {
                abilityMod = 3;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 18) || (abilityScore == 19))
            {
                abilityMod = 4;
                return abilityMod.ToString("n0");
            }
            else if ((abilityScore == 20) || (abilityScore == 21))
            {
                abilityMod = 5;
                return abilityMod.ToString("n0");
            }
            else
            {
                //TODO: work on getting this message to display on the form level with a false statement. 
                abilityMod = 000;
                //MessageBox.Show("You cheated or need to reroll!");
                return abilityMod.ToString("n0");
            }
        }
    }
}

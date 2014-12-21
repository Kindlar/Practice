using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZachsCharacterGenerater
{
    class TotalScore
    {
        public int CalculateTotalScore(string basemod, string racemod, string magicmod)
        {
            int baseModifier;
            int raceModifier;
            int magicModifier;
            int totalScore;

            int.TryParse(basemod, out baseModifier);
            int.TryParse(racemod, out raceModifier);
            int.TryParse(magicmod, out magicModifier);

            return totalScore = (raceModifier + magicModifier + baseModifier);

        }
    }
}

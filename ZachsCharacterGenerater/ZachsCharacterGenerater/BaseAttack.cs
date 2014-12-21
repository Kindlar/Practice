using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZachsCharacterGenerater
{
    public class BaseAttackModifier
    {
        public string [,] baseAttack  ={  {"1","0","0"},
                                       {"2","1","1"},
                                       {"3","2","1"},
                                       {"4","3","2"},
                                       {"5","3","2"},
                                       {"6/1","4","3"},
                                       {"7/2","5","3"},
                                       {"8/3","6/1","4"},
                                       {"9/4","6/1","4"},
                                       {"10/5","7/2","5"},
                                       {"11/6/1","8/3","5"},
                                       {"12/7/2","9/4","6/1"},
                                       {"13/8/3","9/4","6/1"},
                                       {"14/9/4","10/5","7/1"},
                                       {"15/10/5","11/6/1","7/2"},
                                       {"16/11/6/1","12/7/2","8/3"},
                                       {"17/12/7/2","12/7/2","8/3"},
                                       {"18/13/8/3","13/8/3","9/4"},
                                       {"19/14/9/4","14/9/4","9/4"},
                                       {"20/15/10/5","15/10/5","10/5"},
                                     };
        public string getBaseAttack(string level, string classAttack)
        {
            int playerLevel;
            int selectedColumn;
            int selectedRow;
            
            string attack;

            int.TryParse(level, out playerLevel);
                                  
            try
            {
                selectedRow = (playerLevel-1);

                if (classAttack == "Barbarian" || classAttack == "Fighter" || classAttack == "Paladin" || classAttack == "Ranger")
                {
                    selectedColumn = 0;
                }
                else if (classAttack == "Bard" || classAttack == "Cleric" || classAttack == "Druid" || classAttack == "Monk" || classAttack == "Rogue")
                {
                    selectedColumn = 1;
                }
                else if (classAttack == "Sorcerer" || classAttack == "Wizard")
                {
                    selectedColumn = 2;
                }
                else
                {
                    selectedColumn = 0;
                }

                return attack = baseAttack[selectedRow, selectedColumn].ToString();
            }
            catch
            {
                return "Error";
            }
        }
       
    }
}

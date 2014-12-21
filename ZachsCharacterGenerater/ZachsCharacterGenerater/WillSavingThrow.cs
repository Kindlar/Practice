using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZachsCharacterGenerater
{
    public class WillSavingThrow
    {
        public int[,] throwArray = { {0,2},
                                     {0,3},
                                     {1,3},
                                     {1,4},
                                     {1,4},
                                     {2,5},
                                     {2,5},
                                     {2,6},
                                     {3,6},
                                     {3,7},
                                     {3,7},
                                     {4,8},
                                     {4,8},
                                     {4,9},
                                     {5,9},
                                     {5,10},
                                     {5,10},
                                     {6,11},
                                     {6,11},
                                     {6,12}
                                   };

        public string getWill(string playerLevel, string playerClass)
           
        {
            int selectedRow;
            int selectedColumn;
            string will;
            int level;
            int.TryParse(playerLevel, out level);

            try
            {
                selectedRow = level - 1;

                if (playerClass == "Barbarian" || playerClass ==  "Fighter" || playerClass == "Paladin" || playerClass == "Ranger" || playerClass == "Rogue" )
                {
                    selectedColumn = 0;
                }
                else //Bard, Cleric, Druid, Monk, Sorcerer, Wizard
                {
                    selectedColumn = 1;
                }
                return will = throwArray[selectedRow, selectedColumn].ToString();
            }
            catch (Exception)
            {

                return will = "Error";
            }

        }
                                    
    }
}

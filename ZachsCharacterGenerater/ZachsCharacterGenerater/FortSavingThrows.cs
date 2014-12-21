using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZachsCharacterGenerater
{
public class FortSavingThrows
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

        public string getFort(string level, string playerClass)
        { 
            string fort;
            int selectedRow;
            int selectedColumn;
            int playerLevel;
            int.TryParse(level, out playerLevel);

            
            
            try
            {
                selectedRow = (playerLevel-1);

                if (playerClass == "Bard" || playerClass == "Rogue" || playerClass == "Sorcerer" || playerClass == "Wizard")
                {
                    selectedColumn = 0;
                }
                else //Barbarian, Cleric, Druid, Fighter, Monk, Paladin, Ranger, 
                {
                    selectedColumn = 1;
                }
                return fort = throwArray[selectedRow, selectedColumn].ToString();
            }
            catch
            {
                return fort = "Error";

            }

            
        }

    }
}

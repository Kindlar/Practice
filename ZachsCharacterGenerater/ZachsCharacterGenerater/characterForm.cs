using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZachsCharacterGenerater
{
    public partial class characterForm : Form
    {     

        public int strScore;
        public int dexScore;
        public int conScore;
        public int intScore;
        public int wisScore;
        public int chaScore;

        public int strAbilityMod;
        public int dexAbilityMod;
        public int conAbilityMod;
        public int intAblilitMod;
        public int wisAbilityMod;
        public int chaAbilityMod;

        public int reflexTotalSaving;
        public int reflexAbility;

        public int willTotalSaving;
        public int willAbility;

        public int fortTotalSaving;
        public int fortAbility;
        
        public characterForm()
        {
            InitializeComponent();            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This is to close the application
            this.Close();
        }
                  

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears all text boxes
            nameTextBox.Clear();
            strTextBox.Clear();
            dexTextBox.Clear();
            conTextBox.Clear();
            wisTextBox.Clear();
            intTextBox.Clear();
            chaTextBox.Clear();

            strMagicTextBox.Clear();
            dexMagicTextBox.Clear();
            conMagicTextBox.Clear();
            intMagicTextBox.Clear();
            wisMagicTextBox.Clear();
            chaMagicTextBox.Clear();

            initDexModTextBox.Clear();
            initTotalTextBox.Clear();
            initMiscModTextBox.Clear();
            
            //clears all display labels
            strRacialModTextBox.Clear();
            dexRacialModTextBox.Clear();
            conRacialModTextBox.Clear();
            intRacialModTextBox.Clear();
            wisRacialModTextBox.Clear();
            chaRacialModTextBox.Clear();

            strScoreTextBox.Clear();
            dexScoreTextBox.Clear();
            conScoreTextBox.Clear();
            intScoreTextBox.Clear();
            wisScoreTextBox.Clear();
            chaScoreTextBox.Clear();

            strDisplayTextBox.Clear();
            dexDisplayTextBox.Clear();
            conDisplayTextBox.Clear();
            intDisplayTextBox.Clear();
            wisDisplayTextBox.Clear();
            chaDisplayTextBox.Clear();

            reflexAbilityModLabel.Text = "";
            fortAbilityModLabel.Text = "";
            willAbilityModLabel.Text = "";

            reflexClassModLabel.Text = "";
            fortClassModlabel.Text = "";
            willClassModLabel.Text = "";

            reflexTotalSavingLabel.Text = "";
            willTotalSavingLabel.Text = "";
            fortTotalSavingLabel.Text = "";
                     
            //Clears all comboboxes
            raceComboBox.ResetText();
            classComboBox.ResetText();
            alignmentComboBox.ResetText();
            
            nameTextBox.Focus();                        
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculates all 
            AbilityModifier abilityModifier = new AbilityModifier();
            TotalScore TotalScore = new TotalScore();
       
            int initDexMod;
            int initMiscMod;
            int initTotalMod;

            strScore = TotalScore.CalculateTotalScore(strTextBox.Text, strRacialModTextBox.Text, strMagicTextBox.Text);
            strScoreTextBox.Text = strScore.ToString("n0");
            strDisplayTextBox.Text = abilityModifier.Calculate(strScore);
            int.TryParse(strDisplayTextBox.Text, out strAbilityMod);
                        
            dexScore = TotalScore.CalculateTotalScore(dexTextBox.Text, dexRacialModTextBox.Text, dexMagicTextBox.Text);
            dexScoreTextBox.Text = dexScore.ToString("n0");
            dexDisplayTextBox.Text = abilityModifier.Calculate(dexScore);
            int.TryParse(dexDisplayTextBox.Text, out dexAbilityMod);
            reflexAbilityModLabel.Text = dexAbilityMod.ToString("n0");
            initDexModTextBox.Text = dexAbilityMod.ToString("n0");

            conScore = TotalScore.CalculateTotalScore(conTextBox.Text, conRacialModTextBox.Text, conMagicTextBox.Text);
            conScoreTextBox.Text = conScore.ToString("n0");
            conDisplayTextBox.Text = abilityModifier.Calculate(conScore);
            int.TryParse(conDisplayTextBox.Text, out conAbilityMod);
            fortAbilityModLabel.Text = conAbilityMod.ToString("n0");

            intScore = TotalScore.CalculateTotalScore(intTextBox.Text, intRacialModTextBox.Text, intMagicTextBox.Text);
            intScoreTextBox.Text = intScore.ToString("n0");
            intDisplayTextBox.Text = abilityModifier.Calculate(intScore);
            int.TryParse(intDisplayTextBox.Text, out intAblilitMod);

            wisScore = TotalScore.CalculateTotalScore(wisTextBox.Text, wisRacialModTextBox.Text, wisMagicTextBox.Text);
            wisScoreTextBox.Text = wisScore.ToString("n0");
            wisDisplayTextBox.Text = abilityModifier.Calculate(wisScore);
            int.TryParse(wisDisplayTextBox.Text, out wisAbilityMod);
            willAbilityModLabel.Text = wisAbilityMod.ToString("n0");

            chaScore = TotalScore.CalculateTotalScore(chaTextBox.Text, chaRacialModTextBox.Text, chaMagicTextBox.Text);
            chaScoreTextBox.Text = chaScore.ToString("n0");
            chaDisplayTextBox.Text = abilityModifier.Calculate(chaScore);
            int.TryParse(chaDisplayTextBox.Text, out chaAbilityMod);

            {
                int.TryParse(initDexModTextBox.Text, out initDexMod);
                int.TryParse(initMiscModTextBox.Text, out initMiscMod);

                initTotalMod = (initMiscMod + initDexMod);
                initTotalTextBox.Text = initTotalMod.ToString("n0");
            }

        }

        public void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)raceComboBox.SelectedItem;
                                             
            if (selected == "Elf")
            {
                strRacialModTextBox.Text = "0";
                dexRacialModTextBox.Text = "+2";
                conRacialModTextBox.Text = "-2";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "0";
            }
            else if(selected == "Human")
            {
                strRacialModTextBox.Text = "0";
                dexRacialModTextBox.Text = "0";
                conRacialModTextBox.Text = "0";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "0";
            }
            else if (selected == "Dwarf")
            {
                strRacialModTextBox.Text = "0";
                dexRacialModTextBox.Text = "0";
                conRacialModTextBox.Text = "+2";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "-2";
            }
            else if (selected == "Gnome")
            {
                strRacialModTextBox.Text = "-2";
                dexRacialModTextBox.Text = "0";
                conRacialModTextBox.Text = "+2";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "0";
            }
            else if (selected == "Half-Elf")
            {
                strRacialModTextBox.Text = "0";
                dexRacialModTextBox.Text = "0";
                conRacialModTextBox.Text = "0";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "0";
            }
            else if (selected == "Half-Orc")
            {
                strRacialModTextBox.Text = "+2";
                dexRacialModTextBox.Text = "0";
                conRacialModTextBox.Text = "0";
                intRacialModTextBox.Text = "-2";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "-2";
            }
            else if (selected == "Halfing")
            {
                strRacialModTextBox.Text = "-2";
                dexRacialModTextBox.Text = "+2";
                conRacialModTextBox.Text = "0";
                intRacialModTextBox.Text = "0";
                wisRacialModTextBox.Text = "0";
                chaRacialModTextBox.Text = "0";
            }
            else
            {
                strRacialModTextBox.Text = "";
                dexRacialModTextBox.Text = "";
                conRacialModTextBox.Text = "";
                intRacialModTextBox.Text = "";
                wisRacialModTextBox.Text = "";
                chaRacialModTextBox.Text = "";
            }
         }

        private void characterForm_Load(object sender, EventArgs e)
        {

        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
            string selected = (string)classComboBox.SelectedItem;
            string level = (string)levelComboBox.SelectedItem;
            
            FortSavingThrows FortSavingThrow = new FortSavingThrows();
            WillSavingThrow WillSavingThrow = new WillSavingThrow();
            ReflexSavingThrow ReflexSavingThrow = new ReflexSavingThrow();

            if ((selected == "") || (level == ""))
            {
                MessageBox.Show("Please select a class and level");
            }
            else
            {
                fortClassModlabel.Text = FortSavingThrow.getFort(level, selected).ToString();
                reflexClassModLabel.Text = ReflexSavingThrow.getReflex(level, selected);
                willClassModLabel.Text = WillSavingThrow.getWill(level, selected);
            }

        }
        
        private void calculateSavingThrow_Click(object sender, EventArgs e)
        {
                TotalScore TotalScore = new TotalScore();

                reflexAbility = dexAbilityMod;           
                reflexTotalSaving = TotalScore.CalculateTotalScore(reflexClassModLabel.Text, reflexAbilityModLabel.Text, reflexMagicModLabel.Text);
                reflexTotalSavingLabel.Text = reflexTotalSaving.ToString("n0");

                willAbility = wisAbilityMod;
                willTotalSaving = TotalScore.CalculateTotalScore(willClassModLabel.Text, willAbilityModLabel.Text, willMagicModLabel.Text);
                willTotalSavingLabel.Text = willTotalSaving.ToString("n0");

                fortAbility = conAbilityMod;
                fortTotalSaving = TotalScore.CalculateTotalScore(fortClassModlabel.Text, fortAbilityModLabel.Text, fortMagicModLabel.Text);
                fortTotalSavingLabel.Text = fortTotalSaving.ToString("n0");    
        }      

        private void spellButton_Click(object sender, EventArgs e)
        {
            Form SpellForm = new spellForm();
            SpellForm.Show();
        }

        private void featButton_Click(object sender, EventArgs e)
        {
            Form FeatForm = new featForm();
            FeatForm.Show();
        }

        private void skillButton_Click(object sender, EventArgs e)
        {
            Form SkillForm = new skillForm();
            SkillForm.Show();
        }

        private void calculateBaseButton_Click(object sender, EventArgs e)
        {
            BaseAttackModifier baseAttack = new BaseAttackModifier();
            int level;

            string playerLevel = (string)levelComboBox.SelectedItem;
            int.TryParse(playerLevel, out level);
            
            string playerclass = (string)classComboBox.SelectedItem;

            string baseAttackTotal; 
            baseAttackTotal = baseAttack.getBaseAttack(playerLevel,playerclass);
            meleeBaseAttackTextBox.Text = baseAttackTotal;
            rangedBaseAttackTextBox.Text = baseAttackTotal;
        }

        private void equipmentButton_Click(object sender, EventArgs e)
        {

        }

        private void abilityScoreGroupBox_Enter(object sender, EventArgs e)
        {

        }             
    }
}


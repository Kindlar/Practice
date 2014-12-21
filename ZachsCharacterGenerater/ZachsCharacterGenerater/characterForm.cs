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
            strRacialLabel.Text = "";
            dexRacialLabel.Text = "";
            conRacialLabel.Text = "";
            intRacialLabel.Text = "";
            wisRacialLabel.Text = "";
            chaRacialLabel.Text = "";

            strScoreLabel.Text = "";
            dexScoreLabel.Text = "";
            conScoreLabel.Text = "";
            intScoreLabel.Text = "";
            wisScoreLabel.Text = "";
            chaScoreLabel.Text = "";

            strDisplayLabel.Text = "";
            dexDisplayLabel.Text = "";
            conDisplayLabel.Text = "";
            intDisplayLabel.Text = "";
            wisDisplayLabel.Text = "";
            chaDisplayLabel.Text = "";

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

            strScore = TotalScore.CalculateTotalScore(strTextBox.Text, strRacialLabel.Text, strMagicTextBox.Text);
            strScoreLabel.Text = strScore.ToString("n0");
            strDisplayLabel.Text = abilityModifier.Calculate(strScore);
            int.TryParse(strDisplayLabel.Text, out strAbilityMod);
                        
            dexScore = TotalScore.CalculateTotalScore(dexTextBox.Text, dexRacialLabel.Text, dexMagicTextBox.Text);
            dexScoreLabel.Text = dexScore.ToString("n0");
            dexDisplayLabel.Text = abilityModifier.Calculate(dexScore);
            int.TryParse(dexDisplayLabel.Text, out dexAbilityMod);
            reflexAbilityModLabel.Text = dexAbilityMod.ToString("n0");
            initDexModTextBox.Text = dexAbilityMod.ToString("n0");

            conScore = TotalScore.CalculateTotalScore(conTextBox.Text, conRacialLabel.Text, conMagicTextBox.Text);
            conScoreLabel.Text = conScore.ToString("n0");
            conDisplayLabel.Text = abilityModifier.Calculate(conScore);
            int.TryParse(conDisplayLabel.Text, out conAbilityMod);
            fortAbilityModLabel.Text = conAbilityMod.ToString("n0");

            intScore = TotalScore.CalculateTotalScore(intTextBox.Text, intRacialLabel.Text, intMagicTextBox.Text);
            intScoreLabel.Text = intScore.ToString("n0");
            intDisplayLabel.Text = abilityModifier.Calculate(intScore);
            int.TryParse(intDisplayLabel.Text, out intAblilitMod);

            wisScore = TotalScore.CalculateTotalScore(wisTextBox.Text, wisRacialLabel.Text, wisMagicTextBox.Text);
            wisScoreLabel.Text = wisScore.ToString("n0");
            wisDisplayLabel.Text = abilityModifier.Calculate(wisScore);
            int.TryParse(wisDisplayLabel.Text, out wisAbilityMod);
            willAbilityModLabel.Text = wisAbilityMod.ToString("n0");

            chaScore = TotalScore.CalculateTotalScore(chaTextBox.Text, chaRacialLabel.Text, chaMagicTextBox.Text);
            chaScoreLabel.Text = chaScore.ToString("n0");
            chaDisplayLabel.Text = abilityModifier.Calculate(chaScore);
            int.TryParse(chaDisplayLabel.Text, out chaAbilityMod);

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
                strRacialLabel.Text = "0";
                dexRacialLabel.Text = "+2";
                conRacialLabel.Text = "-2";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "0";
            }
            else if(selected == "Human")
            {
                strRacialLabel.Text = "0";
                dexRacialLabel.Text = "0";
                conRacialLabel.Text = "0";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "0";
            }
            else if (selected == "Dwarf")
            {
                strRacialLabel.Text = "0";
                dexRacialLabel.Text = "0";
                conRacialLabel.Text = "+2";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "-2";
            }
            else if (selected == "Gnome")
            {
                strRacialLabel.Text = "-2";
                dexRacialLabel.Text = "0";
                conRacialLabel.Text = "+2";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "0";
            }
            else if (selected == "Half-Elf")
            {
                strRacialLabel.Text = "0";
                dexRacialLabel.Text = "0";
                conRacialLabel.Text = "0";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "0";
            }
            else if (selected == "Half-Orc")
            {
                strRacialLabel.Text = "+2";
                dexRacialLabel.Text = "0";
                conRacialLabel.Text = "0";
                intRacialLabel.Text = "-2";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "-2";
            }
            else if (selected == "Halfing")
            {
                strRacialLabel.Text = "-2";
                dexRacialLabel.Text = "+2";
                conRacialLabel.Text = "0";
                intRacialLabel.Text = "0";
                wisRacialLabel.Text = "0";
                chaRacialLabel.Text = "0";
            }
            else
            {
                strRacialLabel.Text = "";
                dexRacialLabel.Text = "";
                conRacialLabel.Text = "";
                intRacialLabel.Text = "";
                wisRacialLabel.Text = "";
                chaRacialLabel.Text = "";
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

            //if(selected == "Barbarian")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "0";
            //}
            //else if (selected == "Bard")
            //{
            //    //fortClassModlabel.Text = "0";
            //    //reflexClassModLabel.Text = "2";
            //    willClassModLabel.Text = "2";
            //}
            //else if (selected == "Cleric")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "2";
            //}
            //else if (selected == "Druid")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "2";
            //}
            //else if (selected == "Fighter")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "0";
            //}
            //else if (selected == "Monk")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "2";
            //    willClassModLabel.Text = "2";
            //}
            //else if (selected == "Paladin")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "0";
            //    alignmentComboBox.Text = "Lawful Good";
            //}
            //else if (selected == "Ranger")
            //{
            //    fortClassModlabel.Text = "2";
            //    reflexClassModLabel.Text = "2";
            //    willClassModLabel.Text = "0";
            //}
            //else if (selected == "Rogue")
            //{
            //    fortClassModlabel.Text = "0";
            //    reflexClassModLabel.Text = "2";
            //    willClassModLabel.Text = "0";
            //}
            //else if (selected == "Sorcerer")
            //{
            //    fortClassModlabel.Text = "0";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "2";
            //}
            //else if (selected == "Wizard")
            //{
            //    fortClassModlabel.Text = "0";
            //    reflexClassModLabel.Text = "0";
            //    willClassModLabel.Text = "2";
            //}
            //else
            //{
            //    fortClassModlabel.Text = "";
            //    reflexClassModLabel.Text = "";
            //    willClassModLabel.Text = "";
            //}
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
    }
}


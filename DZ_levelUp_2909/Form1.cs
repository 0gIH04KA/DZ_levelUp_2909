using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DZ_levelUp_2909
{
    public partial class Form1 : Form
    {
        UserInterface UI;
        BusinessLogic BL;

        public Form1()
        {
            InitializeComponent();

            this.BL = new BusinessLogic(form: this);
            this.UI = new UserInterface(form: this, businessLogic: BL);
            this.BL.UI = this.UI;

            UI.PrimarySettings();
        }

        private void LanguageRussian_Click(object sender, EventArgs e)
        {
            UI.SettingsLanguageRussian();
        }

        private void ButtonClickRus(object sender, EventArgs e)
        {
            UI.GetButtonClickRus();
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            UI.SettingsLanguageEnglish();
        }

        private void ButtonClickEng(object sender, EventArgs e)
        {
            UI.GetButtonClickEng();
        }

        private void LanguageUkrainian_Click(object sender, EventArgs e)
        {
            UI.SettingsLanguageUkr();
        }

        private void ButtonClickUkr(object sender, EventArgs e)
        {
            UI.GetButtonClickUkr();
        }

        private void clickHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.SettingsSchedule();
            UI.DisabledPass();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UI.SelectDayInSchedule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UI.ToFinishEditing();
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            BL.GetComparisonPassword();
        }

        private void buttonEditPass_Click(object sender, EventArgs e)
        {
            UI.GearCustomization();
        }

        private void buttonСonfirmPass_Click(object sender, EventArgs e)
        {
            BL.ChangePassword();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BL.ChangePath();
        }

        
    }
}

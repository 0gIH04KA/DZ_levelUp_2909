using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace DZ_levelUp_2909
{
    public class UserInterface
    {
        Form1 F1;
        BusinessLogic BL;
         

        public UserInterface(Form1 form)
        {
            this.F1 = form;
            this.BL = new BusinessLogic(form);

        }

        const int POIN_X = 12;
        const int POIN_Y = 27;

        const int WIDTHT = 290;
        const int HEIGHT = 350;

        const int WIDTHT_Schedule = 440;
        const int HEIGHT_Schedule = 500;

        //int CountEditing = 0;



        public void PrimarySettings()
        {
            F1.Width = WIDTHT;
            F1.Height = HEIGHT;

            F1.groupBoxRussian.Visible = true;
            F1.groupBoxEnglish.Visible = false;
            F1.groupBoxUkrainian.Visible = false;
            F1.groupBoxSchedule.Visible = false;
        }

        public void SettingsLanguageRussian()
        {
            F1.Width = WIDTHT;
            F1.Height = HEIGHT;

            F1.groupBoxRussian.Location = new Point(POIN_X, POIN_Y);

            F1.groupBoxRussian.Visible = true;
            F1.groupBoxEnglish.Visible = false;
            F1.groupBoxUkrainian.Visible = false;
            F1.groupBoxSchedule.Visible = false;
        }

        public void GetButtonClickRus()
        {
            string str = F1.screenRus.Text.ToLower();
            F1.ResRus.Text = BL.Print(str);
        }

        public void ClearTextBox()
        {

            if (F1.groupBoxRussian.Visible)
            {
                F1.screenRus.Clear();
            }

            else if (F1.groupBoxEnglish.Visible)
            {
                F1.screenEng.Clear();
            }

            else if (F1.groupBoxUkrainian.Visible)
            {
                F1.screenUkr.Clear();
            }

            else if (F1.groupBoxSchedule.Visible)
            {
                F1.textBoxSchedule.Clear();
            }
        }

        public void SettingsLanguageEnglish()
        {
            F1.Width = WIDTHT;
            F1.Height = HEIGHT;

            F1.groupBoxEnglish.Location = new Point(POIN_X, POIN_Y);

            F1.groupBoxEnglish.Visible = true;
            F1.groupBoxRussian.Visible = false;
            F1.groupBoxUkrainian.Visible = false;
            F1.groupBoxSchedule.Visible = false;
        }

        public void GetButtonClickEng()
        {
            string str = F1.screenEng.Text.ToLower();
            F1.ResEng.Text = BL.Print(str);
        }

        public void SettingsLanguageUkr()
        {
            F1.Width = WIDTHT;
            F1.Height = HEIGHT;

            F1.groupBoxUkrainian.Location = new Point(POIN_X, POIN_Y);

            F1.groupBoxUkrainian.Visible = true;
            F1.groupBoxEnglish.Visible = false;
            F1.groupBoxRussian.Visible = false;
            F1.groupBoxSchedule.Visible = false;
        }

        public void GetButtonClickUkr()
        {
            string str = F1.screenUkr.Text.ToLower();
            F1.ResUkr.Text = BL.Print(str);
        }

        //

        public void SettingsSchedule()
        {
            F1.Width = WIDTHT_Schedule;
            F1.Height = HEIGHT_Schedule;

            F1.groupBoxSchedule.Location = new Point(POIN_X, POIN_Y);

            F1.groupBoxSchedule.Visible = true;
            F1.groupBoxRussian.Visible = false;
            F1.groupBoxEnglish.Visible = false;
            F1.groupBoxUkrainian.Visible = false;

            F1.labelDescription.Text = @"Для выбора дня недели воспользуйтесь Цифрами от 1 до 7
или введите полное название для недели на Английском (=";
        }

        public void SelectDayInSchedule()
        {
            string str = F1.textBoxSchedule.Text.ToLower();

            BL.GetDaySelectionInSchedule(str);

            ClearTextBox();
        }

        public void ToFinishEditing()
        {
            EnabledePass();
            DisabledEditing();
            DisabledSeting();
        }



        public void EnabledeEiting()
        {
            F1.textBoxSchedule.Enabled = true;
            F1.button3.Enabled = true;
            F1.buttonСonfirm.Enabled = true;

            F1.checkBoxMonday.Enabled = true;
            F1.checkBoxTuesday.Enabled = true;
            F1.checkBoxWednesday.Enabled = true;
            F1.checkBoxThursday.Enabled = true;
            F1.checkBoxFriday.Enabled = true;
            F1.checkBoxSaturday.Enabled = true;
            F1.checkBoxSunday.Enabled = true;
        }

        public void DisabledEditing()
        {
            F1.textBoxSchedule.Enabled = false;
            F1.button3.Enabled = false;
            F1.buttonСonfirm.Enabled = false;

            F1.checkBoxMonday.Enabled = false;
            F1.checkBoxTuesday.Enabled = false;
            F1.checkBoxWednesday.Enabled = false;
            F1.checkBoxThursday.Enabled = false;
            F1.checkBoxFriday.Enabled = false;
            F1.checkBoxSaturday.Enabled = false;
            F1.checkBoxSunday.Enabled = false;
        }

        public void EnabledePass()
        {
            F1.labelPassword.Visible = true;
            F1.buttonPassword.Visible = true;
            F1.textBoxPassword.Visible = true;
        }

        public void DisabledPass()
        {
            F1.labelCheckPass.Text = "";
            F1.labelPassword.Visible = false;
            F1.buttonPassword.Visible = false;
            F1.textBoxPassword.Visible = false;

            F1.textBoxEditPass.Visible = false;
            F1.buttonСonfirmPass.Visible = false;
            F1.buttonСonfirmPath.Visible = false;
            F1.labelEditPass.Visible = false;
            
            //CountEditing = 0;
        }

        public void EnabledeSeting()
        {
            F1.buttonСonfirmPass.Enabled = true;
            F1.buttonСonfirmPath.Enabled = true;
            F1.textBoxEditPass.Enabled = true;
        }

        public void DisabledSeting()
        {
            F1.buttonСonfirmPass.Enabled = false;
            F1.buttonСonfirmPath.Enabled = false;
            F1.textBoxEditPass.Enabled = false;
        }





    }
}

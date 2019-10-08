using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_levelUp_2909
{
    class BusinessLogic
    {
        Form1 F1;
        UserInterface UI;

        public BusinessLogic(Form1 form)
        {
            this.F1 = form;
            UI = new UserInterface(form);
        }


        DeysOfWeekRus weekRus = DeysOfWeekRus.ничего;
        DeysOfWeeKEng weekEng = DeysOfWeeKEng.notSelect;
        DeysOfWeeKUkr weekUkr = DeysOfWeeKUkr.нічого;

        ScheduleDeysOfWeeK week = new ScheduleDeysOfWeeK();

        
        string path = @"C:\Users\Vitaliy\Desktop";

        string pathMask = @"\mask.txt";
        string pathPass = @"\passwordEncrypt.txt";

        string Pass = "Пароль";
        int maskEncryption = 1;

       


        public string Print(string str)
        {
            if (F1.groupBoxRussian.Visible)
            {
                UI.ClearTextBox();
                
                string strResultRus = GetDaySelectionRus(str);

                return strResultRus;
            }

            else if (F1.groupBoxEnglish.Visible)
            {
                UI.ClearTextBox();

                string strResultEng = GetDaySelectionEng(str);

                return strResultEng;
            }

            else if (F1.groupBoxUkrainian.Visible)
            {
                UI.ClearTextBox();

                string strResultUkr = GetDaySelectionUkr(str);
                
                return strResultUkr;
            }

            return string.Empty;
        }

        public string GetDaySelectionUkr(string str)
        {
            string strResultUkr = string.Empty;

            Enum.TryParse(str, out weekUkr);

            switch (weekUkr)
            {
                case DeysOfWeeKUkr.нічого:
                    strResultUkr = "Нічого";
                    break;

                case DeysOfWeeKUkr.понеділок:
                    strResultUkr = "Понеділок";
                    break;

                case DeysOfWeeKUkr.вівторок:
                    strResultUkr = "Вівторок";
                    break;

                case DeysOfWeeKUkr.середа:
                    strResultUkr = "Середа";
                    break;

                case DeysOfWeeKUkr.четверг:
                    strResultUkr = "Четверг";
                    break;

                case DeysOfWeeKUkr.пятниця:
                    strResultUkr = "П'ятниця";
                    break;

                case DeysOfWeeKUkr.субота:
                    strResultUkr = "Субота";
                    break;

                case DeysOfWeeKUkr.неділя:
                    strResultUkr = "Неділя";
                    break;

                default:
                    strResultUkr = "Введіть правильно";
                    break;
            }

            return strResultUkr;
        }

        public string GetDaySelectionEng(string str)
        {
            string strResultEng = string.Empty;

            Enum.TryParse(str, out weekEng);

            switch (weekEng)
            {
                case DeysOfWeeKEng.notSelect:
                    strResultEng = "NotSelect";
                    break;

                case DeysOfWeeKEng.monday:
                    strResultEng = "Monday";
                    break;

                case DeysOfWeeKEng.tuesday:
                    strResultEng = "Tuesday";
                    break;

                case DeysOfWeeKEng.wednesday:
                    strResultEng = "Wednesday";
                    break;

                case DeysOfWeeKEng.thursday:
                    strResultEng = "Thursday";
                    break;

                case DeysOfWeeKEng.friday:
                    strResultEng = "Friday";
                    break;

                case DeysOfWeeKEng.saturday:
                    strResultEng = "Saturday";
                    break;

                case DeysOfWeeKEng.sunday:
                    strResultEng = "Sunday";
                    break;

                default:
                    strResultEng = "Enter correctly";
                    break;
            }

            return strResultEng;
        }

        public string GetDaySelectionRus(string str)
        {
            string strResultRus = string.Empty;

            Enum.TryParse(str, out weekRus);

            switch (weekRus)
            {
                case DeysOfWeekRus.ничего:
                    strResultRus = "Ничего";
                    break;

                case DeysOfWeekRus.понедельник:
                    strResultRus = "Понедельник";
                    break;

                case DeysOfWeekRus.вторник:
                    strResultRus = "Вторник";
                    break;

                case DeysOfWeekRus.среда:
                    strResultRus = "Среда";
                    break;

                case DeysOfWeekRus.четверг:
                    strResultRus = "Четверг";
                    break;

                case DeysOfWeekRus.пятница:
                    strResultRus = "Пятница";
                    break;

                case DeysOfWeekRus.суббота:
                    strResultRus = "Суббота";
                    break;

                case DeysOfWeekRus.воскресенье:
                    strResultRus = "Воскресенье";
                    break;

                default:
                    strResultRus = "Введите корректно";
                    break;
            }

            return strResultRus;
        }

        public void GetDaySelectionInSchedule(string str)
        {
            Enum.TryParse(str, out week);

            switch (week)
            {
                case ScheduleDeysOfWeeK.monday:
                    if (!F1.checkBoxMonday.Checked)
                    {
                        F1.checkBoxMonday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxMonday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.tuesday:
                    if (!F1.checkBoxTuesday.Checked)
                    {
                        F1.checkBoxTuesday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxTuesday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.wednesday:
                    if (!F1.checkBoxWednesday.Checked)
                    {
                        F1.checkBoxWednesday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxWednesday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.thursday:
                    if (!F1.checkBoxThursday.Checked)
                    {
                        F1.checkBoxThursday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxThursday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.friday:
                    if (!F1.checkBoxFriday.Checked)
                    {
                        F1.checkBoxFriday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxFriday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.saturday:
                    if (!F1.checkBoxSaturday.Checked)
                    {
                        F1.checkBoxSaturday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxSaturday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.sunday:
                    if (!F1.checkBoxSunday.Checked)
                    {
                        F1.checkBoxSunday.Checked = true;
                    }
                    else
                    {
                        F1.checkBoxSunday.Checked = false;
                    }
                    break;
            }
        }

        public void PasswordEncrypt()
        {
            if (!File.Exists(path + pathPass))
            {

                if (!File.Exists(path + pathMask))
                {

                    CreateFile(path, pathMask, Convert.ToString(maskEncryption));
                }

                int mask = int.Parse(OpenFile(path, pathMask));
                string destination = EncryptionPassword(mask, Pass);

                CreateFile(path, pathPass, destination);

            }
        }

        public string OpenFile(string path, string type)
        {
            FileStream file1 = new FileStream(path + type, FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
            string recording = reader.ReadToEnd(); //считываем все данные с потока
            reader.Close(); //закрываем поток

            return recording;
        }

        public void CreateFile(string path, string type, string writeToFile)
        {
            FileStream file = new FileStream(path + type, FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.Write(writeToFile); //записываем в файл
            writer.Close();
        }

        public string EncryptionPassword(int mask,  string Pass)
        {
            int maskk = Convert.ToInt32(mask);

            string destination = "";

            for (int i = 0; i < Pass.Length; i++)
            {
                char ch_ = (char)(Pass[i] ^ maskk);

                destination += ch_;
            }

            return destination;
        }

    }
}

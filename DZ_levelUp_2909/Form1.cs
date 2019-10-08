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




// 096 536 17 93 елена васил

namespace DZ_levelUp_2909
{
    public partial class Form1 : Form
    {
        UserInterface UI = new UserInterface();
        BusinessLogic BL = new BusinessLogic();     




        const int POIN_X = 12;
        const int POIN_Y = 27;

        const int WIDTHT = 290;
        const int HEIGHT = 350;

        const int WIDTHT_Schedule = 440;
        const int HEIGHT_Schedule = 500;

        const int DEFAULT_MASK = 1;

        string path = @"C:\Users\Vitaliy\Desktop";
        string Pass = "Пароль";
        int CountEditing = 0;

        DeysOfWeekRus weekRus = DeysOfWeekRus.Ничего;
        DeysOfWeeKEng weekEng = DeysOfWeeKEng.NotSelect;
        DeysOfWeeKUkr weekUkr = DeysOfWeeKUkr.Нічого;
        ScheduleDeysOfWeeK week = new ScheduleDeysOfWeeK();

        public Form1()
        {
            InitializeComponent();

            //this.Width = WIDTHT;
            //this.Height = HEIGHT;

            UI.PrimarySettings();
            
        }

        private void LanguageRussian_Click(object sender, EventArgs e)
        {
            this.Width = WIDTHT;
            this.Height = HEIGHT;

            groupBoxRussian.Location = new Point(POIN_X, POIN_Y);

            groupBoxRussian.Visible = true;
            groupBoxEnglish.Visible = false;
            groupBoxUkrainian.Visible = false;
            groupBoxSchedule.Visible = false;
            

        }

        private void ButtonClickRus(object sender, EventArgs e)
        {
            string str = screenRus.Text;
            ResRus.Text = Print(str);
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            this.Width = WIDTHT;
            this.Height = HEIGHT;

            groupBoxEnglish.Location = new Point(POIN_X, POIN_Y);

            groupBoxEnglish.Visible = true;
            groupBoxRussian.Visible = false;
            groupBoxUkrainian.Visible = false;
            groupBoxSchedule.Visible = false;
        }

        private void ButtonClickEng(object sender, EventArgs e)
        {
            string str = screenEng.Text;
            ResEng.Text = Print(str);
        }

        private void LanguageUkrainian_Click(object sender, EventArgs e)
        {
            this.Width = WIDTHT;
            this.Height = HEIGHT;

            groupBoxUkrainian.Location = new Point(POIN_X, POIN_Y);

            groupBoxUkrainian.Visible = true;
            groupBoxEnglish.Visible = false;
            groupBoxRussian.Visible = false;
            groupBoxSchedule.Visible = false;
        }

        private void ButtonClickUkr(object sender, EventArgs e)
        {
            string str = screenUkr.Text;
            ResUkr.Text = Print(str);
        }

        public string Print(string str)
        {

            if (groupBoxRussian.Visible)
            {
                string strResultRus = string.Empty;

                Enum.TryParse(str, out weekRus);

                switch (weekRus)
                {
                    case DeysOfWeekRus.Ничего:
                        strResultRus = "Ничего";
                        break;

                    case DeysOfWeekRus.Понедельник:
                        strResultRus = "Понедельник";
                        break;

                    case DeysOfWeekRus.Вторник:
                        strResultRus = "Вторник";
                        break;

                    case DeysOfWeekRus.Среда:
                        strResultRus = "Среда";
                        break;

                    case DeysOfWeekRus.Четверг:
                        strResultRus = "Четверг";
                        break;

                    case DeysOfWeekRus.Пятница:
                        strResultRus = "Пятница";
                        break;

                    case DeysOfWeekRus.Суббота:
                        strResultRus = "Суббота";
                        break;

                    case DeysOfWeekRus.Воскресенье:
                        strResultRus = "Воскресенье";
                        break;

                    default:
                        strResultRus = "Введите корректно";
                        break;
                }

                screenRus.Clear();

                return strResultRus;
            }

            else if (groupBoxEnglish.Visible) // == true
            {
                string strResultEng = string.Empty;

                Enum.TryParse(str, out weekEng);

                switch (weekEng)
                {
                    case DeysOfWeeKEng.NotSelect:
                        strResultEng = "NotSelect";
                        break;

                    case DeysOfWeeKEng.Monday:
                        strResultEng = "Monday";
                        break;

                    case DeysOfWeeKEng.Tuesday:
                        strResultEng = "Tuesday";
                        break;

                    case DeysOfWeeKEng.Wednesday:
                        strResultEng = "Wednesday";
                        break;

                    case DeysOfWeeKEng.Thursday:
                        strResultEng = "Thursday";
                        break;

                    case DeysOfWeeKEng.Friday:
                        strResultEng = "Friday";
                        break;

                    case DeysOfWeeKEng.Saturday:
                        strResultEng = "Saturday";
                        break;

                    case DeysOfWeeKEng.Sunday:
                        strResultEng = "Sunday";
                        break;

                    default:
                        strResultEng = "Enter correctly";
                        break;
                }
                screenEng.Clear();

                return strResultEng;
            }

            else if (groupBoxUkrainian.Visible)
            {
                string strResultUkr = string.Empty;

                Enum.TryParse(str, out weekUkr);

                switch (weekUkr)
                {
                    case DeysOfWeeKUkr.Нічого:
                        strResultUkr = "Нічого";
                        break;

                    case DeysOfWeeKUkr.Понеділок:
                        strResultUkr = "Понеділок";
                        break;

                    case DeysOfWeeKUkr.Вівторок:
                        strResultUkr = "Вівторок";
                        break;

                    case DeysOfWeeKUkr.Середа:
                        strResultUkr = "Середа";
                        break;

                    case DeysOfWeeKUkr.Четверг:
                        strResultUkr = "Четверг";
                        break;

                    case DeysOfWeeKUkr.Пятниця:
                        strResultUkr = "П'ятниця";
                        break;

                    case DeysOfWeeKUkr.Субота:
                        strResultUkr = "Субота";
                        break;

                    case DeysOfWeeKUkr.Неділя:
                        strResultUkr = "Неділя";
                        break;

                    default:
                        strResultUkr = "Введіть правильно";
                        break;
                }
                screenUkr.Clear();

                return strResultUkr;
            }

            return string.Empty;
        }

        private void clickHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = WIDTHT_Schedule;
            this.Height = HEIGHT_Schedule;

            groupBoxSchedule.Location = new Point(POIN_X, POIN_Y);

            groupBoxSchedule.Visible = true;
            groupBoxRussian.Visible = false;
            groupBoxEnglish.Visible = false;
            groupBoxUkrainian.Visible = false;

            DisabledPass();
            labelDescription.Text = @"Для выбора дня недели воспользуйтесь Цифрами от 1 до 7
или введите полное название для недели на Английском (=";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBoxSchedule.Text.ToLower();

            Enum.TryParse(str, out week);

            switch (week)
            {
                case ScheduleDeysOfWeeK.monday:
                    if (!checkBoxMonday.Checked)
                    {
                        checkBoxMonday.Checked = true;
                    }
                    else
                    {
                        checkBoxMonday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.tuesday:
                    if (!checkBoxTuesday.Checked)
                    {
                        checkBoxTuesday.Checked = true;
                    }
                    else
                    {
                        checkBoxTuesday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.wednesday:
                    if (!checkBoxWednesday.Checked)
                    {
                        checkBoxWednesday.Checked = true;
                    }
                    else
                    {
                        checkBoxWednesday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.thursday:
                    if (!checkBoxThursday.Checked)
                    {
                        checkBoxThursday.Checked = true;
                    }
                    else
                    {
                        checkBoxThursday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.friday:
                    if (!checkBoxFriday.Checked)
                    {
                        checkBoxFriday.Checked = true;
                    }
                    else
                    {
                        checkBoxFriday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.saturday:
                    if (!checkBoxSaturday.Checked)
                    {
                        checkBoxSaturday.Checked = true;
                    }
                    else
                    {
                        checkBoxSaturday.Checked = false;
                    }
                    break;

                case ScheduleDeysOfWeeK.sunday:
                    if (!checkBoxSunday.Checked)
                    {
                        checkBoxSunday.Checked = true;
                    }
                    else
                    {
                        checkBoxSunday.Checked = false;
                    }
                    break;

                default:
                    break;
            }
            textBoxSchedule.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnabledePass();
            DisabledEditing();
            buttonСonfirmPass.Enabled = false;
            buttonСonfirmPath.Enabled = false;
            textBoxEditPass.Enabled = false;
        }

        void EnabledePass()
        {
            labelPassword.Visible = true;
            buttonPassword.Visible = true;
            textBoxPassword.Visible = true;
        }

        void DisabledPass()
        {
            labelCheckPass.Text = "";
            labelPassword.Visible = false;
            buttonPassword.Visible = false;
            textBoxPassword.Visible = false;

            textBoxEditPass.Visible = false;
            buttonСonfirmPass.Visible = false;
            buttonСonfirmPath.Visible = false;
            labelEditPass.Visible = false;
            CountEditing = 0;
        }

        void EnabledeEiting()
        {
            textBoxSchedule.Enabled = true;
            button3.Enabled = true;
            buttonСonfirm.Enabled = true;

            checkBoxMonday.Enabled = true;
            checkBoxTuesday.Enabled = true;
            checkBoxWednesday.Enabled = true;
            checkBoxThursday.Enabled = true;
            checkBoxFriday.Enabled = true;
            checkBoxSaturday.Enabled = true;
            checkBoxSunday.Enabled = true;
        }

        void DisabledEditing()
        {
            textBoxSchedule.Enabled = false;
            button3.Enabled = false;
            buttonСonfirm.Enabled = false;

            checkBoxMonday.Enabled = false;
            checkBoxTuesday.Enabled = false;
            checkBoxWednesday.Enabled = false;
            checkBoxThursday.Enabled = false;
            checkBoxFriday.Enabled = false;
            checkBoxSaturday.Enabled = false;
            checkBoxSunday.Enabled = false;
        }

        void PasswordEncrypt(string path, string Pass)   // создание файла пароля
        {
            if (!File.Exists(path + @"\passwordEncrypt.txt"))
            {

                if (!File.Exists(path + @"\mask.txt"))
                {
                    FileStream file = new FileStream(path + @"\mask.txt", FileMode.Create); //создаем файловый поток
                    StreamWriter writerMask = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
                    writerMask.Write(DEFAULT_MASK); //записываем в файл
                    writerMask.Close();
                }

                FileStream file1 = new FileStream(path + @"\mask.txt", FileMode.Open); //создаем файловый поток
                StreamReader readerMask = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
                string mask = readerMask.ReadToEnd(); //считываем все данные с потока
                readerMask.Close(); //закрываем поток
                int maskk = Convert.ToInt32(mask);

                string destination = "";

                for (int i = 0; i < Pass.Length; i++)
                {
                    char ch_ = (char)(Pass[i] ^ maskk);

                    destination += ch_;
                }

                FileStream file2 = new FileStream(path + @"\passwordEncrypt.txt", FileMode.Create); //создаем файловый поток
                StreamWriter writerPasswordEncrypt = new StreamWriter(file2); //создаем «потоковый писатель» и связываем его с файловым потоком
                writerPasswordEncrypt.Write($"{destination}"); //записываем в файл
                writerPasswordEncrypt.Close();
            }
        }

        string PasswordEnc(string path) // чтение файла
        {
            FileStream file = new FileStream(path + @"\passwordEncrypt.txt", FileMode.Open); //создаем файловый поток
            StreamReader readerPass = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком
            string Pass = readerPass.ReadToEnd(); //считываем все данные с потока
            readerPass.Close(); //закрываем поток

            return Pass;
        }

        string UsserEncrypt(string path) //шифрование пароля от пользователя
        {
            string usserPass = textBoxPassword.Text;

            FileStream file = new FileStream(path + @"\mask.txt", FileMode.Open); //создаем файловый поток
            StreamReader readerMask = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком
            string mask = readerMask.ReadToEnd(); //считываем все данные с потока и выводим на экран
            readerMask.Close(); //закрываем поток

            int maskk = Convert.ToInt32(mask);

            string destination = "";

            for (int i = 0; i < usserPass.Length; i++)
            {
                char ch_ = (char)(usserPass[i] ^ maskk);

                destination += ch_;
            }

            return destination;
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            PasswordEncrypt(path, Pass);

            string passwordEncod = PasswordEnc(path);
            string usserEncod = UsserEncrypt(path);

            textBoxPassword.Clear();

            if (passwordEncod == usserEncod)
            {
                labelCheckPass.Text = "Пароль введен верно продолжайте редактирование";
                EnabledeEiting();
                DisabledPass();
            }
            else
            {
                labelCheckPass.Text = "Пароль введен НЕ верно!";
            }
        }

        private void buttonEditPass_Click(object sender, EventArgs e)
        {
            if ((CountEditing%2) == 0)
            {
                textBoxEditPass.Visible = true;
                buttonСonfirmPass.Visible = true;
                buttonСonfirmPath.Visible = true;

                if (textBoxPassword.Visible)
                {
                    buttonСonfirmPass.Enabled = false;
                    buttonСonfirmPath.Enabled = false;
                    textBoxEditPass.Enabled = false;
                }
                else
                {
                    buttonСonfirmPass.Enabled = true;
                    buttonСonfirmPath.Enabled = true;
                    textBoxEditPass.Enabled = true;
                }
                
                labelEditPass.Visible = true;
                labelEditPass.Text = "Введите новый пароль или путь";
                CountEditing++;
            }
            else
            {
                textBoxEditPass.Visible = false;
                buttonСonfirmPass.Visible = false;
                buttonСonfirmPath.Visible = false;
                labelEditPass.Visible = false;
                CountEditing--;
            }
        }

        private void buttonСonfirmPass_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + @"\passwordEncrypt.txt"))
            {
                File.Delete(path + @"\passwordEncrypt.txt");
                Pass = textBoxEditPass.Text;
                textBoxEditPass.Clear();
                labelEditPass.Text = "Пароль успешно изменен";
            }
            else
            {
                Pass = textBoxEditPass.Text;
                textBoxEditPass.Clear();
                labelEditPass.Text = "Пароль успешно изменен";
            }


            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!(textBoxEditPass.Text == ""))
            {
                path = string.Empty;

                path = @"" + textBoxEditPass.Text;
                textBoxEditPass.Clear();
                labelEditPass.Text = "Путь успешно изменен";
            }
            else
            {
                labelEditPass.Text = "Укажите путь! ";
            }
        }
    }
}

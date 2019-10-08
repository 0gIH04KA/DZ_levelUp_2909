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

        const int DEFAULT_MASK = 1;
        string path = @"C:\Users\Vitaliy\Desktop";
        string Pass = "Пароль";
        int CountEditing = 0;


        public Form1()
        {
            InitializeComponent();

            this.UI = new UserInterface(form: this);
            this.BL = new BusinessLogic(form: this);

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
            BL.PasswordEncrypt();
            //if (!File.Exists(path + @"\passwordEncrypt.txt"))
            //{

            //    if (!File.Exists(path + @"\mask.txt"))
            //    {
            //        FileStream file = new FileStream(path + @"\mask.txt", FileMode.Create); //создаем файловый поток
            //        StreamWriter writerMask = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
            //        writerMask.Write(DEFAULT_MASK); //записываем в файл
            //        writerMask.Close();
            //    }

            //    FileStream file1 = new FileStream(path + @"\mask.txt", FileMode.Open); //создаем файловый поток
            //    StreamReader readerMask = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
            //    string mask = readerMask.ReadToEnd(); //считываем все данные с потока
            //    readerMask.Close(); //закрываем поток

            //    int maskk = Convert.ToInt32(mask);

            //    string destination = "";

            //    for (int i = 0; i < Pass.Length; i++)
            //    {
            //        char ch_ = (char)(Pass[i] ^ maskk);

            //        destination += ch_;
            //    }

            //    FileStream file2 = new FileStream(path + @"\passwordEncrypt.txt", FileMode.Create); //создаем файловый поток
            //    StreamWriter writerPasswordEncrypt = new StreamWriter(file2); //создаем «потоковый писатель» и связываем его с файловым потоком
            //    writerPasswordEncrypt.Write($"{destination}"); //записываем в файл
            //    writerPasswordEncrypt.Close();
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

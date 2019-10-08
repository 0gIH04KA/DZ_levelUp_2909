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
        Form1 F1 = new Form1();
         //public static  Form1 F1 { get => F1; set => F1 = value; }


        const int POIN_X = 12;
        const int POIN_Y = 27;

        const int WIDTHT = 290;
        const int HEIGHT = 350;

       

        public void PrimarySettings()
        {
            F1.Width = WIDTHT;
            F1.Height = HEIGHT;

            F1.groupBoxRussian.Visible = true;
            F1.groupBoxEnglish.Visible = false;
            F1.groupBoxUkrainian.Visible = false;
            F1.groupBoxSchedule.Visible = false;
        }
    }
}

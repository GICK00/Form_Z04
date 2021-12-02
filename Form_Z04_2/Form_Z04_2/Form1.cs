using System;
using System.Media;
using System.Windows.Forms;

namespace Form_Z04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string str;
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);

                if (number > 0)
                {
                    dvoich(number);
                    textBoxResult.Text = "Число в 2 системе: " + revString(str);
                }
                else
                {
                    textBoxResult.Text = "Число должно быть > 0!";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
            str = "";
        }
        static void dvoich(int i)
        {
            if (i > 0)
            {
                if (i % 2 == 1)
                    str += "1";
                else
                    str += "0";
                dvoich(i / 2);
            }
        }
        static string revString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        // Do not include if not ZXC!
        private void checkBoxKeK_CheckedChanged(object sender, EventArgs e)
        {
            var soundPlayer = new SoundPlayer(@"C:\Users\Dmitryi Gick\source\repos\Form_Z04_2\zxc.wav");
            if (checkBoxKeK.Checked == true)
            {
                pictureBoxZXC.Visible = true;
                pictureBoxZXC1.Visible = true;
                textBoxZXC.Visible = true;
                soundPlayer.Play();

                int i = 1000;
                while (i > 0)
                {
                    textBoxZXC.Text = textBoxZXC.Text + i.ToString() + "-7\r\n ";
                    i = i - 7;
                }
                textBoxResult.Text = "Поздравляю! Вы стали Дед Инсайдом!";
            }
            else
            {
                textBoxZXC.Visible = false;
                pictureBoxZXC.Visible = false;
                pictureBoxZXC1.Visible = false;
                soundPlayer.Stop();
            }
        }
    }
}
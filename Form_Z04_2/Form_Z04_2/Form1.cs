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
    }
}
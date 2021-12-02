using System;
using System.Windows.Forms;

namespace Form_Z04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN.Text);

                if (n > 0)
                {
                    double result = n / rec(n - 1, n);
                    textBoxResult.Text = "Ответ:" + result.ToString();
                }
                else
                {
                    textBoxResult.Text = "N не может быть меньше 0!";
                }
            }
             catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }   
        }
        static double rec(int a, int n)
        {
            if (a == 0)
                return Math.Sqrt(n);
            else
                return Math.Sqrt((n - a) + rec(a - 1, n));
        }
    }
}

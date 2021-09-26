using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ7._2
    //Губарь Артём
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
            check.Enabled = string.IsNullOrEmpty(input.Text) ? false : true;
            Random rnd = new Random();
            n = rnd.Next(1, 101);
        }
        

        private void check_Click(object sender, EventArgs e)
        {
           

            if (int.TryParse(input.Text, out int number)) 
            {
               
                if (int.Parse(input.Text) > 100 || int.Parse(input.Text) < 1)
                {
                    MessageBox.Show($"Вы ввели некорректное число", "Проверка числа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.Parse(input.Text) > n)
                    {
                        MessageBox.Show($"Ваше число больше загаданного", "Проверка числа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (int.Parse(input.Text) < n)
                    {
                        MessageBox.Show($"Ваше число меньше загаданного", "Проверка числа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (int.Parse(input.Text) == n)
                    {
                        MessageBox.Show("Вы угадали число!!!", "Проверка числа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            else MessageBox.Show("Вы ввели некорректное число", "Проверка числа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            check.Enabled = string.IsNullOrEmpty(input.Text) ? false : true;
        }
    }
}

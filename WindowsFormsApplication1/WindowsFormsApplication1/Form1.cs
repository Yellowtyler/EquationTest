using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Begin_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains("0") || textBox1.Text.Contains("1") || textBox1.Text.Contains("2") || textBox1.Text.Contains("3") || textBox1.Text.Contains("4") || textBox1.Text.Contains("5") || textBox1.Text.Contains("6") || textBox1.Text.Contains("7") || textBox1.Text.Contains("8") || textBox1.Text.Contains("9"))
            {
                string str = textBox1.Text;
                int num = Convert.ToInt32(textBox1.Text);
                string path = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//questions.txt";
                string path2 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//answx.txt";
                string path3 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//youransw.txt";
                StreamWriter f2 = new System.IO.StreamWriter(path2, false);
                f2.Close();
                StreamWriter f3 = new System.IO.StreamWriter(path3, false);
                f3.Close();
                using (StreamWriter f = new System.IO.StreamWriter(path, false))
                {
                    f.WriteLine(str);

                }
                if (num <= 0)
                {
                    var result = MessageBox.Show("Количество вопросов не может быть равно или меньше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Prog a = new Prog();
                    a.Show();
                }

            }
            else
            {
                var result = MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

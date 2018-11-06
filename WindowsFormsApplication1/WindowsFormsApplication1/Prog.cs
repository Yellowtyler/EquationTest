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
    
    public partial class Prog : Form
    {
        public Prog()
        {
            InitializeComponent();
            
        }
       
        Random rand = new Random();
        int x1 = 0;
        int x2 = 0;
        private void Prog_Load(object sender, EventArgs e)
        {
            int choice = rand.Next(0, 5);
            if (choice <4)
            {
                x1 = rand.Next(-30, 30);
                x2 = rand.Next(-30, 30);
                int a = rand.Next(1, 2);
                float b = (x1 + x2) * (-a);
                float c = x1 * x2 * a;
                string a1 = a.ToString();
                string b1 = b.ToString();
                string c1 = c.ToString();
                if (b1.Contains("-") && !c1.Contains("-"))
                {
                    textBox1.Text = a1 + "*x^2" + b1 + "*x+" + c1;
                }
                else if (c1.Contains("-") && !b1.Contains("-"))
                {
                    textBox1.Text = a1 + "*x^2+" + b1 + "*x" + c1;
                }
                else if (c1.Contains("-") && b1.Contains("-"))
                {
                    textBox1.Text = a1 + "*x^2" + b1 + "*x" + c1;
                }
                else
                {
                    textBox1.Text = a1 + "*x^2+" + b1 + "*x+" + c1;
                }
            }
            else
            {
                x1 = rand.Next(1, 3);
                x2 = rand.Next(1, 4);
             int xp1 = x1*x1;
            int xp2 = x2*x2;
               int b2 = -(xp1 + xp2) ;
               int c2 = xp1 * xp2;
                string b3 = b2.ToString();
                string c3 = c2.ToString();
                if (b3.Contains("-") && !c3.Contains("-"))
                {
                    textBox1.Text = "x^4" + b3 + "*x^2+" + c3;
                }
                else if (c3.Contains("-") && !b3.Contains("-"))
                {
                    textBox1.Text = "x^4+" + b3 + "*x^2" + c3;
                }
                else if (c3.Contains("-") && b3.Contains("-"))
                {
                    textBox1.Text = "x^4" + b3 + "*x^2" + c3;
                }
                else
                {
                    textBox1.Text = "x^4+" + b3 + "*x^2+" + c3;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            string str1;
            string str2;
            int con=0;
            string path = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//questions.txt";
            string path2 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//answx.txt";
            string path3 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//youransw.txt";
            str1 = x1.ToString() + " " + x2.ToString();
            str2 = textBox2.Text + " " + textBox3.Text;
            using (StreamWriter f = File.AppendText(path2))
            {
                f.WriteLine(str1);
                f.Close();
            }
            using (StreamWriter f = File.AppendText(path3))
            {
                f.WriteLine(str2);
                f.Close();
            }
            if (textBox2.Text ==null)
            {
                var res = MessageBox.Show("Вы не ввели данные.","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
               
                int res1 = Convert.ToInt32(textBox2.Text);
                    int res2 = Convert.ToInt32(textBox3.Text);
                    using (StreamReader f = File.OpenText(path))
                    {
                        str = f.ReadLine();
                        con = Int16.Parse(str);
                        f.Close();

                    }
                    var res = MessageBox.Show("Хотите продолжить?", "Ответ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(res ==DialogResult.Yes)
                    {
                      
                      
                        con--;
                        str = con.ToString();
                        using (StreamWriter f = new System.IO.StreamWriter(path, false))
                        {
                            f.WriteLine(str);
                            f.Close();
                        }
                        if (con >= 1)
                        {
                            Prog b = new Prog();
                            b.Show();
                        this.Hide();
                        }
                        else
                        {
                            Res a = new Res();
                            a.Show();
                        this.Hide();
                    }
                    }
                    else
                    {
                      
                            Res a = new Res();
                            a.Show();
                        
                        this.Hide();
                    }

                
              
            }
        }
    }
}

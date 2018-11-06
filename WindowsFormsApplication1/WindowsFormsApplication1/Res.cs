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
    public partial class Res : Form
    {
        public Res()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Res_Load(object sender, EventArgs e)
        {
            string path2 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//answx.txt";
            string path3 = "C://Users//User//Documents//Visual Studio 2015//Projects//WindowsFormsApplication1//youransw.txt";
            using (StreamReader f = File.OpenText(path2))
            {
               
                while (f.EndOfStream == false)
                {
                   
                   dataGridView1.Rows.Add();
                    dataGridView1.Rows[count].Cells[0].Value = f.ReadLine();
                    count++;
                   
                }
                f.Close();
            }
            using (StreamReader f = File.OpenText(path3))
            {
                int i = 0;
                while (f.EndOfStream == false)
                {
                      
                        dataGridView1.Rows[i].Cells[1].Value = f.ReadLine();
                    i++;
                  
                }
                f.Close();
            }
           
            int rightan = 0;
           for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                string[] split = dataGridView1.Rows[i].Cells[1].Value.ToString().Split(new char[] { ' ', '\0' });
                string ls = split[1] + " " + split[0];
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString() || ls == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    rightan++;
                }
                
            }
            textBox1.Text = "Вы решили правильно " + rightan.ToString() + " из " + count.ToString() + " уравнений.";
        }
    }
}

using Practice1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Створення об'єкту класу табулювання
            Tabul tabul = new Tabul();

            double xn, xk, h, a;
            //Отримання даних
            xn = Convert.ToDouble(textBox1.Text);
            xk = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            a = Convert.ToDouble(textBox4.Text);

            //Очищення грід та графіку
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }
        }

        private void одновимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

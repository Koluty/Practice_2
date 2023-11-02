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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int n = (int)numericUpDown1.Value;
                Arrays a = new Arrays(n);

                for (int i = 0; i < a.Length; i++)
                    dataGridView1.Rows.Add(a[i].ToString());

                a.ReplaceNegativeElementsWithZero();

                for (int i = 0; i < a.Length; i++)
                    dataGridView1.Rows[i].Cells[1].Value = a[i].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

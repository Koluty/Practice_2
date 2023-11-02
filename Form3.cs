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
    public partial class Form3 : Form
    {
        public Form3()
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
            Arrays2D twoDimArray = new Arrays2D();
            DataGridViewTextBoxColumn dvage;

            for (int i = 0; i < twoDimArray.Y_length; i++)
            {
                dvage = new DataGridViewTextBoxColumn();
                dvage.Width = 40;
                dataGridView3.Columns.Add(dvage);
            }

            dataGridView3.Rows.Clear();
            dataGridView3.RowCount = twoDimArray.X_length;
            dataGridView3.ColumnCount = twoDimArray.Y_length;

            for (int i = 0; i < twoDimArray.X_length; i++)
                for(int j = 0; j < twoDimArray.Y_length; j++)
                    dataGridView3.Rows[i].Cells[j].Value = twoDimArray[i,j].ToString();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < twoDimArray.X_length && i < twoDimArray.Y_length; i++)
                dataGridView1.Rows.Add(twoDimArray[i, i].ToString());

            dataGridView2.Rows.Clear();
            for (int i = 0; i < twoDimArray.X_length && i < twoDimArray.Y_length; i++)
                dataGridView2.Rows.Add(twoDimArray[i, twoDimArray.Y_length - i - 1].ToString());
            
        }

    }
}

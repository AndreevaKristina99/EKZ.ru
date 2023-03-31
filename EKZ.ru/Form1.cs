using bdTestirovanie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKZ.ru
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        DataTable tovar;
        int Counter;
        public Form1()
        {

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            db.OpenConnection();

            var reader = new SqlCommand("select * from products_b_import", db.GetConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            Counter = 0;
            GetData(Counter);



        }
        public void GetData(int counter)
        {
            label1.Text = tovar.Rows[counter][0].ToString();
            label2.Text = tovar.Rows[counter][4].ToString();
            label3.Text = tovar.Rows[counter][1].ToString();
            label6.Text = tovar.Rows[counter][2].ToString();
            label4.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox1.Image = Image.FromFile(tovar.Rows[counter][3].ToString());


            label5.Text = tovar.Rows[counter + 1][0].ToString();
            label6.Text = tovar.Rows[counter + 1][4].ToString();
            label7.Text = tovar.Rows[counter + 1][1].ToString();
            label8.Text = tovar.Rows[counter + 1][2].ToString();
            label9.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox2.Image = Image.FromFile(tovar.Rows[counter + 1][3].ToString());



            label10.Text = tovar.Rows[counter + 2][0].ToString();
            label11.Text = tovar.Rows[counter + 2][4].ToString();
            label12.Text = tovar.Rows[counter + 2][1].ToString();
            label13.Text = tovar.Rows[counter + 2][2].ToString();
            label14.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox3.Image = Image.FromFile(tovar.Rows[counter + 2][3].ToString());


            label15.Text = tovar.Rows[counter + 3][0].ToString();
            label16.Text = tovar.Rows[counter + 3][4].ToString();
            label17.Text = tovar.Rows[counter + 3][1].ToString();
            label18.Text = tovar.Rows[counter + 3][2].ToString();
            label19.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox4.Image = Image.FromFile(tovar.Rows[counter + 3][3].ToString());


            label20.Text = tovar.Rows[counter + 4][0].ToString();
            label21.Text = tovar.Rows[counter + 4][4].ToString();
            label22.Text = tovar.Rows[counter + 4][1].ToString();
            label23.Text = tovar.Rows[counter + 4][2].ToString();
            label24.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox5.Image = Image.FromFile(tovar.Rows[counter + 4][3].ToString());


            label25.Text = tovar.Rows[counter + 5][0].ToString();
            label26.Text = tovar.Rows[counter + 5][4].ToString();
            label27.Text = tovar.Rows[counter + 5][1].ToString();
            label28.Text = tovar.Rows[counter + 5][2].ToString();
            label29.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox6.Image = Image.FromFile(tovar.Rows[counter + 5][3].ToString());

            label30.Text = tovar.Rows[counter + 6][0].ToString();
            label31.Text = tovar.Rows[counter + 6][4].ToString();
            label32.Text = tovar.Rows[counter + 6][1].ToString();
            label33.Text = tovar.Rows[counter + 6][2].ToString();
            label34.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox7.Image = Image.FromFile(tovar.Rows[counter + 6][3].ToString());

            label35.Text = tovar.Rows[counter + 7][0].ToString();
            label36.Text = tovar.Rows[counter + 7][4].ToString();
            label37.Text = tovar.Rows[counter + 7][1].ToString();
            label38.Text = tovar.Rows[counter + 7][2].ToString();
            label39.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox8.Image = Image.FromFile(tovar.Rows[counter + 7][3].ToString());

            label40.Text = tovar.Rows[counter + 8][0].ToString();
            label41.Text = tovar.Rows[counter + 8][4].ToString();
            label42.Text = tovar.Rows[counter + 8][1].ToString();
            label43.Text = tovar.Rows[counter + 8][2].ToString();
            label44.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox9.Image = Image.FromFile(tovar.Rows[counter + 8][3].ToString());

            label45.Text = tovar.Rows[counter + 9][0].ToString();
            label46.Text = tovar.Rows[counter + 9][4].ToString();
            label47.Text = tovar.Rows[counter + 9][1].ToString();
            label48.Text = tovar.Rows[counter + 9][2].ToString();
            label49.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox10.Image = Image.FromFile(tovar.Rows[counter + 9][3].ToString());

            label50.Text = tovar.Rows[counter + 10][0].ToString();
            label51.Text = tovar.Rows[counter + 10][4].ToString();
            label52.Text = tovar.Rows[counter + 10][1].ToString();
            label53.Text = tovar.Rows[counter + 10][2].ToString();
            label54.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox11.Image = Image.FromFile(tovar.Rows[counter + 10][3].ToString());

            label55.Text = tovar.Rows[counter + 11][0].ToString();
            label56.Text = tovar.Rows[counter + 11][4].ToString();
            label57.Text = tovar.Rows[counter + 11][1].ToString();
            label58.Text = tovar.Rows[counter + 11][2].ToString();
            label59.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox12.Image = Image.FromFile(tovar.Rows[counter + 11][3].ToString());

            label60.Text = tovar.Rows[counter + 12][0].ToString();
            label61.Text = tovar.Rows[counter + 12][4].ToString();
            label62.Text = tovar.Rows[counter + 12][1].ToString();
            label63.Text = tovar.Rows[counter + 12][2].ToString();
            label64.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox13.Image = Image.FromFile(tovar.Rows[counter + 12][3].ToString());

            label65.Text = tovar.Rows[counter + 13][0].ToString();
            label66.Text = tovar.Rows[counter + 13][4].ToString();
            label67.Text = tovar.Rows[counter + 13][1].ToString();
            label68.Text = tovar.Rows[counter + 13][2].ToString();
            label69.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox14.Image = Image.FromFile(tovar.Rows[counter + 13][3].ToString());

            label70.Text = tovar.Rows[counter + 14][0].ToString();
            label71.Text = tovar.Rows[counter + 14][4].ToString();
            label72.Text = tovar.Rows[counter + 14][1].ToString();
            label73.Text = tovar.Rows[counter + 14][2].ToString();
            label74.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox15.Image = Image.FromFile(tovar.Rows[counter + 14][3].ToString());

            label75.Text = tovar.Rows[counter + 15][0].ToString();
            label76.Text = tovar.Rows[counter + 15][4].ToString();
            label77.Text = tovar.Rows[counter + 15][1].ToString();
            label78.Text = tovar.Rows[counter + 15][2].ToString();
            label79.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox16.Image = Image.FromFile(tovar.Rows[counter + 15][3].ToString());

            label80.Text = tovar.Rows[counter + 16][0].ToString();
            label81.Text = tovar.Rows[counter + 16][4].ToString();
            label82.Text = tovar.Rows[counter + 16][1].ToString();
            label83.Text = tovar.Rows[counter + 16][2].ToString();
            label84.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox17.Image = Image.FromFile(tovar.Rows[counter + 16][3].ToString());

            label85.Text = tovar.Rows[counter + 17][0].ToString();
            label86.Text = tovar.Rows[counter + 17][4].ToString();
            label87.Text = tovar.Rows[counter + 17][1].ToString();
            label88.Text = tovar.Rows[counter + 17][2].ToString();
            label89.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox18.Image = Image.FromFile(tovar.Rows[counter + 17][3].ToString());

            label90.Text = tovar.Rows[counter + 18][0].ToString();
            label91.Text = tovar.Rows[counter + 18][4].ToString();
            label92.Text = tovar.Rows[counter + 18][1].ToString();
            label93.Text = tovar.Rows[counter + 18][2].ToString();
            label94.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox19.Image = Image.FromFile(tovar.Rows[counter + 18][3].ToString());

            label95.Text = tovar.Rows[counter + 19][0].ToString();
            label96.Text = tovar.Rows[counter + 19][4].ToString();
            label97.Text = tovar.Rows[counter + 19][1].ToString();
            label98.Text = tovar.Rows[counter + 19][2].ToString();
            label99.Text = "Материалы" + tovar.Rows[counter][4].ToString();
            pictureBox20.Image = Image.FromFile(tovar.Rows[counter + 19][3].ToString());













        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
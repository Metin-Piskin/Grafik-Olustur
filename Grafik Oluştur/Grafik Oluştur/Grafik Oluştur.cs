using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik_Oluştur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bir, iki, üç, dört, beş;
            bir = Convert.ToDouble(textBox1.Text);
            iki = Convert.ToDouble(textBox2.Text);
            dört = Convert.ToDouble(textBox3.Text);
            beş = Convert.ToDouble(textBox4.Text);
            üç = Convert.ToDouble(textBox5.Text);


            chart1.Series["Grafik"].Points.Add(bir);
            chart1.Series["Grafik"].Points.Add(iki);
            chart1.Series["Grafik"].Points.Add(dört);
            chart1.Series["Grafik"].Points.Add(beş);
            chart1.Series["Grafik"].Points.Add(üç);


            chart1.Series["Grafik"].Points[0].AxisLabel = textBox6.Text;
            chart1.Series["Grafik"].Points[1].AxisLabel = textBox10.Text;
            chart1.Series["Grafik"].Points[2].AxisLabel = textBox9.Text;
            chart1.Series["Grafik"].Points[3].AxisLabel = textBox8.Text;
            chart1.Series["Grafik"].Points[4].AxisLabel = textBox7.Text;

            chart1.Series["Grafik"].Points[0].Color = Color.Orange;
            chart1.Series["Grafik"].Points[1].Color = Color.Chocolate;
            chart1.Series["Grafik"].Points[2].Color = Color.Red;
            chart1.Series["Grafik"].Points[3].Color = Color.RoyalBlue;
            chart1.Series["Grafik"].Points[4].Color = Color.Purple;


            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Focus();
            button1.Enabled = true;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

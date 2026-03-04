using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Wybor.Items.Add("Kwadrat");
            Wybor.Items.Add("Prostokąt");
            Wybor.Items.Add("Trójkąt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            BokB.Visible = true;
                double a, b;
            if (!double.TryParse(BokA.Text, out a) || !double.TryParse(BokB.Text, out b))
            {
                MessageBox.Show("Wpisz poprawne liczby");
                return;
            }
            if (Wybor.SelectedItem == "Trójkąt")
            {
                label2.Text = "Wysokość";
            }
            if (Wybor.SelectedItem == "Kwadrat")
            {
                BokB.Visible = false;
                label2.Visible = false;
            }
            if (Wybor.SelectedItem == null) return;
                double wynik = 0;
                double wyniko = 0;
                switch (Wybor.SelectedItem.ToString())
                {
                    case "Kwadrat":
                        wynik = a * a;
                    wyniko = a * 4;
                    break;
                    case "Prostokąt":
                        wynik = a * b;
                    wyniko = (a + b) * 2;
                        break;
                    case "Trójkąt":
                        wynik = a * b / 2;
                        wyniko = a * 3;
                        break;
                }
                Pole.Text = "Pole: " + wynik.ToString();
                Obwod.Text = "Obwód: " + wyniko.ToString();
            if (Wybor.SelectedItem == "Trójkąt")
            {
                Obwod.Text = "Obwód równoległoboku" + wyniko.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            BokB.Visible = true;
            if (Wybor.SelectedItem == "Trójkąt")
            {
                label2.Text = "Wysokość";
                Obwod.Text = "Obwód równoległoboku";
            }
            if (Wybor.SelectedItem == "Kwadrat")
            {
                BokB.Visible = false;
                label2.Visible = false;
                Obwod.Text = "Obwód";
            }
            if (Wybor.SelectedItem == "Prostokąt")
            {
                label2.Text = "Wpisz bok B";
                Obwod.Text = "Obwód";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Obwod_Click(object sender, EventArgs e)
        {

        }
    }
}

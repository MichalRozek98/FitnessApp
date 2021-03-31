using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FitnessApp
{
    public partial class Fat_Reduction : UserControl
    {
        private Fat_Reduction _instance;

        public Fat_Reduction Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Fat_Reduction();
                return _instance;
            }
        }

        int Active_control = 0;
        int x_position = 0;
        bool is_clicked = false;

        public Fat_Reduction()
        {
            InitializeComponent();
            comboBox_sex.Items.Add("Mężczyzna");
            comboBox_sex.Items.Add("Kobieta");

            // ----------------------------------- //

            comboBox_move.Items.Add("1.0 - brak aktywności fizycznej");
            comboBox_move.Items.Add("1.2 - praca siedząca, niski poziom aktywności");
            comboBox_move.Items.Add("1.4 - praca nie fizyczna, trening 2 razy w tygodniu");
            comboBox_move.Items.Add("1.6 - lekka praca fizyczna, trening 3-4 razy w tygodniu");
            comboBox_move.Items.Add("1.8 - praca fizyczna, trening 5 razy w tygodniu");
            comboBox_move.Items.Add("2.0 - ciężka praca fizyczna, codzienny trening");

            for (int i = 0; i <= 9; i++)
            {
                string name = "button_" + i.ToString();
                Button b = (Button) panel_body_reduction.Controls[name];
                b.Click += new EventHandler(button_Click);
            }

            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (Active_control == 1)
            {
                textBox_weight.Text += button.Text;
            }
            else if (Active_control == 2)
            {
                textBox_height.Text += button.Text;
            }
            else if (Active_control == 3)
            {
                textBox_age.Text += button.Text;
            }
        }


        private void comboBox_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_body_reduction;
        }

        private void comboBox_move_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_body_reduction;
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            if (comboBox_sex.GetItemText(comboBox_sex.SelectedItem) == "Kobieta")
            {
                
            }
            else
            {
                double a = 66.5 + (13.7 * double.Parse(textBox_weight.Text, CultureInfo.InvariantCulture) + (5 * double.Parse(textBox_height.Text, CultureInfo.InvariantCulture)) - (6.8 * double.Parse(textBox_age.Text, CultureInfo.InvariantCulture)));
                textBox_result.Text = A_Ratio(a).ToString();
            }
        }

        private double A_Ratio(double a)
        {
            double result = 0;

            switch (comboBox_move.GetItemText(comboBox_move.SelectedItem).Substring(0, 3))
            {
                case "1.0":
                    result = a * 1.0;
                    break;

                case "1.2":
                    result = a * 1.2;
                    break;

                case "1.4":
                    result = a * 1.4;
                    break;

                case "1.6":
                    result = a * 1.6;
                    break;

                case "1.8":
                    result = a * 1.8;
                    break;

                case "2.0":
                    result = a * 2.0;
                    break;
            }
            result *= 0.85;
            return result;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if(Active_control == 1)
            {
                textBox_weight.Text += 0;
            }
            else if(Active_control == 2)
            {
                textBox_height.Text += 0;
            }
            else if(Active_control == 3)
            {
                textBox_age.Text += 0;
            }
        }

        private void textBox_weight_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 1;
        }

        private void textBox_height_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 2;
        }

        private void textBox_age_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 3;
        }

        private void pictureBox_type_MouseClick(object sender, MouseEventArgs e)
        {
            is_clicked = true;
            pictureBox_type.Refresh();
        }

        private void pictureBox_type_Paint(object sender, PaintEventArgs e)
        {
            if (is_clicked)
            {
                Pen pen = new Pen(Color.Black, 6);
                Graphics g = e.Graphics;

                if (x_position < 131)
                {
                    g.DrawRectangle(pen, 0, 0, 130, pictureBox_type.Size.Height);
                }
                else if (x_position > 130 && x_position < 261)
                {
                    g.DrawRectangle(pen, 131, 0, 130, pictureBox_type.Size.Height);
                }
                else
                {
                    g.DrawRectangle(pen, 261, 0, pictureBox_type.Size.Width - 261, pictureBox_type.Size.Height);
                }
            }
        }

        private void pictureBox_type_MouseMove(object sender, MouseEventArgs e)
        {
            x_position = e.X;
        }
    }
}

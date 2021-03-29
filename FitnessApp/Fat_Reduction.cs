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
                double a = 66.5 + (13.7 * double.Parse(textBox_weight.Text, CultureInfo.InvariantCulture /*Int32.Parse()*/) + (5 * double.Parse(textBox_height.Text, CultureInfo.InvariantCulture) /*Int32.Parse(textBox_height.Text)*/) - (6.8 * double.Parse(textBox_age.Text, CultureInfo.InvariantCulture) /*Int32.Parse(textBox_age.Text)*/));
                double result = 0;

                switch(comboBox_move.GetItemText(comboBox_move.SelectedItem).Substring(0,3))
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
                textBox_result.Text = result.ToString();
            }
        }
    }
}

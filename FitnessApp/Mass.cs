using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Mass : UserControl
    {
        private Mass _instance;

        public Mass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Mass();
                return _instance;
            }
        }

        public Mass()
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

        private void comboBox_move_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_mass;
        }

        private void comboBox_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_mass;
        }
    }
}

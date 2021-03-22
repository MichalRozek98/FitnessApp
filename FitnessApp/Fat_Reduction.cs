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
        }
    }
}

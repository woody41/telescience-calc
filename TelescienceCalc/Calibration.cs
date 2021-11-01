using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelescienceCalc
{
    public partial class Calibration : Form
    {
        public Calibration()
        {
            InitializeComponent();
        }

        private void affirmData_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(this.telepadX.Text);
                Convert.ToInt32(this.telepadY.Text);
                Convert.ToInt32(this.gpsX.Text);
                Convert.ToInt32(this.gpsY.Text);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                new MessageError().ShowDialog();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

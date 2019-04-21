using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimisations
{
    public partial class AddingPoint : Form
    {
        public bool Drop = false;
        public bool Ready = false;

        public double X = 0d;
        public double Y = 0d;


        public AddingPoint()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                X = Convert.ToDouble(xTB.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат числа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTB.Text = "";
                return;
            }

            try
            {
                Y = Convert.ToDouble(yTB.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат числа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTB.Text = "";
                return;
            }

            Ready = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Drop = true;
            Close();
        }
    }
}

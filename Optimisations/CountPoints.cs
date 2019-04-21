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
    public partial class CountPoints : Form
    {
        public bool Ready = false;
        public int Count = 0;


        public CountPoints()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                Count = Convert.ToInt32(CountTB.Text);
                if (Count < 2)
                {
                    MessageBox.Show("Введите число больше двух!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CountTB.Text = "";
                    return;
                }
                Ready = true;
                Close();
            }
            catch
            {
                MessageBox.Show("Неверный формат числа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CountTB.Text = "";
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

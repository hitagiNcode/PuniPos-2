using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuniPos_2
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            anaMenuPanel.BackColor = Color.FromArgb(125, Color.Gray);
            timeLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dokunmatik ekran klavyesi yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana menüye dön.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuş takımı yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

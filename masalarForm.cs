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
    public partial class masalarForm : Form
    {
        private menuForm _masterForm;
        public masalarForm(menuForm masterform)
        {
            InitializeComponent();
            _masterForm = masterform;
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            Form1 B1 = new Form1();
            _masterForm.CreatePos(B1);
        }

       
    }
}

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

        Form1 B1;
        Form1 B2;
        
        public masalarForm(menuForm masterform)
        {
            InitializeComponent();
            _masterForm = masterform;
            B1 = new Form1("B1", _masterForm, this);
            B2 = new Form1("B2", _masterForm, this);
        }

        

        private void masa1_Click(object sender, EventArgs e)
        {
            
            _masterForm.CheckPos(B1, masa1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _masterForm.CheckPos(B2, button1);
        }
    }
}

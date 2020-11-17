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

        Form1 B1,B2,B3,B4,B5,B6,B7,B8,B9,B10;
        Form1 A1, A2, A3, A4, A5;
        
        public masalarForm(menuForm masterform)
        {
            InitializeComponent();
            _masterForm = masterform;
            B1 = new Form1("B1", _masterForm, this);
            B2 = new Form1("B2", _masterForm, this);
            B3 = new Form1("B3", _masterForm, this);
            B4 = new Form1("B4", _masterForm, this);
            B5 = new Form1("B5", _masterForm, this);
            B6 = new Form1("B6", _masterForm, this);
            B7 = new Form1("B7", _masterForm, this);
            B8 = new Form1("B8", _masterForm, this);
            B9 = new Form1("B9", _masterForm, this);
            B10 = new Form1("B10", _masterForm, this);

            A1 = new Form1("A1", _masterForm, this);
            A2 = new Form1("A2", _masterForm, this);
            A3 = new Form1("A3", _masterForm, this);
            A4 = new Form1("A4", _masterForm, this);
            A5 = new Form1("A5", _masterForm, this);
        }

        

        private void masa1_Click(object sender, EventArgs e)
        {
            
            _masterForm.CheckPos(B1, masa1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _masterForm.CheckPos(B2, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B3, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B4, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B5, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B6, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B7, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B8, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B9, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(B10, button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(A1, button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(A2, button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(A3, button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(A4, button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _masterForm.CheckPos(A5, button14);
        }
    }
}

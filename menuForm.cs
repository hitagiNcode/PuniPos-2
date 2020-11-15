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
            DisablePanels();
            anaMenuPanel.Show();
            createMasalar();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Dokunmatik ekran klavyesi yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisablePanels();
            anaMenuPanel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuş takımı yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisablePanels()
        {
            //masaPanel.Hide();
            anaMenuPanel.Hide();
            posPanel.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisablePanels();
            //masaPanel.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisablePanels();
            //masaPanel.Show();
        }


        private void CreatePos()
        {
            Form1 tableB6 = new Form1();
            tableB6.TopLevel = false;
            tableB6.AutoScroll = true;
            tableB6.Dock = DockStyle.Fill;
            posPanel.Controls.Add(tableB6);
            tableB6.FormBorderStyle = FormBorderStyle.None;
            tableB6.Show();
        }

        private void createMasalar()
        {
            masalarForm masalar = new masalarForm();
            masalar.TopLevel = false;
            masalar.AutoScroll = true;
            masalar.Dock = DockStyle.Fill;
            masalar.FormBorderStyle = FormBorderStyle.None;
            //masaPanel.Controls.Add(masalar);
            masalar.Show();
        }

        
    }
}

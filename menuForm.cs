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

        Panel masaPanel = new Panel();
        Panel posPanel2 = new Panel();

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            anaMenuPanel.BackColor = Color.FromArgb(125, Color.Gray);
            timeLabel.Text = DateTime.Now.ToLongDateString();
            

            masalarPanelCreate();
            posPanelCreate();
            

            DisablePanels();
            anaMenuPanel.Show();

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
            masaPanel.Hide();
            anaMenuPanel.Hide();
            posPanel2.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisablePanels();
            masaPanel.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisablePanels();
            masaPanel.Show();
        }


        public void CreatePos(Form1 _tableName)
        {
            //Form1 tableB6 = new Form1();

            DisablePanels();
            posPanel2.Show();

            _tableName.TopLevel = false;
            _tableName.AutoScroll = true;
            _tableName.Dock = DockStyle.Fill;
            posPanel2.Controls.Add(_tableName);
            _tableName.FormBorderStyle = FormBorderStyle.None;
            _tableName.Show();
        }

       

        private void masalarPanelCreate()
        {
            this.Controls.Add(masaPanel);
            masaPanel.BackColor = Color.Gray;
            masaPanel.Size = new Size(736, 351);
            masaPanel.Location = new Point(85, 85);
            masaPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            masaPanel.Show();
            createMasalar();
        }

        private void createMasalar()
        {
            masalarForm masalar = new masalarForm(this);
            masalar.TopLevel = false;
            masalar.AutoScroll = true;
            masalar.Dock = DockStyle.Fill;
            masalar.FormBorderStyle = FormBorderStyle.None;
            masaPanel.Controls.Add(masalar);
            masalar.Show();
        }

        private void posPanelCreate()
        {
            this.Controls.Add(posPanel2);
            posPanel2.BackColor = Color.White;
            posPanel2.Size = new Size(900,550);
            posPanel2.Location = new Point(0, 0);
            posPanel2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            posPanel2.Show();
        }

    }
}

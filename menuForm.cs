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
        masalarForm masalar;

        private List<MasaList> masaListesi;

        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            anaMenuPanel.BackColor = Color.FromArgb(125, Color.Gray);
            timeLabel.Text = DateTime.Now.ToLongDateString();
            masaListesi = new List<MasaList>();

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
            hidePospanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowMasalar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMasalar();
        }

        public void ShowMasalar()
        {
            DisablePanels();
            masaPanel.Show();
        }

        public void CheckPos(Form1 _tableName , Button _button)
        {
            if (_button.BackColor == Color.Orange)
            {
                ClearPospanelAndShow(_tableName);
            }
            else
            {
                CreatePos(_tableName, _button);
            }


        }


        public void CreatePos(Form1 _tableName, Button _button)
        {
            
            _button.ForeColor = Color.White;
            _button.BackColor = Color.Orange;
            DisablePanels();
            posPanel2.Show();

            _tableName.TopLevel = false;
            _tableName.AutoScroll = true;
            _tableName.Dock = DockStyle.Fill;
            _tableName.FormBorderStyle = FormBorderStyle.None;
            posPanel2.Controls.Add(_tableName);
            
            masaListesi.Add(new MasaList() {masaName = _tableName.MasaName, masaForm = _tableName, masaButton = _button });
            _tableName.Show();
        }

        public void ClearPospanelAndShow(Form1 _tableName)
        {
            DisablePanels();
            posPanel2.Show();

            
            _tableName.Show();
        }

        private void hidePospanel()
        {
            for (int i = 0; i < posPanel2.Controls.Count; i++)
            {
                posPanel2.Controls[i].Hide();
            }
        }

        private void masalarPanelCreate()
        {
            this.Controls.Add(masaPanel);
            masaPanel.BackColor = Color.Gray;
            masaPanel.Size = new Size(736, 351);
            masaPanel.Location = new Point(85, 85);
            masaPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            masaPanel.Show();
            createMasalarForm();
        }

        private void createMasalarForm()
        {
            masalar = new masalarForm(this);
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

        public void CancelOrder(Form1 _form)
        {
            if (MessageBox.Show(_form.MasaName + " masasını iptal etmek ister misiniz ?", "Sipariş iptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                posPanel2.Controls.Remove(_form);
                _form.ClearAndUpdateList();
                var masa = masaListesi.Find(x => x.masaName == _form.MasaName);
                masa.masaButton.BackColor = Color.SeaShell;
                masa.masaButton.ForeColor = Color.DodgerBlue;

                masaListesi.Remove(masa);
                ShowMasalar();
            }
        }

       

    }

    public class MasaList
    {
        public string masaName;
        public Form1 masaForm;
        public Button masaButton;

    }
}

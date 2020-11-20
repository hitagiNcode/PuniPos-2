using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuniPos_2
{
    public partial class billModule : UserControl
    {
        public Panel faturaPanel;
        private Form1 _masterForm;
       

        public billModule(Form1 masterform)
        {

            InitializeComponent();
            faturaPanel = new Panel();
            _masterForm = masterform;
            CreateFaturaPanel();
            
        }


        public void HideFaturaPanel()
        {
            faturaPanel.Hide();
            
        }

        public void ShowFaturaPanel()
        {
            faturaPanel.BringToFront();
            faturaPanel.Show();
            pullOrders();
        }

        public void CreateFaturaPanel()
        {
            _masterForm.Controls.Add(faturaPanel);
            faturaPanel.BackColor = Color.White;
            faturaPanel.Size = new Size(770, 499);
            faturaPanel.Location = new Point(125, 12);
            faturaPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            faturaPanel.Controls.Add(this);
            this.Dock = DockStyle.Left;
            faturaPanel.Hide();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            
        }

        private void printBillButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fatura yazıcıya gönderildi");
            faturaPanel.Hide();
        }

        private void faturaCancelButton_Click(object sender, EventArgs e)
        {
            faturaPanel.Hide();
        }

        private void pullOrders()
        {
            billDataTable.Rows.Clear();
            billDataTable.Refresh();
            foreach (var item in _masterForm.orderList)
            {
                billDataTable.Rows.Add(item.Title, item.Quantity +" Adet", item.Price + " TL");
            }

            float totalS = _masterForm.totalAmount;
            string s = totalS.ToString("N2");
            gtoplamText.Text = s;

            float kdv = totalS * 8 / 100;
            string k = kdv.ToString("N2");
            kdvText.Text = k;

            float toplam = totalS - kdv;
            string t = toplam.ToString("N2");
            toplamText.Text = t;

        }

        private void toplamText_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        
        public List<ListItem> orderList;
        private float totalAmount = 0;
        

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongDateString();
            orderList = new List<ListItem>();
            totalPrice.Text = totalAmount.ToString();
            ShowCategory(4);
        }

        //------------Kategori Region----------

        private void ShowCategory(int _catNumber)
        {
            switch (_catNumber)
            {
                case 1:
                    DeActiveAllPanels();

                    break;
                case 2:
                    DeActiveAllPanels();

                    break;
                case 3:
                    DeActiveAllPanels();

                    break;
                case 4:
                    DeActiveAllPanels();
                    burgersPanel.Show();
                    break;
                case 5:
                    DeActiveAllPanels();

                    break;
                case 6:
                    DeActiveAllPanels();

                    break;
                case 7:
                    DeActiveAllPanels();

                    break;
                case 8:
                    DeActiveAllPanels();

                    break;
                case 9:
                    DeActiveAllPanels();

                    break;
                case 10:
                    DeActiveAllPanels();

                    break;
            }
        }

        private void DeActiveAllPanels()
        {
            corbalarPanel.Hide();
            burgersPanel.Hide();
        }

        //-------------------------------------

        //------------List Region---------------
        private void CreateItem(int _itemId, int _itemQuantity, string _name, float _price)
        {
            var item = orderList.Find(x => x.ItemID == _itemId);
            if (item == null)
            {
                orderList.Add(new ListItem() { ItemID = _itemId, Quantity = _itemQuantity, Title = _name, Price = _price });
            }
            else
            {
                item.Quantity++;
                item.Price += _price;
            }

            UpdateList();
        }
        
        public void RemoveOrderFromList(int _itemId)
        {
            orderList.RemoveAll(x => x.ItemID == _itemId);
            UpdateList();
        }
        
        private void UpdateList()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < orderList.Count; i++)
                {
                    flowLayoutPanel1.Controls.Add(orderList[i]);
                    
                }
            }
            else
            {      
              flowLayoutPanel1.Controls.Add(orderList[0]);
              
            }
            TotalAmountCalculation();
        }

        private void TotalAmountCalculation()
        {
            totalAmount = orderList.Sum(x => x.Price);
            string s = totalAmount.ToString("N2");
            totalPrice.Text = s;
        }
        //------------------------------------

        private void Hamburgerler1_Click(object sender, EventArgs e)
        {
            
            CreateItem(9101, 01, "Tavuk Burger", 19.30f);
        }

        private void Hamburgerler2_Click(object sender, EventArgs e)
        {
            CreateItem(9102, 01, "Et Burger", 22.50f);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Punipos yapım aşamasında", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuş takımı yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dokunmatik ekran klavyesi yapılacak.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana menüye dön.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aperatifButton_Click(object sender, EventArgs e)
        {
            ShowCategory(1);
        }

        private void hamburgerButton_Click(object sender, EventArgs e)
        {
            ShowCategory(4);
        }
    }
}

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

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongDateString();
            orderList = new List<ListItem>();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Punipos yapım aşamasında", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


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
           
        }

        private void Hamburgerler1_Click(object sender, EventArgs e)
        {
            
            CreateItem(9101, 01, "Tavuk Burger", 19.30f);
        }

        private void Hamburgerler2_Click(object sender, EventArgs e)
        {
            CreateItem(9102, 01, "Et Burger", 22.50f);
        }

        
    }
}

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

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void CreateItem(int _itemId, int _itemQuantity, string _name, float _price)
        {
            
            orderList.Add(new ListItem() {ItemID = _itemId, Quantity = _itemQuantity, Title = _name, Price = _price});
            
            UpdateList();
        }
        private void RemoveOrderFromList(int itemId)
        {

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
            
            CreateItem(1, 01, "Tavuk Burger", 19.30f);
        }
    }
}

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
        //public List<Order> OrderList;
        

        public Form1()
        {
            
            //OrderList = new List<Order>();
                        InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void GetCategory()
        {

        }

        private void CreateCategory()
        {

        }

        private void CreateItem(int _itemId, string _name, float _price)
        {

            //OrderList.Add(new Order() { itemId = _itemId, name = _name, price = _price });
            UpdateList();
        }
        private void RemoveOrderFromList(int itemId)
        {

            UpdateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongDateString();
            
        }

        private void UpdateList()
        {
            //dataGridView1.DataSource = this.OrderList;
        }

        private void Hamburgerler1_Click(object sender, EventArgs e)
        {
            //CreateItem(01, "Tavuk Burger", 19.30f);
        }
    }
}

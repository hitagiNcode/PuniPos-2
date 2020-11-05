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

        public List<Order> OrderList;

        public Form1()
        {
            
            OrderList = new List<Order>();
                        InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void AddOrder(int itemId)
        {

        }
        public void RemoveOrder(int itemId)
        {

        }

        private void GetCategory()
        {

        }

        private void CreateCategory()
        {

        }
        private void CreateItem(int itemId, string name, float price)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}

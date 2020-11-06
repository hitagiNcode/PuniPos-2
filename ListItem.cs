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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        
        private int _quantity = 3;
        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; QuantityLabel.Text = _quantity.ToString();}
        }

        private string _title = "Empty title";
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; NameLabel.Text = _title; }
        }

        private float _price = 12f;
        [Category("Custom Props")]
        public float Price
        {
            get { return _price; }
            set { _price = value; PriceLabel.Text = _price.ToString(); }
        }
    }
}

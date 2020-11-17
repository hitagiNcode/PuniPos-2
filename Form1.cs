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
        private menuForm _masterForm;
        private masalarForm _masaForm;

        public List<ListItem> orderList;
        private float totalAmount = 0;


        private string masaName;
        public string MasaName
        {
            get { return masaName; }
            set { masaName = value; }
        }



        public Form1(string _name, menuForm masterPanel, masalarForm masaform)
        {
            
            InitializeComponent();
            _masterForm = masterPanel;
            _masaForm = masaform;
            tablaName.Text = "Masa: " + _name;
            MasaName = _name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            orderList = new List<ListItem>();
            totalPrice.Text = totalAmount.ToString();
            ShowCategory(1);
        }

        //------------Kategori Region----------

        private void ShowCategory(int _catNumber)
        {
            switch (_catNumber)
            {
                case 1:
                    DeActiveAllPanels();
                    aperatiflerPanel.Show();
                    break;
                case 2:
                    DeActiveAllPanels();
                    salatalarPanel.Show();
                    break;
                case 3:
                    DeActiveAllPanels();
                    corbalarPanel.Show();
                    
                    break;
                case 4:
                    DeActiveAllPanels();
                    burgersPanel.Show();
                    
                    break;
                case 5:
                    DeActiveAllPanels();
                    pizalarPanel.Show();
                    break;
                case 6:
                    DeActiveAllPanels();
                    tavuklarPanel.Show();
                    break;
                case 7:
                    DeActiveAllPanels();
                    baliklarPanel.Show();
                    break;
                case 8:
                    DeActiveAllPanels();
                    tatlilarPanel.Show();
                    break;
                case 9:
                    DeActiveAllPanels();
                    iceceklerPanel.Show();
                    break;
                case 10:
                    DeActiveAllPanels();
                    menuPanel.Show();
                    break;
            }
        }

        private void DeActiveAllPanels()
        {
            corbalarPanel.Hide();
            burgersPanel.Hide();
            aperatiflerPanel.Hide();
            salatalarPanel.Hide();
            pizalarPanel.Hide();
            tavuklarPanel.Hide();
            baliklarPanel.Hide();
            tatlilarPanel.Hide();
            iceceklerPanel.Hide();
            menuPanel.Hide();
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

        public void ClearAndUpdateList()
        {
            orderList.Clear();
            flowLayoutPanel1.Controls.Clear();
        }

        private void TotalAmountCalculation()
        {
            totalAmount = orderList.Sum(x => x.Price);
            string s = totalAmount.ToString("N2");
            totalPrice.Text = s;
        }
        //------------------------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Punipos yapım aşamasında", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş bul geliştiriliyor.", "PuniPuni Studios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //---------------Menu kategorileri-----------
        private void corbaButton_Click(object sender, EventArgs e)
        {
            ShowCategory(3);
        }

        private void aperatifButton_Click_1(object sender, EventArgs e)
        {
            ShowCategory(1);
        }

        private void hamburgerButton_Click_1(object sender, EventArgs e)
        {
            ShowCategory(4);
        }

        private void salataButton_Click(object sender, EventArgs e)
        {
            ShowCategory(2);
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            ShowCategory(5);
        }

        private void tavukButton_Click(object sender, EventArgs e)
        {
            ShowCategory(6);
        }

        private void balikButton_Click(object sender, EventArgs e)
        {
            ShowCategory(7);
        }

        private void tatliButton_Click(object sender, EventArgs e)
        {
            ShowCategory(8);
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            ShowCategory(9);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ShowCategory(10);
        }
        //---------------------------------------

        //------------Siparis Listesi--------------------
        
        //----------------Salatalar kategorisi--------------
        private void salata1_Click(object sender, EventArgs e)
        {
            CreateItem(8101, 01, "Akdeniz Salata", 13.50f);
        }

        private void salata2_Click(object sender, EventArgs e)
        {
            CreateItem(8102, 01, "Tavuklu Salata", 15.50f);
        }

        private void salata3_Click(object sender, EventArgs e)
        {
            CreateItem(8103, 01, "Tonbalıklı Salata", 14.50f);
        }

        private void salata4_Click(object sender, EventArgs e)
        {
            CreateItem(8104, 01, "Karidesli Salata", 16.50f);
        }

        private void salata5_Click(object sender, EventArgs e)
        {
            CreateItem(8105, 01, "Börülce Salatası", 13f);
        }

        private void salata6_Click(object sender, EventArgs e)
        {
            CreateItem(8106, 01, "Patates Salatası", 14f);
        }
        //--------------------------------------

        //-----------------Aperatifler Kategorisi-------------
        private void aperatif1_Click(object sender, EventArgs e)
        {
            CreateItem(7101, 01, "Patates kızartması", 7f);
        }

        private void aperatif2_Click(object sender, EventArgs e)
        {
            CreateItem(7102, 01, "Soğan halkası", 7.50f);
        }

        private void aperatif3_Click(object sender, EventArgs e)
        {
            CreateItem(7103, 01, "Sigara böreği", 8f);
        }

        private void aperatif4_Click(object sender, EventArgs e)
        {
            CreateItem(7104, 01, "Sosis tabağı", 9.50f);
        }

        private void aperatif5_Click(object sender, EventArgs e)
        {
            CreateItem(7105, 01, "Börek", 11f);
        }

        private void aperatif6_Click(object sender, EventArgs e)
        {
            CreateItem(7106, 01, "Kombo tabak", 14f);
        }
        //------------------------------------------------

        //--------------Corbalar Kategorisi--------------
        private void corba1_Click(object sender, EventArgs e)
        {
            CreateItem(6101, 01, "Mercimek çorbası", 8.50f);
        }

        private void corba2_Click(object sender, EventArgs e)
        {
            CreateItem(6102, 01, "Yayla çorbası", 8.50f);
        }

        private void corba3_Click(object sender, EventArgs e)
        {
            CreateItem(6103, 01, "Kellepaça çorbası", 9.50f);
        }

        private void corba4_Click(object sender, EventArgs e)
        {
            CreateItem(6104, 01, "İşkembe çorbası", 9.50f);
        }

        private void corba5_Click(object sender, EventArgs e)
        {
            CreateItem(6105, 01, "Tavuk çorbası", 9.50f);
        }

        private void corba6_Click(object sender, EventArgs e)
        {
            CreateItem(6106, 01, "Tarhana çorbası", 8.50f);
        }
        //----------------------------------------------------
        //-----------------------Hamburgerler-------------
        private void Hamburgerler1_Click(object sender, EventArgs e)
        {

            CreateItem(9101, 01, "Tavuk Burger", 19.30f);
        }

        private void Hamburgerler2_Click(object sender, EventArgs e)
        {
            CreateItem(9102, 01, "Et Burger", 22.50f);
        }
        private void Hamburgerler3_Click(object sender, EventArgs e)
        {
            CreateItem(9103, 01, "Vejeteryan Burger", 17.30f);
        }

        private void Hamburgerler4_Click(object sender, EventArgs e)
        {
            CreateItem(9104, 01, "Balık Burger", 19.30f);
        }

        private void Hamburgerler5_Click(object sender, EventArgs e)
        {
            CreateItem(9105, 01, "Cheese Burger", 16.30f);
        }

        private void Hamburgerler6_Click(object sender, EventArgs e)
        {
            CreateItem(9106, 01, "Hawaii Burger", 19.90f);
        }
        //---------------------------------------------
        //-----------------Pizalar-----------------
        private void pizza1_Click(object sender, EventArgs e)
        {
            CreateItem(5101, 01, "Karışık Pizza", 24.50f);
        }

        private void pizza2_Click(object sender, EventArgs e)
        {
            CreateItem(5102, 01, "Mantarlı Pizza", 21f);
        }

        private void pizza3_Click(object sender, EventArgs e)
        {
            CreateItem(5103, 01, "Karidesli Pizza", 24f);
        }

        private void pizza4_Click(object sender, EventArgs e)
        {
            CreateItem(5104, 01, "Acılı Sucuklu Pizza", 23f);
        }

        private void pizza5_Click(object sender, EventArgs e)
        {
            CreateItem(5105, 01, "Sebzeli Pizza", 22.50f);
        }

        private void pizza6_Click(object sender, EventArgs e)
        {
            CreateItem(5106, 01, "Tavuklu Pizza", 24.50f);
        }
        //---------------------------------------
        //------------------Tavuklar-------------------
        private void tavuk1_Click(object sender, EventArgs e)
        {
            CreateItem(4101, 01, "Şefin tavası Tavuk", 25.50f);
        }

        private void tavuk2_Click(object sender, EventArgs e)
        {
            CreateItem(4102, 01, "Acılı Tavuk But", 24.90f);
        }

        private void tavuk3_Click(object sender, EventArgs e)
        {
            CreateItem(4103, 01, "Kremantar Tavuk", 26.50f);
        }

        private void tavuk4_Click(object sender, EventArgs e)
        {
            CreateItem(4104, 01, "Ali Nazik Tavuk", 27f);
        }

        private void tavuk5_Click(object sender, EventArgs e)
        {
            CreateItem(4105, 01, "Közlüce Tavuk", 25.90f);
        }

        private void tavuk6_Click(object sender, EventArgs e)
        {
            CreateItem(4106, 01, "Körili Tavuk", 24f);
        }
        //------------------------------------------------------
        //------------------Baliklar-----------------------
        private void baliklar1_Click(object sender, EventArgs e)
        {
            CreateItem(3101, 01, "Levrek", 17f);
        }

        private void baliklar2_Click(object sender, EventArgs e)
        {
            CreateItem(3102, 01, "Çupra", 17.50f);
        }

        private void baliklar3_Click(object sender, EventArgs e)
        {
            CreateItem(3103, 01, "Somon", 16f);
        }

        private void baliklar4_Click(object sender, EventArgs e)
        {
            CreateItem(3104, 01, "Palamut", 17f);
        }

        private void baliklar5_Click(object sender, EventArgs e)
        {
            CreateItem(3105, 01, "Mercan", 16.50f);
        }

        private void baliklar6_Click(object sender, EventArgs e)
        {
            CreateItem(3106, 01, "Lüfer", 18f);
        }
        //---------------------------------------------
        //-----------------------Tatlilar--------------
        private void tatli1_Click(object sender, EventArgs e)
        {
            CreateItem(2101, 01, "Künefe", 10f);
        }

        private void tatli2_Click(object sender, EventArgs e)
        {
            CreateItem(2102, 01, "Sütlaç", 9.50f);
        }

        private void tatli3_Click(object sender, EventArgs e)
        {
            CreateItem(2103, 01, "Keşkül", 9f);
        }

        private void tatli4_Click(object sender, EventArgs e)
        {
            CreateItem(2104, 01, "Kabak Tatlısı", 7f);
        }

        private void tatli5_Click(object sender, EventArgs e)
        {
            CreateItem(2105, 01, "Trileçe", 10f);
        }

        private void tatli6_Click(object sender, EventArgs e)
        {
            CreateItem(2106, 01, "Profiterol", 8f);
        }
        //-----------------------------------------
        //------------------İcecekler--------------
        private void button11_Click(object sender, EventArgs e)
        {
            CreateItem(1101, 01, "CocaCola", 4f);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateItem(1102, 01, "Fanta", 4f);
        }

        private void icecek3_Click(object sender, EventArgs e)
        {
            CreateItem(1103, 01, "Sprite", 4f);
        }

        private void icecek4_Click(object sender, EventArgs e)
        {
            CreateItem(1104, 01, "Ayran", 2.50f);
        }

        private void icecek5_Click(object sender, EventArgs e)
        {
            CreateItem(1105, 01, "Çay", 3f);
        }

        private void icecek6_Click(object sender, EventArgs e)
        {
            CreateItem(1106, 01, "Türk Kahvesi", 5f);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            _masterForm.CancelOrder(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _masterForm.ShowMasalar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CreateItem(1104, 01, "Ayran", 2.50f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateItem(1105, 01, "Çay", 3f);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreateItem(1100, 01, "Su", 1.5f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coolpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> Appleproducts = new List<Product>();
            List<Product> TVproducts = new List<Product>();
            List<Product> Phoneproducts = new List<Product>();
            Appleproducts.Add(new Product() { Name = "IPhone 6", Price = 25900, Hot = true });
            Appleproducts.Add(new Product() { Name = "IPad Air 2", Price = 18900 });
            Appleproducts.Add(new Product() { Name = "IPad mini 3", Price = 13900, Hot = true });
            TVproducts.Add(new Product() { Name = "Sony 40吋", Price = 29900 });
            TVproducts.Add(new Product() { Name = "Panasonic 42吋", Price = 23900, Hot = true });
            TVproducts.Add(new Product() { Name = "LG 50吋", Price = 34900 });
            Phoneproducts.Add(new Product() { Name = "Sony Z3", Price = 15900, Hot = true });
            Phoneproducts.Add(new Product() { Name = "HTC M9", Price = 13900 });
            Phoneproducts.Add(new Product() { Name = "Samsung Note 3", Price = 18900 });
            Phoneproducts.Add(new Product() { Name = "小米機 3", Price = 9900, Hot = true });
            Phoneproducts.Add(new Product() { Name = "Zenfone 2", Price = 7900 });

            int Hotcount = 0;
            foreach (Product product in Appleproducts)
                if (product.Hot) Hotcount++;
            foreach (Product product in TVproducts)
                if (product.Hot) Hotcount++;
            foreach (Product product in Phoneproducts)
                if (product.Hot) Hotcount++;
            cmbProductList.Text = "商品共" + (Appleproducts.Count + TVproducts.Count + Phoneproducts.Count) + "項,熱賣有" + Hotcount + "項";
            cmbProductList.Items.Add("蘋果產品");
            foreach (Product product in Appleproducts)
                cmbProductList.Items.Add(product);
            cmbProductList.Items.Add("電視產品");
            foreach (Product product in TVproducts)
                cmbProductList.Items.Add(product);
            cmbProductList.Items.Add("手機產品");
            foreach (Product product in Phoneproducts)
                cmbProductList.Items.Add(product);
        }
    }
}
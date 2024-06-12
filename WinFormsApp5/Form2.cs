using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormMine : Form
    {

        public bool isButtonSell = false;
        public bool isButtonBuy = false;


        public FormMine()
        {
            InitializeComponent();
        }


        
        private void FormMine_Load(object sender, EventArgs e)
        {

        }

        public void Show(string nameOre, string ore, string worker)
        {
            labelOre1.Text = ore;
            labelOre.Text = nameOre;
            labelWorker.Text = worker;
            this.Text = nameOre + " Mine";
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            isButtonSell = true;
        }
        public int SellOre()
        {
            int result = 0;
            if (int.TryParse(textBoxSellOre.Text, out result))
            {
                return result;
            }
            return result;
        }

        public void Clear()
        {
            textBoxSellOre.Text = "";
            isButtonSell = false;
        }




        private void buttonBuy_Click(object sender, EventArgs e)
        {
            isButtonBuy = true;


        }


        public void forBalanceShow(int balance)
        {
            labelBalance.Text = "Balance: " + balance.ToString() + "$";
        }

        public void forMineSell(double sellPrice)
        {
            buttonBuy.Text = sellPrice.ToString() + "$";
            if (labelWorker.Text == "14")
            {
                buttonBuy.Text = "SOLD";
                label1.Text = "";
                buttonBuy.Enabled = false;
            }
        }
    }
}

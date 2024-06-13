using System.Xml.Serialization;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {


        private Mine ironMine;
        private FormMine formIronMine;

        private Mine stoneMine;
        private FormMine formStoneMine;

        private Mine goldMine;
        private FormMine formGoldMine;

        private Mine coalMine;
        private FormMine formCoalMine;


        private int balance = 999999999;

        public Form1()
        {

            InitializeComponent();
            timer1.Start();
            ironMine = new("Iron ");
            coalMine = new("Coal ");
            goldMine = new("Gold ");
            stoneMine = new("Stone ");


           
        }


         

        private void timer1_Tick(object sender, EventArgs e)
        {
            ironMine.Tick();
            coalMine.Tick();
            stoneMine.Tick();
            goldMine.Tick();
            showBalance();
            if (formStoneMine != null)
            {
                formStoneMine.Show(stoneMine.nameOre, stoneMine.Ore.ToString(), stoneMine.Worker.ToString());
                stoneMine.SellOre(formStoneMine, ref balance);
                stoneMine.BuyWorker(formStoneMine, ref balance);
                formStoneMine.forBalanceShow(balance);
            }

            if (formGoldMine != null)
            {
                formGoldMine.Show(goldMine.nameOre, goldMine.Ore.ToString(), goldMine.Worker.ToString());
                goldMine.SellOre(formGoldMine, ref balance);
                goldMine.BuyWorker(formGoldMine, ref balance);
                formGoldMine.forBalanceShow(balance);
            }

            if (formIronMine != null)
            {
                formIronMine.Show(ironMine.nameOre, ironMine.Ore.ToString(), ironMine.Worker.ToString());
                ironMine.SellOre(formIronMine, ref balance);
                ironMine.BuyWorker(formIronMine, ref balance);
                formIronMine.forBalanceShow(balance);
            }

            if (formCoalMine != null)
            {
                formCoalMine.Show(coalMine.nameOre, coalMine.Ore.ToString(), coalMine.Worker.ToString()); ;
                coalMine.SellOre(formCoalMine, ref balance);
                coalMine.BuyWorker(formCoalMine, ref balance);
                formCoalMine.forBalanceShow(balance);
            }
        }

        private void pictureBoxIronMine_Click(object sender, EventArgs e)
        {
            formIronMine = new();
            formIronMine.Show();

        }






        public void showBalance()
        {
            labelBalance.Text = "Balance: " + balance.ToString() + "$";
        }

        private void pictureBoxGoalMine_Click(object sender, EventArgs e)
        {
            formCoalMine = new();
            formCoalMine.Show();

        }

        private void pictureBoxGoldMine_Click(object sender, EventArgs e)
        {
            formGoldMine = new();
            formGoldMine.Show();

        }

        private void pictureBoxStoneMine_Click(object sender, EventArgs e)
        {
            formStoneMine = new();
            formStoneMine.Show();

        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }
    }
}

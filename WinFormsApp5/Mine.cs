using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Mine(string name)
    {
        public int Ore { get; set; } = 0;
        public int Worker { get; set; } = 1;
        public string nameOre { get; set; } = name;

       

        public void Tick()
        {
            Ore += Worker;
        }
        public void SellOre(FormMine formMine, ref int balance)
        {
            if (formMine.isButtonSell == false)
            {
                return;
            }
            if (Ore >= formMine.SellOre())
            {
                Ore -= formMine.SellOre();
                balance += formMine.SellOre();
                formMine.Clear();
            }
        }

        private double SellPrice = 300;

        public void BuyWorker(FormMine formMine, ref int balance)
        {
            if (formMine.isButtonBuy == false)
            {
                return;
            }
            if (balance >= SellPrice)
            {
               
                
                {
                    balance -= (int)SellPrice;
                    Worker += 1;
                    if (SellPrice <= 4800)
                        SellPrice *= 2;
                    formMine.isButtonBuy = false;
                    formMine.forMineSell(SellPrice);
                }

            }

            
        }


        

    }
}

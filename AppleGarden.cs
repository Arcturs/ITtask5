using System;
using System.Windows.Forms;

namespace task5
{
    public class AppleGarden : Garden
    {
        public int numberOfTrees { get; set; }
        public string appleVariety { get; set; }

        public AppleGarden(double area, double length, double width, int numberOfTrees,  string appleVariety)
            : base(area, length, width)
        {
            this.numberOfTrees = numberOfTrees;
            this.appleVariety = appleVariety;
        }
        
        public override void digUp()
        {
            MessageBox.Show("You're digging a garden");
        }
        
        public override void sow()
        {
            MessageBox.Show("You plant seeds");
        }

        public override void harvest()
        {
            MessageBox.Show("You're harvesting");
        }

        public void harvestSale()
        {
            MessageBox.Show("You're selling the harvest");
        }
    }
}
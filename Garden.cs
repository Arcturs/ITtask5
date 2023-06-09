using System;
using System.Windows.Forms;

namespace task5
{
    public abstract class Garden : Site
    {
        public double area { get; set; }
        public double length { get; set; }
        public double width { get; set; }

        public Garden(double area, double length, double width)
        {
            this-> area;
            this-> length;
            this-> width;
        }

        public abstract void digUp();


        public abstract void sow();
        

        public abstract void harvest();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        private List<Site> siteList = new List<Site>();
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            double area = double.Parse(weightTextBox.Text);
            double length = double.Parse(materialTextBox.Text);
            double width = double.Parse(heightTextBox.Text);
            int numberOfTrees = int.Parse(numShelvesTextBox.Text);
            string appleVariety = colorTextBox.Text;

            AppleGarden appleGarden = new AppleGarden(area, length, width, numberOfTrees, appleVariety);

            
            siteList.Add(appleGarden);
            l.Items.Add(appleGarden);

            
            l.SelectedItem = appleGarden;
            propertyGrid.SelectedObject = appleGarden;

            
            weightTextBox.Text = "";
            materialTextBox.Text = "";
            heightTextBox.Text = "";
            numShelvesTextBox.Text = "";
            colorTextBox.Text = "";
        }
        
        private void removeButton_Click(object sender, EventArgs e)
        {
            
           Site selectedSite = l.SelectedItem as Site;

            
            if (selectedSite != null)
            {
                siteList.Remove(selectedSite);
                l.Items.Remove(selectedSite);
                propertyGrid.SelectedObject = null;
            }
        }
        
        private void tarnsportListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             Site selectedSite = l.SelectedItem as Site;

            
            if (selectedSite != null)
            {
                propertyGrid.SelectedObject = selectedSite;
            }
            else
            {
                propertyGrid.SelectedObject = null;
            }
        }

        
    }
}
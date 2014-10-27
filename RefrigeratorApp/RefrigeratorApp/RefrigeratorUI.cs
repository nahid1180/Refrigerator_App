using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {
        RefrigeratorCapacity aCapacity= new RefrigeratorCapacity();
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aCapacity.MaxWeight = Convert.ToDouble(maximumWeightTextBox.Text);

          
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aCapacity.Items = Convert.ToDouble(itemsTextBox.Text);
            aCapacity.Weight = Convert.ToDouble(weightTextBox.Text);

            currentWeightTextBox.Text = aCapacity.GetCurrentWeight().ToString();
            if (aCapacity.GetRemainingWeight() == 0)
            {
                MessageBox.Show("Out of range");
            }
            else
            {

                remainingWeightTextBox.Text = aCapacity.GetRemainingWeight().ToString();
            }
            
        }
    }
}

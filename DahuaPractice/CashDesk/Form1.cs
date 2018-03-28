using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashDesk
{
    public partial class Form1 : Form
    {
        double Total { get; set; } = 0.00;
        public Form1()
        {
            InitializeComponent();
            totalLabel.Text = Total.ToString();
            discountComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            double price = (double)priceSpinner.Value;
            double amount = (double)amountSpinner.Value;
            double result = price * amount;
            switch (discountComboBox.SelectedText)
            {
                case "无优惠":
                    break;
                case 1:
                    result *= 0.8;
                    break;
                case 2:
                    if (result >= 300)
                    {
                        result -= 100;
                    }
                    break;
                case 3:
                    result *= 0.6;
                    break;
            }
            Total += result;
            listBox1.Items.Add(Properties.Resources.PriceLabelString + price.ToString() + Properties.Resources.AmountLabelString + amount.ToString()
                + Properties.Resources.TotalLabelString + Total.ToString());
            totalLabel.Text = Total.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            priceSpinner.Value = 1.00m;
            amountSpinner.Value = 0;
            Total = 0.00;
            listBox1.Items.Clear();
            totalLabel.Text = Total.ToString();
            discountComboBox.SelectedIndex = 0;
        }
    }
}

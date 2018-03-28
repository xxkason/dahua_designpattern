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
        decimal Total { get; set; } = 0.00m;
        public Form1()
        {
            InitializeComponent();
            totalLabel.Text = Total.ToString();
            discountComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            decimal price = priceSpinner.Value;
            decimal amount = amountSpinner.Value;
            decimal result = price * amount;
            switch (discountComboBox.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    result *= 0.8m;
                    break;
                case 2:
                    if (result >= 300)
                    {
                        result -= 100;
                    }
                    break;
                case 3:
                    result *= 0.6m;
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
            Total = 0.00m;
            listBox1.Items.Clear();
            totalLabel.Text = Total.ToString();
            discountComboBox.SelectedIndex = 0;
        }
    }
}

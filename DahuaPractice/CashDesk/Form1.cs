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
            double result = 0.0;
            //DiscountPolicy activityPolicy = DiscountPolicyFactory.CreateDiscountPolicy(discountComboBox.SelectedItem.ToString());
            Context debratePolicy = new Context(discountComboBox.SelectedItem.ToString());
            result = debratePolicy.GetResult(price * amount);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void numericUpDownUmount_ValueChanged(object sender, EventArgs e)
        
            {
                this.comboBoxCurrency.SelectedItem = &quot; EUR & quot; ;
            }
            private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
            {
                 ConvertCurrency();
            }
            private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
            {
                ConvertCurrency();
            }

        private void label1_Click(object sender, EventArgs e)
        {
            var originalAmount = this.numericUpDownAmount.Value;
            var convertedAmount = originalAmount;
            if (this.comboBoxCurrency.SelectedItem.ToString() == &quot; EUR & quot;)
{
                convertedAmount = originalAmount / 1.95583m;
            }
else if (this.comboBoxCurrency.SelectedItem.ToString() == &quot; USD & quot;)
{
                convertedAmount = originalAmount / 1.80810m;

            }
    }
}

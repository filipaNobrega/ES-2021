using System;
using System.Windows.Forms;

namespace CurrencyCalculator.FirstVersion
{
    public partial class CurrencyCalculatorForm : Form
    {
        public CurrencyCalculatorForm()
        {
            InitializeComponent();
        }

        private void OnEuroTextBoxChanged(object sender, EventArgs e)
        {
            if (!EuroTextBox.ContainsFocus) return;

            if (double.TryParse(EuroTextBox.Text, out var euros))
            {
                DollarTextBox.Text = string.Format("{0}", euros * 1.5069);
                PoundTextBox.Text = string.Format("{0}", euros * 1.5069);

                EuroErrorProvider.SetError(EuroTextBox, string.Empty);
            }
            else
            {
                EuroErrorProvider.SetError(EuroTextBox, "Invalid double!");
            }
        }

        private void OnDollarTextBoxChanged(object sender, EventArgs e)
        {
            if (!DollarTextBox.ContainsFocus) return;

            if (double.TryParse(DollarTextBox.Text, out var dollars))
            {
                EuroTextBox.Text = string.Format("{0}", dollars * 0.663614042);
                PoundTextBox.Text = string.Format("{0}", dollars * 0.603901202);
            }
            else
            {
                DollarErrorProvider.SetError(DollarTextBox, "Invalid double!");
            }
        }

        private void OnPoundTextBoxChanged(object sender, EventArgs e)
        {
            if (!PoundTextBox.ContainsFocus) return;

            if (double.TryParse(PoundTextBox.Text, out var pounds))
            {
                EuroTextBox.Text = string.Format("{0}", pounds * 1.09887849);
                DollarTextBox.Text = string.Format("{0}", pounds * 1.6559);

                PoundErrorProvider.SetError(PoundTextBox, string.Empty);
            }
            else
            {
                PoundErrorProvider.SetError(PoundTextBox, "Invalid double!");
            }
        }
    }
}
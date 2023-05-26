using System.Security.Cryptography;

namespace IdleCalc
{
    public partial class IdleCalc : Form
    {
        public IdleCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentLevel = int.Parse(textBox1.Text);
            var desiredLevel = int.Parse(textBox2.Text);
            var currentPrice = double.Parse(textBox3.Text);

            int range = desiredLevel - currentLevel;

            double totalCost = currentPrice;

            for (int i = 0; i < (range - 1); i++)
            {
                totalCost += (currentPrice * 1.07);
                currentPrice = currentPrice * 1.07;
            }

            DialogResult dialogResult = MessageBox.Show($"The total cost for this upgrade will be: {totalCost}");

        }
    }
}
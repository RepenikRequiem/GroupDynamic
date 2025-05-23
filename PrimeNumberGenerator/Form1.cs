using System;
using System.Text;
using System.Windows.Forms;

namespace PrimeNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputTextBox.Text, out int count) && count > 0)
            {
                string primes = GenerateFirstNPrimes(count);
                resultTextBox.Text = $"Первые {count} простых чисел:\r\n{primes}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное положительное число.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            resultTextBox.Clear();
        }

        private string GenerateFirstNPrimes(int n)
        {
            StringBuilder sb = new StringBuilder();
            int found = 0;
            int number = 2;

            while (found < n)
            {
                if (IsPrime(number))
                {
                    sb.Append(number + " ");
                    found++;
                }
                number++;
            }

            return sb.ToString();
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}

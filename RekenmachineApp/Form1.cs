using System.Diagnostics;
using System.Net;
using System.Security.Policy;

namespace RekenmachineApp
{
    public partial class Rekenmachine : Form
    {
        public Rekenmachine()
        {
            InitializeComponent();
        }
        public string calc(string num1, string num2, string oper)
        {
            try
            {
                switch (oper)
                {
                    case "+":
                        return (double.Parse(num1) + double.Parse(num2)).ToString();
                    case "-":
                        return (double.Parse(num1) - double.Parse(num2)).ToString();
                    case "/":
                        return (double.Parse(num1) / double.Parse(num2)).ToString();
                    case "square":
                        return Math.Sqrt(double.Parse(num1)).ToString();
                    case "exp":
                        return Math.Pow(double.Parse(num1), double.Parse(num2)).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "error";
        }
        string method = "+";

        private void calcTimer_Tick(object sender, EventArgs e)
        {
            if (bar.Value < 100)
            {
                bar.Value += 1;
                return;
            }
            string result = calc(tb1.Text, tb2.Text, method);
            ans.Text = result;
            calcTimer.Stop();
            MessageBox.Show(result);
            bar.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            method = "+";
            calcTimer.Start();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            method = "-";
            calcTimer.Start();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            method = "/";
            calcTimer.Start();
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gemaakt door Misha");
        }

        private void extra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            method = "exp";
            calcTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            method = "square";
            calcTimer.Start();
        }
    }
}

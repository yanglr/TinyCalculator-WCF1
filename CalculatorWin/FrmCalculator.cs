using System;
using System.Windows.Forms;
using System.ServiceModel;
using CalculatorWin.ServiceReference1;

namespace CalculatorWin
{
    public partial class FrmCalculator:Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        MathClient _client;  // MathClient这个类名来自于自动生成的Reference.cs文件中

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            _client = new MathClient();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtStatus.Text = "";
            try
            {
                _client = new MathClient();
                if(radInt.Checked)
                {
                    int x = Convert.ToInt32(txtX.Text);
                    int y = Convert.ToInt32(txtY.Text);
                    int result = _client.Multiply(x, y);
                    txtResult.Text = result.ToString();
                }
                else if(radDouble.Checked)
                {
                    double x = Convert.ToDouble(txtX.Text);
                    double y = Convert.ToDouble(txtY.Text);
                    double result = _client.MultiplyDouble(x, y);
                    txtResult.Text = result.ToString();
                }
            }
            catch(FaultException<OverflowException> ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "OverflowException");
            }
            catch(Exception ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtStatus.Text = "";
            try
            {
                _client = new MathClient();
                if(radInt.Checked)
                {
                    int x = Convert.ToInt32(txtX.Text);
                    int y = Convert.ToInt32(txtY.Text);
                    int result = _client.Divide(x, y);
                    txtResult.Text = result.ToString();
                }
                else if(radDouble.Checked)
                {
                    double x = Convert.ToDouble(txtX.Text);
                    double y = Convert.ToDouble(txtY.Text);
                    double result = _client.DivideDouble(x, y);
                    txtResult.Text = result.ToString();
                }
            }
            catch(FaultException<DivideByZeroException> ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "DivideByZeroException");
            }
            catch(Exception ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void FrmCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            _client.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            try
            {
                _client = new MathClient();
                if(radInt.Checked)
                {
                    int x = Convert.ToInt32(txtX.Text.Trim());
                    int y = Convert.ToInt32(txtY.Text.Trim());
                    txtResult.Text = _client.Add(x, y).ToString();
                }
                else if(radDouble.Checked)
                {
                    double x = Convert.ToDouble(txtX.Text.Trim());
                    double y = Convert.ToDouble(txtY.Text.Trim());
                    txtResult.Text = _client.AddDouble(x, y).ToString();
                }
            }
            catch(Exception ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            try
            {
                _client = new MathClient();

                if(radInt.Checked)
                {
                    int.TryParse(txtX.Text.Trim(), out int x);
                    int.TryParse(txtY.Text.Trim(), out int y);
                    txtResult.Text = _client.Subtract(x, y).ToString();
                }
                else if(radDouble.Checked)
                {
                    Double.TryParse(txtX.Text.Trim(), out double x);
                    Double.TryParse(txtY.Text.Trim(), out double y);
                    txtResult.Text = _client.SubtractDouble(x, y).ToString();
                }
            }
            catch(Exception ex)
            {
                txtStatus.Text = ex.GetType().ToString();
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtX.Text = string.Empty;
            txtY.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
    }
}

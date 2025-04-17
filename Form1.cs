using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_17
{
    public partial class Form1 : Form
    {
        Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("به ماشین حساب من خوش آمدید");
        }


        bool ValidationInput()
        {
            bool isValid = true;

            if (txtNum1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (txtNum2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return isValid;
        }



        private void btnSum_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                int sum = calculator.Sum((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Sum Is : " + sum); 
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                int sub = calculator.Sub(int.Parse(txtNum1.Value.ToString()), int.Parse(txtNum2.Value.ToString()));
                MessageBox.Show("Sub Is : " + sub);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                int mul = calculator.Mul((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Mul Is : " + mul);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                int div = calculator.Div((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Div Is : " + div);
            }
        }
    }
}

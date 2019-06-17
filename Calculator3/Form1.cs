using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        double solution = 0.0;
        double input = 0.0;
        double answer = 0.0;
        char operation = '=';
        bool needClear = false;

        public void CheckClear()
        {
            if (needClear == true)
            {
                display.Text = "";
            }
        }

        public void Solve(char nextOperation)
        {
            solution = answer;
            double.TryParse(display.Text, out input);            

            if(operation == '+')
            {
                answer = solution + input;
            }
            else if(operation == '-')
            {
                answer = solution - input;
            }
            else if (operation == '*')
            {
                answer = solution * input;
            }
            else if (operation == '/')
            {
                answer = solution / input;
            }
            else if (operation == '%')
            {
                answer = solution / 100 * input;
            }
            else if (operation == '=')
            {
                answer = input;
            }

            display.Text = answer.ToString();
            needClear = true;
            operation = nextOperation;
        }

        public Form1()
        {
            InitializeComponent();
        }        

        private void Button0_Click(object sender, EventArgs e)
        {
            if (display.Text != "0" & display.Text != String.Empty)
            {
                CheckClear();
                display.Text += "0";
                needClear = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "1";
            needClear = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "2";
            needClear = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "3";
            needClear = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "4";
            needClear = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "5";
            needClear = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "6";
            needClear = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "7";
            needClear = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "8";
            needClear = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CheckClear();
            display.Text += "9";
            needClear = false;
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            CheckClear();
            if (display.Text.Equals(""))
            {
                display.Text += "0.";
            }
            else if (display.Text.Contains(".") == false)
            {
                display.Text += ".";
            }
            needClear = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Solve('+');
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            Solve('-');
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Solve('*');
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Solve('/');
        }
        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            Solve('%');
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            Solve('=');
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (needClear == false && display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            else
            {
                operation = '=';
            }            
        }
        
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            solution = 0.0;
            input = 0.0;
            answer = 0.0;
            operation = '=';
            needClear = false;            
        }
    }
}

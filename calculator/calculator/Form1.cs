using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isopPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isopPerformed))
                textBox.Clear(); // default is 0 but when we enter number then it clear the 0 and the number will be shown
            isopPerformed = false;
            Button n=(Button) sender; // "n" used for number 
            if (n.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text; // this is for dot that we are not going to put many dost
            }
            textBox.Text = textBox.Text + n.Text; // this is for number that we click on it
            
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if(resultValue!=0)  // of result value is not 0 then this will be automaticlly add =
            {
                nequal.PerformClick();
                opPerformed = n.Text;
               
                lcurrentOp.Text = resultValue + " " + opPerformed; // this is used for label to show the number and opertor
                isopPerformed = true;
            }
            else
            {
            opPerformed = n.Text;
            resultValue = Double.Parse(textBox.Text);
            lcurrentOp.Text = resultValue + " " + opPerformed; // this is used for label to show the number and opertor
            isopPerformed = true;
            }

        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0"; //to removed the enter number or op
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;  // used to clear the result and all
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch (opPerformed) // used to performed all opertions 
                {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":                    
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox.Text); // update the value in the label
            lcurrentOp.Text = "";

        }
    }
}

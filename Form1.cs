using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation ="";
        bool ok = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")  || (ok)) //zero nu poate fi prima litera
                textBox1.Clear();
            ok = false;
            Button b = (Button)sender;
         /*
            if (b.Text == ",")//daca butonul pe care l.am apasat este ","
            {
         
                if (!textBox1.Text.Contains(",")) 
                    textBox1.Text = textBox1.Text + b.Text;//punem "," atata timp cat nu mai este altul
               
            }
            else*/
                textBox1.Text = textBox1.Text + b.Text; //daca nu punem punct continuam cu adaugarea cifrelor
           
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                egal.PerformClick();
                ok = true; //memoram faptul ca o operatie a fost selectata(pentru a nu se adauga noul numar peste celalalt)
                operation = b.Text;          
                label1.Text =result + " " + operation;
                result = Double.Parse(textBox1.Text);
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(textBox1.Text);
                ok = true;
                label1.Text =result + " " + operation;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            result = 0;
            label1.Text = " ";

        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void egal_Click(object sender, EventArgs e)
        {          
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: break;
            }
            
            result = Double.Parse(textBox1.Text);//salvez al doilea numar
            operation = "";//resetez operatia
         //   label1.Text = " ";
            ok = true;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else
                textBox1.Text = "0";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (e.KeyChar.ToString())
            {
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "0":
                    button0.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    inmultire.PerformClick();
                    break;
                case "/":
                    impartire.PerformClick();
                    break;
                case "=":
                   egal.PerformClick();
                    break;
                case ",":
                    punct.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a;
            a = Double.Parse(textBox1.Text);
            a = a * (-1);
            textBox1.Text = a.ToString();
        }

        private void punct_Click(object sender, EventArgs e)
        {
            ok = false;

            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}

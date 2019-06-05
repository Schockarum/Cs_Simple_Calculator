using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    double result = 0.0;
    bool opFlag = false;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void zero_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || this.screen.Text == "0" || !opFlag)
        {
            inputLabel.Text += "0";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "0";
            inputLabel.Text += "0";
            opFlag = true;
        }
    }

    protected void Button5_Click(object sender, EventArgs e) //Botón 1
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "1";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "1";
            inputLabel.Text += "1";
            opFlag = true;
        }
    }

    protected void two_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "2";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "2";
            inputLabel.Text += "2";
            opFlag = true;
        }
    }

    protected void three_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "3";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "3";
            inputLabel.Text += "3";
            opFlag = true;
        }
    }

    protected void four_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "4";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "4";
            inputLabel.Text += "4";
            opFlag = true;
        }
    }

    protected void five_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "5";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "5";
            inputLabel.Text += "5";
            opFlag = true;
        }
    }

    protected void six_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "6";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "6";
            inputLabel.Text += "6";
            opFlag = true;
        }
    }

    protected void seven_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "7";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "7";
            inputLabel.Text += "7";
            opFlag = true;
        }
    }

    protected void eight_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "8";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "8";
            inputLabel.Text += "8";
            opFlag = true;
        }
    }

    protected void nine_Click(object sender, EventArgs e)
    {
        if (this.screen.Text == "" || !opFlag)
        {
            inputLabel.Text += "9";
            this.screen.Text = inputLabel.Text;
        }
        else
        {
            this.screen.Text += "9";
            inputLabel.Text += "9";
            opFlag = true;
        }
    }

    protected void sum_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (op1Label.Text == string.Empty)
            {
                op1Label.Text = inputLabel.Text;
                this.screen.Text += " + ";
                tempTextLabel.Text = this.screen.Text;
                operationLabel.Text = "+";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " + ";
                operationLabel.Text = "+";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " + ";
            operationLabel.Text = "+";
            inputLabel.Text = string.Empty;
        }
    }

    protected void sub_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (op1Label.Text == string.Empty)
            {
                op1Label.Text = inputLabel.Text;
                this.screen.Text += " - ";
                operationLabel.Text = "-";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " - ";
                operationLabel.Text = "-";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " - ";
            operationLabel.Text = "-";
            inputLabel.Text = string.Empty;
        }
    }

    protected void div_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (op1Label.Text == string.Empty)
            {
                op1Label.Text = inputLabel.Text;
                this.screen.Text += " / ";
                tempTextLabel.Text = this.screen.Text;
                operationLabel.Text = "/";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " / ";
                operationLabel.Text = "/";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " / ";
            operationLabel.Text = "/";
            inputLabel.Text = string.Empty;
        }
    }

    protected void mul_Click(object sender, EventArgs e)
    {
        if (!opFlag)
        {
            if (op1Label.Text == string.Empty)
            {
                op1Label.Text = inputLabel.Text;
                this.screen.Text += " * ";
                tempTextLabel.Text = this.screen.Text;
                operationLabel.Text = "*";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
            else
            {
                this.screen.Text += " * ";
                operationLabel.Text = "*";
                inputLabel.Text = string.Empty;
                opFlag = true;
            }
        }
        else
        {
            calculate();
            this.screen.Text += " * ";
            operationLabel.Text = "*";
            inputLabel.Text = string.Empty;
        }
    }

    protected void dot_Click(object sender, EventArgs e)
    {
        if (inputLabel.Text == "")
        {
            this.screen.Text = "0.";
            inputLabel.Text += "0.";
        }
        else
        {
            if (!inputLabel.Text.Contains("."))
            {
                this.screen.Text += ".";
                inputLabel.Text += ".";
            }
        }
    }

    protected void equals_Click(object sender, EventArgs e)
    {
        if (!(operationLabel.Text == "n"))//n es operador nulo. Si el operador no es nulo, calculamos.
        {
            calculate();
        }
        opFlag = false;
        tempTextLabel.Text = "";
    }

    protected void backspace_Click(object sender, EventArgs e)
    {
        if (inputLabel.Text.Length > 0)
        {
            inputLabel.Text = inputLabel.Text.Remove(inputLabel.Text.Length - 1);
            this.screen.Text = tempTextLabel.Text + inputLabel.Text;
        }
    }

    protected void clear_Click(object sender, EventArgs e)
    {
        clearStuff();
    }

    private void calculate()
    {
        op2Label.Text = inputLabel.Text;
        double num1, num2;
        double.TryParse(op1Label.Text, out num1);
        double.TryParse(op2Label.Text, out num2);

        if (operationLabel.Text == "+")
        {
            result = num1 + num2;
            resultLabel.Text = result.ToString();
            this.screen.Text = resultLabel.Text;
            op1Label.Text = result.ToString();
            tempTextLabel.Text = op1Label.Text;
        }
        else if (operationLabel.Text == "-")
        {
            result = num1 - num2;
            resultLabel.Text = result.ToString();
            this.screen.Text = resultLabel.Text;
            op1Label.Text = result.ToString();
            tempTextLabel.Text = op1Label.Text;
        }
        else if (operationLabel.Text == "*")
        {
            result = num1 * num2;
            resultLabel.Text = result.ToString();
            this.screen.Text = resultLabel.Text;
            op1Label.Text = result.ToString();
            tempTextLabel.Text = op1Label.Text;
        }
        else if (operationLabel.Text == "/")
        {
            if (num2 == 0)
            {
                this.screen.Text = "Error: Div by 0.";
                op1Label.Text = "0";
                tempTextLabel.Text = "";
            }
            else
            {
                result = num1 / num2;
                resultLabel.Text = result.ToString();
                this.screen.Text = resultLabel.Text;
                op1Label.Text = result.ToString();
                tempTextLabel.Text = op1Label.Text;
            }
        }
    }

    private void clearStuff()
    {
        this.screen.Text = string.Empty;
        this.op1Label.Text = string.Empty;
        this.op2Label.Text = string.Empty;
        result = 0;
        resultLabel.Text = string.Empty;
        tempTextLabel.Text = "";
        operationLabel.Text = "n";
        this.inputLabel.Text = "";
    }
}

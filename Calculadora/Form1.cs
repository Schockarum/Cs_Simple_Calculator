using System.IO;

namespace Calculadora{

    public partial class Form1 : Form{

        public Form1(){
            InitializeComponent();
        }

        double a; //1º Operand
        double b; //2º Operand
        string c; //Operation

        //btnXClick updates value on screen after pressing a button.
        private void btn1Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "1";
            } else {
                screen.Text = screen.Text + "1";
            }
        }

        private void btn2Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "2";
            } else {
                screen.Text = screen.Text + "2";
            }
        }

        private void btn3Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "3";
            } else {
                screen.Text = screen.Text + "3";
            }
        }

        private void btn4Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "4";
            } else {
                screen.Text = screen.Text + "4";
            }
        }

        private void btn5Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "5";
            } else {
                screen.Text = screen.Text + "5";
            }
        }

        private void btn6Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "6";
            } else {
                screen.Text = screen.Text + "6";
            }
        }

        private void btn7Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "7";
            } else {
                screen.Text = screen.Text + "7";
            }
        }

        private void btn8Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "8";
            } else {
                screen.Text = screen.Text + "8";
            }
        }

        private void btn9Click(object sender, EventArgs e){
            if (screen.Text == ""){
                screen.Text = "9";
            } else {
                screen.Text = screen.Text + "9";
            }
        }

        private void btn0Click(object sender, EventArgs e){
            if (screen.Text == "" or screen.Text == "0"){
                screen.Text = "0";
            } else {
                screen.Text = screen.Text + "0";
            }
        }

        private void divisionButtonClick(object sender, EventArgs e){
            a = Convert.ToDouble(this.screen.Text);
            c = "/";
            this.screen.Clear();
            this.screen.Focus();
        }

        private void multButtonClick(object sender, EventArgs e){
            a = Convert.ToDouble(this.screen.Text);
            c = "*";
            this.screen.Clear();
            this.screen.Focus();
        }

        private void restButtonClick(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.screen.Text);
            c = "-";
            this.screen.Clear();
            this.screen.Focus();
        }

        private void sumButtonClick(object sender, EventArgs e){
            a = Convert.ToDouble(this.screen.Text);
            c = "+";
            this.screen.Clear();
            this.screen.Focus();
        }

    }
}
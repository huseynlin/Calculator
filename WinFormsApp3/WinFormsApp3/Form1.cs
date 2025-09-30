namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "" || operation.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Information");
            }
            else
            {
                double result = 0;
                double n1 = Convert.ToDouble(num1.Text);
                double n2 = Convert.ToDouble(num2.Text);
                char opr = Convert.ToChar(operation.Text);

                if (opr == '+')
                {
                    result = n1 + n2;
                }
                else if (opr == '-')
                {
                    result = n1 - n2;
                }
                else if (opr == '*')
                {
                    result = n1 * n2;
                }
                else if (opr == '/')
                {
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed", "Information");
                    }
                }
                if (opr == '/' && n2 == 0)
                {
                    history.Items.Add("ERROR");
                }
                else
                {
                    history.Items.Add(n1 + " " + opr + " " + n2 + " = " + result);
                }
            }
        }
    }
}
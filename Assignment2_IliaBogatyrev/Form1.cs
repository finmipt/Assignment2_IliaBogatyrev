namespace Assignment2_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the income generated from each class of ticket sales
            double classAIncome = Convert.ToDouble(richTextBox1.Text) * 15;
            double classBIncome = Convert.ToDouble(richTextBox2.Text) * 12;
            double classCIncome = Convert.ToDouble(richTextBox3.Text) * 9;

            // Calculate the total revenue
            double totalRevenue = classAIncome + classBIncome + classCIncome;

            // Display the income generated from each class of ticket sales and the total revenue
            label8.Text = String.Format("{0:ˆ#,##0.00}", classAIncome);
            label9.Text = String.Format("{0:ˆ#,##0.00}", classBIncome);
            label10.Text = String.Format("{0:ˆ#,##0.00}", classCIncome);
            label11.Text = String.Format("{0:ˆ#,##0.00}", totalRevenue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the form
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

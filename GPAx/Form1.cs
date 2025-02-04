namespace GPAx
{
    public partial class Form1 : Form
    {
        GPACalculator gPACalculator;
        public Form1()
        {
            InitializeComponent();
            gPACalculator = new GPACalculator();
        }

        private void getMaxGPA(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(tbInputGPA.Text);
                gPACalculator.setGPA(input);
                tbGPAx.Text = gPACalculator.getGPAX().ToString();
                tbGPAmin.Text = gPACalculator.getMinGPA().ToString();
                tbGPAmax.Text = gPACalculator.getMaxGPA().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ตัวเลขไม่ถูกต้อง");
                tbGPAx.Text = "";
                tbGPAmin.Text = "";
                tbGPAmax.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
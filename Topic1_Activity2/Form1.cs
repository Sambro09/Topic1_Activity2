namespace Topic1_Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(celsiusInput.Text);

            //formula (0°C × 9/5) + 32 = 32°F
            double farenhiet = (celsius * 9 / 5) + 32;

            farenhietOutput.Text = farenhiet.ToString();
        }
    }
}
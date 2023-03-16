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
            double celsius;
            if (double.TryParse(celsiusInput.Text, out celsius))
            {
                //formula (0°C × 9/5) + 32 = 32°F
                double fahrenhiet = (celsius * 9 / 5) + 32;

                fahrenhietOutput.Text = fahrenhiet.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
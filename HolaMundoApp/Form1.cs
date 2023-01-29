namespace HolaMundoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola Mundo!";
        }
    }
}
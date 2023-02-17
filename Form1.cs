namespace Projeto01
{
    public partial class FrmHelloWorld : Form
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
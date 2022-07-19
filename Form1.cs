namespace Exercício_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            float num;
            
            try
            {
                num = float.Parse(txbNum.Text);
                if ((num < 0) && (num % 2 == 0))
                    lbResultado.Text = "O número inserido é negativo e par";
                if ((num >= 0) && (num % 2 == 0))
                    lbResultado.Text = "O número inserido é positivo e par";
                if ((num >= 0) && !(num % 2 == 0))
                    lbResultado.Text = "O número inserido é positivo e ímpar";
                if ((num < 0) && !(num % 2 == 0))
                    lbResultado.Text = "O número inserido é negativo e ímpar";
            }
            catch
            {
                MessageBox.Show("Favor informar um valor válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
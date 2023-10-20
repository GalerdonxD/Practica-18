namespace Practica_18
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

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C;

            A = double.Parse(ladoA.Text);
            B = double.Parse(ladoB.Text);
            C = double.Parse(ladoC.Text);

            if ((A == B) && (B == C))
            {
                triangulo.Text = "Equilatero";
            }

            else
            {
                if ((A == B) || (A == C) || (B == C))
                {
                    triangulo.Text = "Isosceles";
                }

                else
                {
                    triangulo.Text = "Escaleno";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ladoA.Text = " ";
            ladoB.Text = " ";
            ladoC.Text = " ";
            triangulo.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
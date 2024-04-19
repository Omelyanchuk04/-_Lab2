namespace ОПІ_ЛР2_Omel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcHypotenyse_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double cathetusA) ||
               !double.TryParse(textBoxB.Text, out double cathetusB))
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для катетів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double hypotenuse = Math.Sqrt(Math.Pow(cathetusA, 2) + Math.Pow(cathetusB, 2));

            // Виводимо результат у третій текстовий блок
            textBoxC.Text = hypotenuse.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
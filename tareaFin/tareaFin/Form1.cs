using System.Windows.Forms;

namespace tareaFin
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

        private void Nota3textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Promediobutton_Click(object sender, EventArgs e)
        {
            promAsync();
            decimal num1 = Convert.ToDecimal(Nota1textBox.Text);
            decimal num2 = Convert.ToDecimal(Nota2textBox.Text);
            decimal num3 = Convert.ToDecimal(Nota3textBox.Text);
            decimal num4 = Convert.ToDecimal(Nota4textBox.Text);
            String nombre = Convert.ToString(NombretextBox.Text);
            decimal total = await promedioAsync(num1, num2, num3, num4);
            MessageBox.Show(nombre + " -- Su Promedio Total es : " + total / 4);
        }

        private async Task<decimal> promedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promtotal = await Task.Run (() =>
            {
                return n1+n2+n3+n4;
            });
            return promtotal;

        }

        private Task promAsync()
        {
            return Task.Delay(20000);

        }
    }
}
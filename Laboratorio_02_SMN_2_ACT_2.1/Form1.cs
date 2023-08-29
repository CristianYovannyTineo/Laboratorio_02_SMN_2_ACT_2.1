namespace Laboratorio_02_SMN_2_ACT_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calcularButton_Click(object sender, EventArgs e)
        {


            if (double.TryParse(Montotxt.Text, out double montoConsumo))
            {
                double dsctMenor = 0.10;
                double dsctMayor = 0.20;
                double Impuesto = 0.18;

                double descuento = 0;
                double impuesto = 0;

                if (montoConsumo <= 100.00)
                {
                    descuento = montoConsumo * dsctMenor;
                }
                else
                {
                    descuento = montoConsumo * dsctMayor;
                }
                impuesto = (montoConsumo - descuento) * Impuesto;
                double subtotal = montoConsumo - descuento;
                double totalAPagar = subtotal + impuesto;

                Dsct.Text = "Es: " + descuento;
                imp.Text = "Es: " + impuesto;
                Subt.Text = "Es: " + subtotal;
                ImpApagar.Text = "Es: " + totalAPagar;
            }
        }
    }
}
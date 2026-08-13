namespace Desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            comboBox1.Items.Add("Electrónica");
            comboBox1.Items.Add("Ropa");
            comboBox1.Items.Add("Alimentos");
            comboBox1.Items.Add("Hogar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precioOriginal;
            double montoTotal;
            double descuento = 0;

            
            precioOriginal = Convert.ToDouble(textBox1.Text);
            montoTotal = Convert.ToDouble(textBox2.Text);

            
            if (comboBox1.Text == "")
            {
                label7.Text = "Seleccione una categoría.";
                return;
            }

            
            switch (comboBox1.Text)
            {
                case "Electrónica":

                    if (montoTotal > 500)
                    {
                        descuento = precioOriginal * 0.10;
                    }

                    break;

                case "Ropa":

                    if (montoTotal > 300)
                    {
                        descuento = precioOriginal * 0.15;
                    }

                    break;

                case "Alimentos":

                    if (montoTotal > 200)
                    {
                        descuento = precioOriginal * 0.05;
                    }

                    break;

                case "Hogar":

                    if (montoTotal > 400)
                    {
                        descuento = precioOriginal * 0.20;
                    }

                    break;
            }

            
            double precioFinal = precioOriginal - descuento;

           
            label5.Text = "Precio final: $" + precioFinal.ToString("0.00");

            label6.Text = "Descuento: $" + descuento.ToString("0.00");

            
            if (descuento > 0)
            {
                label7.Text = "Se aplicó un descuento.";
            }
            else
            {
                label7.Text = "No se aplicó descuento.";
            }
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
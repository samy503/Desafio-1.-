using System;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double precioOriginal;
            double montoTotal;
            double porcentajeDescuento = 0;

            
            if (!double.TryParse(textBox1.Text, out precioOriginal))
            {
                MessageBox.Show("Ingrese un precio original válido.");
                return;
            }

          
            if (!double.TryParse(textBox2.Text, out montoTotal))
            {
                MessageBox.Show("Ingrese un monto total válido.");
                return;
            }

            
            if (precioOriginal <= 0 || montoTotal <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que 0.");
                return;
            }

            
            switch (comboBox1.Text)
            {
                case "Electrónica":
                    if (montoTotal > 500)
                    {
                        porcentajeDescuento = 0.10;
                    }
                    break;

                case "Ropa":
                    if (montoTotal > 300)
                    {
                        porcentajeDescuento = 0.15;
                    }
                    break;

                case "Alimentos":
                    if (montoTotal > 200)
                    {
                        porcentajeDescuento = 0.05;
                    }
                    break;

                case "Hogar":
                    if (montoTotal > 400)
                    {
                        porcentajeDescuento = 0.20;
                    }
                    break;

                default:
                    MessageBox.Show("Seleccione una categoría.");
                    return;
            }

           
            double descuento = precioOriginal * porcentajeDescuento;

         
            double precioFinal = precioOriginal - descuento;

            
            label5.Text = "Precio final: $" + precioFinal.ToString("0.00");

          
            label6.Text = "Descuento: $" + descuento.ToString("0.00");

            
            if (porcentajeDescuento > 0)
            {
                label7.Text = "Se aplicó un descuento del "
                    + (porcentajeDescuento * 100).ToString("0")
                    + "%.";
            }
            else
            {
                label7.Text = "No se aplicó ningún descuento.";
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritto.Items.Add(productoSeleccionado);

        }

        private void btnCalcuclar_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;

            int TotalProductos = listCarritto.Items.Count;

            for (int i = 0; i < TotalProductos; i++) {
                string productoElegido = listCarritto.Items[i].ToString();
                if (productoElegido == "Pantalon") {

                    precioFinal += 20;
                }
                else if (productoElegido == "Camisa")
                {

                    precioFinal += 35;
                }
                if (productoElegido == "Zapatos")
                {

                    precioFinal += 10;
                }

            }

            if (codigoDescuento.Text == "NIKE")
            {
                precioFinal = precioFinal * 0.9;
            }

            MessageBox.Show("El precio final es: $" + precioFinal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


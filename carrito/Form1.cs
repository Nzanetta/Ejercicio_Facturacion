using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Define el espacio de nombres y la clase del formulario.
namespace carrito
{
    public partial class Form1 : Form
    {
        // Constructor del formulario.
        public Form1()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al cargar el formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Agrega elementos al ComboBox (cboProductos) cuando el formulario se carga.
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        // Evento que se dispara al hacer clic en el botón "Agregar".
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtiene el producto seleccionado en el ComboBox.
            string productoSeleccionado = cboProductos.SelectedItem.ToString();

            // Agrega el producto seleccionado a la lista (listCarritto).
            listCarritto.Items.Add(productoSeleccionado);
        }

        // Evento que se dispara al hacer clic en el botón "Calcular".
        private void btnCalcuclar_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;

            // Obtiene el número total de productos en la lista.
            int TotalProductos = listCarritto.Items.Count;

            // Recorre la lista de productos.
            for (int i = 0; i < TotalProductos; i++)
            {
                string productoElegido = listCarritto.Items[i].ToString();

                // Calcula el precio final en función del producto seleccionado.
                if (productoElegido == "Pantalon")
                {
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

            // Verifica si se ingresó un código de descuento.
            if (codigoDescuento.Text == "NIKE")
            {
                // Aplica un descuento del 10% si el código es "NIKE".
                precioFinal = precioFinal * 0.9;
            }

            // Muestra un mensaje con el precio final.
            MessageBox.Show("El precio final es: $" + precioFinal);
        }

        // Evento del label (no contiene código en este ejemplo).
        private void label1_Click(object sender, EventArgs e)
        {
            // Puede dejar en blanco o agregar código adicional aquí.
        }
    }
}

using Arreglos.Modelos;
using Arreglos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        ProductoServicio productos = new ProductoServicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            Producto prod= new Producto();
            prod.ID= int.Parse(tbId.Text);
            prod.Nombre=tbNombre.Text;
            prod.Precio= double.Parse(tbPrecio.Text);
            prod.Descripcion=tbDescripcion.Text;
        }

        private void Mostrar()
        {
            dtgRegistro.DataSource = null;
            dtgRegistro.DataSource = productos.Productos();
        }
    }
}

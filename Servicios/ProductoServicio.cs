using Arreglos.Modelos;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Servicios
{
    internal class ProductoServicio
    {
        
        List<Producto> productos= new List<Producto> ();
        public List<Producto> Productos()  { return productos; }    

  
        public void AgregarProducto(Producto producto)
        {
            productos.Add (producto);
        }

        public Producto BuscarProducto (Producto producto)
        {
            return productos.Find(prod => prod.ID == producto.ID);
        }

        public void EliminarProducto (Producto producto)
        {
            
            productos.Remove (producto);
        }

        public void ActualizarProducto (Producto producto, int id)
        {
            productos.Remove(producto);
        }
       
    }
}

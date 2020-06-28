using System;
using System.Collections.Generic;
using System.Text;

namespace Deber_1_programacion
{
    class Enviado
    {
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }

        //comportamientos de la clases
        public string MarcaDeProducto(string Producto)
        {
            return $"Referencia del producto :{Producto} otros productos para en tregar : {this.Producto}";
        }
        public string NumeroDeProducto(string Cantidad)
        {
            return $"cantidad de producto que sale : {Cantidad} cantidad de producto que llega  :{this.Cantidad}";
        }
        public string CiudadDeDestino(string Ciudad)
        {
            return $"Ciudad de donde sale el pedido: {Ciudad} ciudad de llegada :{this.Ciudad}";
        }
        public string DireccionDondeDelEnvio(string Direccion)
        {
            return $"Direccion de salida del producto: {Direccion} destino de lleganda :{this.Direccion}";
        }
    }
}

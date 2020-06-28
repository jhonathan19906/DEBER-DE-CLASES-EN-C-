using System;
using System.Collections.Generic;
using System.Text;

namespace Deber_1_programacion
{
    class EntregaProducto
    {
        public string DuenoProducto { get; set; }
        public string EntregaCantidad { get; set; }
        public string CiudadDeLlegada { get; set; }
        public string TipoDeTransporte { get; set; }

        //comportamientos de la clases
        public string NombreDeDueno(string DuenoProducto)
        {
            return $"Quien resive el producto: {DuenoProducto} nombre del dueño : {this.DuenoProducto}";
        }
        public string CantidadDeProducto(string EntregaCantidad)
        {
            return $"numero de pedido o envio : {EntregaCantidad} codigo del envio : {this.EntregaCantidad}";
        }
        public string llega(string CiudadDeLlegada)
        {
            return $"ciudad de donde esta llevando el producto : {CiudadDeLlegada} ciudad de llegan los productos : {this.CiudadDeLlegada}";
        }
        public string registro(string TipoDeTransporte)
        {
            return $"Guia de transporte : {TipoDeTransporte} oficial de lleganda :{this.TipoDeTransporte}";
        }
    }
}

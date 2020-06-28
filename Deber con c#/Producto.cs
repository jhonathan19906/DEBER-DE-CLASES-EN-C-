using System;
using System.Collections.Generic;
using System.Text;

namespace Deber_1_programacion
{
    class Producto
    {
        public string ProdCodigo { get; set; }
        public string ProdMarca { get; set; }
        public string TipoProducto { get; set; }

        //comportamientos de la clases 
        public string ProductoCodigo(string Codigo)
        {
            return $"Codigo de producto: {Codigo} codigos similares de otros productos :{this.ProdCodigo}";
        }
        public string ProductoMarca(string Marca)
        {
            return $"Marca de productos: {Marca} otras marcas : {this.ProdMarca}";
        }
        public string TipoDeProducto(string TipoProducto)
        {
            return $"Presentacion de producto: {TipoProducto} otros presentaciones :{this.TipoProducto}";
        }
    }
}

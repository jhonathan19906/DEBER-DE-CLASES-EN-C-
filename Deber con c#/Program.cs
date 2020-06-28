using System;

namespace Deber_1_programacion
{
    class Program
    {
        public static bool ProdNombre { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO");

            //llamado a las clases persona

            string nombre = " Jhonathann";
            string apellido = " Chiliquinga ";
            string correo = "JJhona@mail.com ";
            string telefono = "  ";
           
            //instancia clases producto
            
            Producto productoVenta = new Producto
            {
                ProdCodigo = "C2G3B4 ",
                ProdMarca = "  Casfi Aspirina ",
                TipoProducto = "Aspirinas "
            };
            
            //clases porducto
            
            string pregunta1 = "J2H6O44 ";
            string pregunta2 = "Gelocatil 1kg ";
            string pregunta3 = " Adiro ";

            //clses envio
           
            Enviado pedido = new Enviado
            {
                Producto = " Aspirinas en tableta ",
                Cantidad = " 100 unidade de 50g",
                Ciudad = "   Guayaquil ",
                Direccion =" Avenida de las americas "
            };
            string envio = " Aspirinas  ";
            string envio1 = " 100 unidades ";
            string envio2 = " Quito ";
            string envio3 = "Avenida america y diez de agosto ";

            //clase entrega 
            
            EntregaProducto factura = new EntregaProducto
            {
                DuenoProducto = " Juan Onofa ",
                EntregaCantidad= "  2D5UG56N59 ",
                CiudadDeLlegada = " Guayaquil ",
                TipoDeTransporte = " Guayaqui avenida de las americas"
            };
            string producto = " Luis chile Gerente ";
            string producto1 = " 2D5UG56N59 ";
            string producto2 = " Quito  ";
            string producto3 = " 984974879";

            //clase persona 

            Persona primeraPersona = new Persona
            {
                  Nombre = nombre,
                  Apellido = apellido,
                  Correo = correo,
                  Telefono = telefono
            };            
            string pregunto = "Juan  ";
            string pregunto1 = " Onofa ";
            string pregunto2 = " 20394";
            string pregunto3 = " juan@hotmail.com";

            //clases persona
            
            string MiNombre = primeraPersona.MiNombre(pregunto);
            Console.WriteLine(MiNombre);
            string MiApellido = primeraPersona.MiApellido(pregunto1);
            Console.WriteLine(MiApellido);
            string MiCorreo = primeraPersona.MiCorreo(pregunto2);
            Console.WriteLine(MiCorreo);
            string MiNumero = primeraPersona.MiNumero(pregunto3);
            Console.WriteLine(MiNumero);
            
            // LA SEGUNDA CLASES 

            string ProdCodigo = productoVenta.ProductoCodigo(pregunta1);
            Console.WriteLine(ProdCodigo);
            string ProdMarca = productoVenta.ProductoMarca(pregunta2);
            Console.WriteLine(ProdMarca);
            string TipoProducto = productoVenta.TipoDeProducto(pregunta3);
            Console.WriteLine(TipoProducto);
            
            //clses envio 
            
            string Producto = pedido.MarcaDeProducto(envio);
            Console.WriteLine(Producto);
            string Cantidad = pedido.NumeroDeProducto(envio1);
            Console.WriteLine(Cantidad);
            string Ciudad = pedido.CiudadDeDestino(envio2);
            Console.WriteLine(Ciudad);
            string Direccion = pedido.DireccionDondeDelEnvio(envio3);
            Console.WriteLine(Direccion);

            //clase entrega
           
            string DuenoProducto = factura.NombreDeDueno(producto);
            Console.WriteLine(DuenoProducto);
            string CantidadDeProducto  = factura.CantidadDeProducto(producto1);
            Console.WriteLine(CantidadDeProducto);
            string CiudadDeLlegada = factura.llega(producto2);
            Console.WriteLine(CiudadDeLlegada);
            string TipoDeTransporte = factura.registro(producto3);
            Console.WriteLine(TipoDeTransporte);

            Console.ReadKey();
        }
    }
}

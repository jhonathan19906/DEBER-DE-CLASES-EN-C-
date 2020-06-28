using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Deber_1_programacion
{
    class Persona
    {
        //atributos de la clases 
        public string Nombre { get; set; }
         
        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        //comportamientos de la clases 
        public string MiNombre(string Nombre)
        {
            return $"Mi nombre es: { Nombre} un gusto cual es tu nombre : {this.Nombre}";
        }
        public string MiApellido(string Apellido)
        {
            return $"Mi Apellido es: {Apellido}  Y el tuyo :{this.Apellido }";
        }
        public string MiCorreo (string Correo)
        {
           return $"Mi correo es: {Correo} Y tu tienes correos :{this.Correo}";
        }
        public string MiNumero(string Telefono)
        {
            return $"Mi numero es :{Telefono} Y cual es tu numero de telefono :{ this.Telefono}";
        }
        
    }
}

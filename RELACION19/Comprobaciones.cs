using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RELACION19
{
    public static class Comprobaciones
    {

        public static byte ErroresMenuTV(string cadena)
        {

            // RECURSOS

            byte dato = 0;

            // VALIDACIIÓN

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
        
            // CONVERSIÓN

            dato = Convert.ToByte(cadena);

            // VALIDACIÓN MAXIMO

            if (dato > 3) throw new Exception("Opción maxima superada");
            

            // SALIDA

            return dato;
        
        }

    }
}

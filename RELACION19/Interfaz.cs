using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RELACION19
{
    public static class Interfaz
    {

        public static void MenuTipoVehiculo(Vehiculo[] lista)
        {
            // CONSTANTES


            // RECURSOS

            Vehiculo tipo;
            byte opcion;
            bool esValido;
            byte contador;
            string aux;

            // INICIALIZACIÓN

            aux = "";
            opcion = 0;
            contador = 0;
            esValido = true;

            // ENTRADA

            // Instanciar Objeto
             
            tipo = new Vehiculo();

           

            while ((contador < 5) && (!esValido)) 
            {

                Console.Write("Escriba el típo de vehóculo: ");

                // RESET

                esValido = false;

                switch (opcion)
                {
                    case 1:
                    esValido = true;
                        tipo.TipoTransporte = TipoVehiculo.turismo;
                        break;
                    case 2:
                    esValido = true;
                        tipo.TipoTransporte = TipoVehiculo.furgoneta;
                        break;
                    case 3:
                    esValido = true;
                        tipo.TipoTransporte = TipoVehiculo.camion;
                        break;
                }




                try
                {
                    opcion = Comprobaciones.ErroresMenuTV(aux);
                }
                catch(Exception error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {error.Message}");
                }

                lista[1] = tipo;
            }

            // PROCESO

            // SALIDA
        }

    }
}

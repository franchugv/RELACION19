using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RELACION19
{

    // ENUM

    /// <summary>
    /// Tipo Vehículo
    /// </summary>
    public enum TipoVehiculo : byte { turismo, furgoneta, camion };

    public enum Combustible : byte { diesel, hibrido, gasolida, electrico };

    public enum Estado : byte { nuevo, ocasion, segundamano };

    public class Vehiculo
    {

        // CONSTANTES

        private const int MARCA_MAX = 20;

        private const int MARCA_MIN = 3;



        private const int MODELO_MAX = 25;

        private const int MODELO_MIN = 4;



        private const int PRECIO_MAX = 1000000;

        private const int PRECIO_MIN = 1000;


        private const float descuento = 90;  // El descuento es la diferencia: 90 --> 10% de descuento


        private const int FEHCA_MAX = 10;



        // MIENBROS CLASE

        private string _marca;

        private string _modelo;

        private float _precioContado;

        private DateTime _matriculacion;

        private TipoVehiculo _TVehiculo;

        private Combustible _fuel;

        private Estado _estado;


        // CONSTRUCTORES

        public Vehiculo()
        {
            _marca = "Desconocido";
            _modelo = "Desconocido";
            TipoTransporte = TipoVehiculo.turismo;
            Fuel = Combustible.diesel;
            Estados = Estado.nuevo;
            PrecioContado = 0;
        }


        public Vehiculo(string mark, string model)
        {
            Marca = mark;
            Modelo = model;
            TipoTransporte = TipoVehiculo.turismo;
            Fuel = Combustible.diesel;
            Estados = Estado.nuevo;
            PrecioContado = 0;
        }



        // PROPIEDADES

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                // METODO

                ValidarCadenas(_marca, MARCA_MAX, MARCA_MIN);

                ValidaAlfaNumericos(_marca);

                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                // METODO

                ValidarCadenas(_modelo, MODELO_MAX, MODELO_MIN);

                ValidarCaracteresEspeciales(_modelo);


                _modelo = value;
            }
        }

        public float PrecioContado
        {
            get
            {
                return _precioContado;
            }

            set
            {

                ValidarNumeros(_precioContado, PRECIO_MAX, PRECIO_MIN);

                _precioContado = value;
            }
        }

        public float PrecioFinanciado
        {
            get
            {
                return PreciosFinanciado();
            }
        }

        public DateTime Matriculacion
        {
            get
            {
                return _matriculacion;
            }

            set
            {

                ValidarMatricula(_matriculacion);

                _matriculacion = value;
            }
        }

        public TipoVehiculo TipoTransporte
        {
            get
            {
                return _TVehiculo;
            }

            set
            {
                _TVehiculo = value;
            }
        }

        public Combustible Fuel
        {
            get
            {
                return _fuel;
            }

            set
            {
                _fuel = value;
            }
        }

        public Estado Estados
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        // MÉTODOS

        private static void ValidarCadenas(string dato, int MAX, int MIN)
        {
            if (dato.Length > MAX) throw new Exception("El número de caracteres es superior al rango de valores establecido");

            if (dato.Length < MIN) throw new Exception("El número de caracteres es inferior al rango de valores establecido");        
        }

        private static void ValidarNumeros(float dato, int MAX, int MIN)
        {
            if (dato > MAX) throw new Exception("El número es superior al rango de valores establecido");

            if (dato < MIN) throw new Exception("El número es inferior al rango de valores establecido");
        }


        #region validar el uso de caracteres y números

        private static void ValidarCaracteresEspeciales(string dato)
        {
            if (dato.All(char.IsSymbol)) throw new Exception("No está permitido el uso de los caracteres especiales."); 
        }

        private static void ValidaAlfaNumericos(string dato)
        {
            if ((dato.All(char.IsNumber)) || (dato.All(char.IsSymbol))) throw new Exception("No está perimitido el uso de numeros");
        }

        #endregion

        private float PreciosFinanciado()
        {

            // RECURSOS

            float PF = 0;

            // PROCESO

            PF = PrecioContado * 90 / 100;

            // SALIDA

            return PF;
        }
        
        private void ValidarMatricula(DateTime fecha)
        {


            DateTime fechaActual = DateTime.Now;


            DateTime FM = new DateTime (2222/02/02);

            // PROCESO

            //  No podrá establecerse una fecha posterior a la actual ni con una diferencia de 10 años


            if (fecha > fechaActual) throw new Exception("fecha superior a la actual");

            if (fecha.Year < (fechaActual.Year - FEHCA_MAX)) throw new Exception("fecha incorrecta");

        } 

    }
}

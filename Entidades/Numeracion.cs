using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistemas;
        private double valorNumerico;        

        public Numeracion(ESistema sistemas, string valorNumerico)
        {
            InicializarValores(sistemas, valorNumerico);
        }

        public Numeracion (ESistema sistemas, double valorNumerico)
        {
            this.sistemas = sistemas;
            this.valorNumerico = valorNumerico;
        }

        private void InicializarValores(ESistema sistemas, string valorNumerico)
        {
            this.sistemas = sistemas;
            double aux;
            double.TryParse(valorNumerico, out aux);
            this.valorNumerico = aux;
        }

        public ESistema Sistema { get { return sistemas; } }

        public string Valor { get { return this.valorNumerico.ToString(); } }       

        public static string DecimalABinario(int numeroEntero)
        {
            if (numeroEntero == 0)
            {
                return "0";
            }

            if (numeroEntero < 0)
            {
                throw new ArgumentException("El número entero debe ser mayor o igual a cero.");
            }

            string binario = "";
            while (numeroEntero > 0)
            {
                double residuo = numeroEntero % 2;
                binario = residuo + binario;
                numeroEntero = numeroEntero / 2;
            }

            return binario;
        }

        public static string DecimalABinario(string numeroEntero)
        {
            int.TryParse(numeroEntero, out int aux);
            if (aux == 0)
            {
                return "0";
            }

            if (aux < 0)
            {
                throw new ArgumentException("El número entero debe ser mayor o igual a cero.");
            }

            string binario = "";
            while (aux > 0)
            {
                double residuo = aux % 2;
                binario = residuo + binario;
                aux = aux / 2;
            }

            return binario;
        }

        public static double BinarioADecimal(string numeroBinario)
        {
            if (string.IsNullOrEmpty(numeroBinario))
            {
                throw new ArgumentException("El número binario no puede ser nulo o vacío.");
            }

            double decimalResult = 0;
            int exponente = 0;


            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    decimalResult += (double)Math.Pow(2, exponente);
                }
                else if (numeroBinario[i] != '0')
                {
                    throw new ArgumentException("El número binario contiene caracteres no válidos.");
                }

                exponente++;
            }

            return decimalResult;
        }

        public string ConvertirA(ESistema valor)
        {
            return valor == ESistema.Binario ? Numeracion.DecimalABinario(this.Valor) : this.Valor;            
        }

        public static double operator +(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) + double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }

        public static double operator -(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) - double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }

        public static double operator *(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) * double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }

        public static double operator /(Numeracion primerOperador, Numeracion segundoOperador)
        {
            
            return double.Parse(primerOperador.ConvertirA(ESistema.Decimal)) / double.Parse(segundoOperador.ConvertirA(ESistema.Decimal));
        }

        public static bool operator ==(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return primerOperador.Sistema == segundoOperador.Sistema;
        }

        public static bool operator !=(Numeracion primerOperador, Numeracion segundoOperador)
        {
            return !(primerOperador == segundoOperador);
        }

        public static bool operator ==(ESistema sistema, Numeracion primerOperador)
        {
            return sistema == primerOperador.Sistema;
        }

        public static bool operator !=(ESistema sistema, Numeracion primerOperador)
        {
            return !( sistema == primerOperador.Sistema );
        }

    }

    public enum ESistema
    {
        Binario,
        Decimal
    }
}

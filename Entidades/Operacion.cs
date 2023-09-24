using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando) 
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion GetPrimerOperando()
        {
            return this.primerOperando;
        }

        public void SetPrimerOperando(Numeracion primerOperando)
        {            
            this.primerOperando = primerOperando;
        }

        public Numeracion GetSegundoOperando()
        {
            return this.segundoOperando;
        }

        public void SetSegundoOperando(Numeracion segundoOperando)
        {
            this.segundoOperando = segundoOperando;
        }

        public  Numeracion Operar(char operador)
        {
            double resultado;

            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;
                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;
                case '/':
                    
                     resultado = this.primerOperando / this.segundoOperando;
                    break;
                  
                    
                default:
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
            }          
  
            return new Numeracion(ESistema.Decimal, resultado);
        }       
    }
}

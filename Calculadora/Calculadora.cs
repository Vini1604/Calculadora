using Calculadora.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    abstract class Calculadora
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public Calculadora()
        {

        }

        public Calculadora(decimal numero1, decimal numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        protected decimal Soma()
        {
            return Numero1 + Numero2;
        }
        protected decimal Subtracao()
        {
            return Numero1 - Numero2;
        }
        protected decimal Multiplicacao()
        {
            return Numero1 * Numero2;
        }
        protected decimal Divisao()
        {
            if (Numero2 == 0)
            {
                throw new DivideByZeroException("Nao e possivel dividir por zero");
            }
            
            return Numero1 / Numero2;
        }

        public abstract decimal ExecutaOperacao(OperacaoCalculadoraEnum operacao);
    }
}

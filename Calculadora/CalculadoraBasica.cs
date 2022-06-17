using Calculadora.Enums;
using Calculadora.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class CalculadoraBasica : Calculadora
    {

        public CalculadoraBasica()
        {
        }

        public CalculadoraBasica(decimal numero1, decimal numero2) : base(numero1, numero2)
        {
        }

        public override decimal ExecutaOperacao(OperacaoCalculadoraEnum operacao)
        {
            switch (operacao)
            {
                case OperacaoCalculadoraEnum.Soma:
                   return Soma();
                case OperacaoCalculadoraEnum.Subtracao:
                    return Subtracao();
                case OperacaoCalculadoraEnum.Multiplicacao:
                    return Multiplicacao();
                case OperacaoCalculadoraEnum.Divisao:
                    return Divisao();
                default:
                    throw new DomainException("Operacao nao reconhecida pela calculadora!!");
            }
        }
    }
}

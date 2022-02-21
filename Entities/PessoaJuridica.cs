using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstração.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumFuncionario { get; set; }

        public PessoaJuridica(int numFuncionario, string nome, double rendaAnual)
            : base(nome, rendaAnual)
        {
            NumFuncionario = numFuncionario;
        }

        public override double Imposto()
        {
            if(NumFuncionario > 10)
            {
                return RendaAnual * 14 / 100;
            }
            else
            {
                return RendaAnual * 16 / 100;
            }
        }
    }
}

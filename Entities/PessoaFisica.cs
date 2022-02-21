using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstração.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual)
            : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            return (RendaAnual * 25 / 100) - (GastosSaude * 50 / 100); 
        }
    }
}

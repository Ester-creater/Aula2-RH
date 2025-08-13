using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;


//Comentário 13/08/2025

namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int id{ get; set; }
        public string Nome  { get; set; }
        public string cpf { get; set; }
        public DateTime DataAdmissao  { get; set; }
        public decimal Salario  { get; set; }
        public TipoFuncionario TipoFuncionario { get; set; }


        public void ReajustarSalario()
        {
            Salario = Salario + (Salario*10/100);
        }

        public string ExibirperiodoExperiencia()
        {
            string periodoExperiencia =string.Format ("Periodo de Experiencia {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
            return periodoExperiencia;
        }
        
        public decimal CalcularDescontoVT(decimal percentual )
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }
    }
}
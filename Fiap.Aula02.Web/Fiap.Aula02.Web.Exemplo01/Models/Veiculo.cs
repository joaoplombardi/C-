using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Models
{
    public class Veiculo
    {
        public int ID { get; set; }

        public string Modelo { get; set; }
        public int Ano { get; set; }

        [Display(Name = "Automático")]
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }

        [DataType(DataType.Date), Display(Name ="Data de Cadastro")]
        public DateTime DataCompra { get; set; }
        public Combustivel Combustivel { get; set; }

        public string Cor { get; set; }
    }
}

    public enum Combustivel
    {
        Etanol, Gasolina, Flex, Diesel, Eletrico, Hibrido
    } 
/** Criar uma página para cadastrar o Veiculo (utilizando tag helpers)
 *  "Cadastrar" o veiculo em uma lista na controller
 *      private static IList<Veiculo> _banco;
 *  Criar uma página para listar todos os veiculos
 */

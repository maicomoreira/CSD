using System;
using Dominio.Repositorio.Interfaces;
namespace Dominio.Models
{
    public class Produto: IProduto
    {

        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}

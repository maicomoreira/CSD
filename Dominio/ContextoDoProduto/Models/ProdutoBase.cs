using System;
namespace Dominio.Models
{
    public abstract class ProdutoBase
    {
        public abstract string Nome { get; set; }
        public abstract decimal Preco { get; set; }
        public abstract string Salva();
    }
}

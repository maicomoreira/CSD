using System;
using System.Collections.Generic;
namespace Dominio.Repositorio.Interfaces
{
    public interface IProduto
    {
        string Nome { get; set; }
        decimal Preco { get; set; }
    }
}

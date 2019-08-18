using System;
using System.Collections.Generic;
namespace Dominio.Repositorio.Interfaces
{
    public interface IProdutoRepository
    {
        IProduto Get(int ProdutoId);
        IEnumerable<IProduto> Selecionar();
        bool Salvar(IProduto produto);
    }
}

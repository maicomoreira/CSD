using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using Dominio.Models;
using Rhino.Mocks;
using Rhino;
using System.Collections;
using Dominio.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Tests
{
    [TestFixture]
    public class TesteProduto__
    {

        private readonly IEnumerable<IProduto> _fakeProdutos = new List<IProduto>
        {
            new Produto {Nome="Carne", Preco= 9.50m},
            new Produto {Nome = "Leite", Preco = 2.30m},
            new Produto {Nome = "Ovos", Preco = 3.50m}
        };

        [Test()]
        public void TesteStubProdutoAbastract()
        {
            ProdutoBase produto = MockRepository.GenerateStub<ProdutoBase>();
            produto.Nome = "Teclado";
            produto.Preco = 34.50m;

            Assert.AreEqual(34.50m, produto.Preco);
        }

        [Test()]
        public void TesteStubProdutosIntefaces()
        {
            MockRepository mockRepository = new MockRepository();
            IProdutoRepository produtosRepository = mockRepository.Stub<IProdutoRepository>();

            using (mockRepository.Record())
            {
                SetupResult.For(produtosRepository.Selecionar()).Return(_fakeProdutos);
            }

            var resultados = produtosRepository.Selecionar();

            Assert.AreEqual(3, resultados.Count());
        }
    }
}

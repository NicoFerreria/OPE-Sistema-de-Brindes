using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Cadastros.Controles;
namespace TesteOph
{
    [TestClass]
    public class CadastroCliente
    {
        [TestMethod]
        public void TesteGravarNovoCliente()
        {
            FornecedorModelo fornecedor = new FornecedorModelo()
            {

            };

            FornecedorControle controle = new FornecedorControle();
            controle.GravarFornecedor(fornecedor);


        }
    }
}

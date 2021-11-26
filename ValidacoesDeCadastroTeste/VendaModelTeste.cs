using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Pedido;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacoesDeCadastroTeste
{
    [TestClass]
    public class VendaModelTeste
    {

        [TestMethod]
        public void Validar_se_TotalBruto_esta_calculando_corretamente()
        {
            var pedido = new VendaModel();
            pedido.Produtos.Add(
                new CarrinhoModel() { 
                    Quantidade = 10, 
                    PrecoVenda = 10 
                });
            pedido.Produtos.Add(
                new CarrinhoModel() { 
                    Quantidade = 5, 
                    PrecoVenda = 5 
                });
            var resultadoEsperado = 125;

            Assert.AreEqual(resultadoEsperado, pedido.TotalBruto);
        }

        [TestMethod]
        public void Validar_se_TotalDesconto_esta_calculando_corretamente()
        {
            var pedido = new VendaModel();
            pedido.Produtos.Add(
                new CarrinhoModel() { 
                    Quantidade = 10, 
                    Desconto = 10 
                });
            pedido.Produtos.Add(
                new CarrinhoModel() { 
                    Quantidade = 20, 
                    Desconto = 10 
                });
            pedido.Produtos.Add(
                new CarrinhoModel() { 
                Quantidade = 30, 
                    Desconto = 10 
                });

            var resultadoEsperado = 600;

            Assert.AreEqual(resultadoEsperado, pedido.TotalDesconto);
        }

        [TestMethod]

        public void Validar_se_TotalLiquido_esta_calculando_corretamente()
        {
            var pedido = new VendaModel();
            pedido.Produtos.Add(
                new CarrinhoModel()
                {
                    PrecoLiquido = 10,
                    Quantidade = 10,
                });
            pedido.Produtos.Add(
                new CarrinhoModel()
                {
                    PrecoLiquido = 20,
                    Quantidade = 5,
                });
            var resultadoEsperado = 200;
            Assert.AreEqual(resultadoEsperado, pedido.TotalLiquido);
        }

        [TestMethod]
        public void Validar_se_LucroTotal_esta_calculando_corretamente()
        {
            var pedido = new VendaModel();
            pedido.Produtos.Add(
                new CarrinhoModel()
                {
                    Total = 100,
                    Quantidade = 1,
                    PrecoCusto = 80,
                }) ;
            pedido.Produtos.Add(
                new CarrinhoModel()
                {
                    Total = 200,
                    Quantidade = 2,
                    PrecoCusto = 80,
                });
            var resultadoEsperado = 60;
            Assert.AreEqual(resultadoEsperado, pedido.LucroTotal);
        }
    }
}

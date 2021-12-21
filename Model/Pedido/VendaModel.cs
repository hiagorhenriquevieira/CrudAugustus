using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Enums;
using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CrudAugustusFashion.Model.Pedido
{
    public class VendaModel
    {

        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public Dinheiro TotalBruto { get => Produtos.Sum(x => x.PrecoVenda.Valor * x.Quantidade); }
        public Dinheiro TotalDesconto { get => Produtos.Sum(x => x.Quantidade * x.Desconto.Valor); }
        public Dinheiro TotalLiquido { get => Produtos.Sum(x => x.PrecoLiquido.Valor * x.Quantidade); }
        public Dinheiro LucroTotal { get => Produtos.Sum(x => x.Total.Valor - (x.Quantidade * x.PrecoCusto.Valor)); }
        public EFormaDePagamento FormaDePagamento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataEmissao { get; set; }
        public Dinheiro LiquidoPreAlteracao { get; set; }

        public ContasAReceberModel Conta { get; set; }
        public List<CarrinhoModel> Produtos { get; set; }
        public EFormaDePagamento PagamentoPreAlteracao { get; set; }

        public VendaModel()
        {
            Produtos = new List<CarrinhoModel>();
            Conta = new ContasAReceberModel();
        }

        public void AdicionarProdutoCarrinho(CarrinhoModel produto)
        {
            var indice = RetornarValorIndexCarrinho(produto.IdProduto);

            if (indice != -1)
                AlterarProduto(indice, produto);
            else
                Produtos.Add(produto);
        }
        public void AlterarProduto(int index, CarrinhoModel produtoComDadosNovos)
        {
            Produtos[index].Quantidade = produtoComDadosNovos.Quantidade;
            Produtos[index].Desconto = produtoComDadosNovos.Desconto.Valor;
        }

        public CarrinhoModel RetornarProdutoCarrinho(CarrinhoModel produto)
        {
            return produto;
        }

        public string GerarSql()
        {
           
            if (VerificarFormaDePagamentoCompra())
                return @" Insert into ContasAReceber(IdVenda, ValorAPagar)
                                                 values(@IdVenda, @ValorAPagar) ";
            return " delete ContasAReceber  where IdVenda = @IdVenda ";
        }

        private bool VerificarFormaDePagamentoCompra()
        {
            return FormaDePagamento == EFormaDePagamento.APRAZO && PagamentoPreAlteracao != EFormaDePagamento.APRAZO;             
        }

        public string GetEnumDescription<T>(T value) where T : Enum
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
        public DynamicParameters RecuperarParametros()
        {
            
            var parameters = new DynamicParameters();

            parameters.AddDynamicParams(
                new
                {
                    IdVenda,
                    FormaDePagamento,
                    ValorAPagar = Conta.ValorAPagar.Valor,
                }
                );

            return parameters;
        }public DynamicParameters PassarParametros()
        {
            
            var parameters = new DynamicParameters();

            parameters.AddDynamicParams(
                new
                {
                    IdVenda,
                }
                );

            return parameters;
        }



        public int RetornarValorIndexCarrinho(int id)
        => Produtos.FindIndex(x => x.IdProduto == id);


    }
}

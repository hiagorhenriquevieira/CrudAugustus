using CrudAugustusFashion.Model.ContasAReceberModel;
using CrudAugustusFashion.Model.Produto;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    class PedidoDao
    {
        public List<ProdutoLista> BuscarProdutoParaVenda(string nome)
        {
            const string selectProduto = @"Select IdProduto, CodigoDeBarras, Nome, Fabricante, PrecoCusto, PrecoVenda, QuantidadeEstoque
                                           from Produtos
                                           where Nome Like @Nome + '%' and Status = 1";
            using (var conexao = ConexaoDao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome }).ToList();
            }
        }

        internal List<ListaDeContasAReceberModel> ListarComprasAPrazo(string text, bool ativo)
        {
            const string selectPedido = @"select c.IdCliente, Concat (u.Nome, ' ', u.SobreNome) as NomeCompleto ,cr.ValorAPagar , v.FormaDePagamento, v.DataEmissao, cr.Ativo
                                            from venda v
                                            inner join Clientes c on v.IdCliente = c.IdCliente
                                            inner join Usuarios u on c.IdUsuario = u.IdUsuario
                                            inner join ContasAReceber cr on v.IdVenda = cr.IdVenda
                                            where u.Nome like @Nome + '%' and cr.ativo = @Ativo;";

            using (var conexao = ConexaoDao.conectar())
            {
                return conexao.Query<ListaDeContasAReceberModel>(selectPedido, new { Nome = text, ativo }).ToList();
            }
        }
    }
}

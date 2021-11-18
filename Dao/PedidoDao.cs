using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.Usuario;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Dao
{
    class PedidoDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public List<ProdutoLista> BuscarProdutoParaVenda(string nome)
        {
            const string selectProduto = @"Select IdProduto, CodigoDeBarras, Nome, Fabricante, PrecoCusto, PrecoVenda, QuantidadeEstoque
                                           from Produtos
                                           where Nome Like @Nome + '%' and Status = 1";
            using (var conexao = this.conexao.conectar())
            {
                return conexao.Query<ProdutoLista>(selectProduto, new { Nome = nome }).ToList();
            }
        }

        public List<ColaboradorListaModel> BuscarColaboradorPedido()
        {
            var sqlSelect = @"select co.IdColaborador, co.Salario, co.PorcentagemComissao,
                        co.IdUsuario, u.IdUsuario, u.Sexo, u.DataNascimento,
                        co.IdUsuario, u.Nome, u.SobreNome,
                        co.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                        from
                        Usuarios u inner join Colaboradores co on u.IdUsuario = co.IdUsuario
                        inner join Endereco e on co.IdUsuario = e.IdUsuario
                        inner join ContasBancarias cb on co.IdColaborador = cb.IdColaborador
                        inner join Telefone t on co.IdUsuario = t.IdUsuario;";

            try
            {
                using (var con = conexao.conectar())
                {
                    return con.Query<ColaboradorListaModel, NomeCompleto, TelefoneModel, ColaboradorListaModel>(
                        sqlSelect,
                        (colaboradorListaModel, nomeCompleto, telefoneModel) => MapearListaColaborador(colaboradorListaModel, nomeCompleto, telefoneModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private ColaboradorListaModel MapearListaColaborador(ColaboradorListaModel colaboradorListaModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel)
        {
            colaboradorListaModel.NomeCompleto = nomeCompleto;
            colaboradorListaModel.Telefone = telefoneModel;
            return colaboradorListaModel;
        }
    }
}

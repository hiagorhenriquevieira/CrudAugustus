using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Controller.EmailController
{
    public class EnvioDeEmail
    {
        private ClienteDao _clienteDao;
        private ClienteModel _clienteModel;
        private VendaModel _vendaModel;

        public EnvioDeEmail()
        {
            _clienteDao = new ClienteDao();
            _clienteModel = new ClienteModel();
            _vendaModel = new VendaModel();
        }
        public void EnviarEmail(VendaModel venda , ClienteModel cliente)
        {

            try
            {

                MailMessage mailMessage = new MailMessage("hiagorhenrique1@gmail.com", cliente.Email);

                mailMessage.Subject = $"Confirmação da raealização da compra em AugustusFashion.";

                StringBuilder mensagem = new StringBuilder();

                mensagem.Append($"Olá, {cliente.NomeCompleto.Nome}!");
                mensagem.AppendLine();
                mensagem.AppendLine();
                mensagem.Append($"E-mail de confirmação do seu pedido.");
                mensagem.AppendLine();
                mensagem.Append("itens adquiridos através da compra:");
                foreach (var item in venda.Produtos)
                {
                    mensagem.Append($"\t {item.Quantidade}u  {item.Nome}: {item.PrecoLiquido}");
                    mensagem.AppendLine();
                }
                mensagem.Append("Agradecemos por comprar com AugustusFashion, Volte sempre.");
                mensagem.AppendLine();
                mensagem.AppendLine();
                mailMessage.Body = mensagem.ToString();
                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("hiagorhenrique1@gmail.com", "kotagamer1");

                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);

                Console.WriteLine("Seu email foi enviado com sucesso! :)");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro no envio do email :(");
                Console.ReadLine();
            }
        }

        //public void CorpoMensagem(VendaModel venda, ClienteModel cliente)
        //{
        //    StringBuilder mensagem = new StringBuilder();

        //    mensagem.Append($"Olá, {cliente.NomeCompleto.Nome}!");
        //    mensagem.AppendLine();
        //    mensagem.AppendLine();
        //    mensagem.Append($"E-mail de confirmação do seu pedido.");
        //    mensagem.AppendLine();
        //    mensagem.Append("itens adquiridos através da compra:");
        //    foreach(var item in venda.Produtos)
        //    {
        //        mensagem.Append($"\t {item.Quantidade}u  {item.Nome}: {item.PrecoLiquido}");
        //        mensagem.AppendLine();
        //    }
        //    mensagem.Append("Agradecemos por comprar com AugustusFashion, Volte sempre.");
        //    mensagem.AppendLine();
        //    mensagem.AppendLine();

        //}

        //public void RecuperarDadosCliente(int idCliente)
        //{
        //    try
        //    {
        //       var cliente = _clienteDao.RecuperarDadosCliente(idCliente);
        //        _clienteModel.Email = cliente.Email;
        //        _clienteModel.NomeCompleto.Nome = cliente.NomeCompleto.Nome;
        //        _clienteModel.NomeCompleto.SobreNome = cliente.NomeCompleto.SobreNome;
        //        _clienteModel.IdCliente = cliente.IdCliente;
        //        _clienteModel.IdUsuario = cliente.IdUsuario;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //public void RecuperarDadosVenda(int idVenda)
        //{
        //    var venda = new VendaDao().ExibirPedidoSelecionado(idVenda);
        //    _vendaModel.IdVenda = venda;
        //foreach(item in venda.Produtos)
        //{
        //_vendaModel.Produtos = venda.Produtos;
        //}


    }
}

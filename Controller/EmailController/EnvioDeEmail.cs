using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Pedido;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CrudAugustusFashion.Controller.EmailController
{
    public class EnvioDeEmail
    {
        public EnvioDeEmail()
        {
           
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
                mensagem.AppendLine();
                foreach (var item in venda.Produtos)
                {
                    mensagem.Append($"\t {item.Quantidade}u  {item.Nome}: {item.PrecoLiquido}");
                    mensagem.AppendLine();
                }
                mensagem.Append($"Valor total da compra = {venda.TotalLiquido}");
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
    }
}

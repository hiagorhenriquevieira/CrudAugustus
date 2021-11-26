using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Pedido;
using CrudAugustusFashion.Validacoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacoesDeCadastroTeste
{
    [TestClass]
    public class ValidacoesCadastrosTestes
    {
        [TestMethod]
        public void Validar_se_nome_for_invalido_deve_retornar_true()
        {
            string nome = "asdv35";

            var retorno = ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(nome);

            Assert.IsTrue(retorno);
        }

        [DataTestMethod]
        [DataRow("asjask3", true)]
        [DataRow("as()", false)]
        [DataRow("sksksj", false)]
        [DataRow("", true)]

        public void Validar_se_nome_for_invalido(string nome, bool resultado) =>
            Assert.AreEqual(ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(nome), resultado);

        [DataTestMethod]
        [DataRow("01234567890", true)]
        [DataRow("299484588692", false)]
        [DataRow("1234567891", false)]

        public void Validar_se_cpf_for_valido(string numero, bool resultado) =>
            Assert.AreEqual(ValidacoesExtencion.ValidarCpf(numero), resultado);


        [DataTestMethod]
        [DataRow("214", false)]
        [DataRow("adsd", true)]
        [DataRow("00cvc", true)]
        [DataRow("^sd12", true)]
        [DataRow("^{`^Ç^}125", true)]

        public void Validar_se_campos_nao_contem_letras(string numero, bool resultado) =>
            Assert.AreEqual(ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(numero), resultado);


        [DataTestMethod]
        [DataRow("teste@gmail.com", true)]
        [DataRow("skfdksk@gmail", false)]
        [DataRow("ssdasd323", false)]
        [DataRow("gkskkkfk@gmail.c", false)]
        public void Validar_se_email_eh_valido(string email, bool resultado) =>
            Assert.AreEqual(ValidacoesExtencion.ValidarEmail(email), resultado);

    }
}

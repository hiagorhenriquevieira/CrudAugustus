namespace CrudAugustusFashion.Validacoes
{
    public static class ValidacoesCadastros
    {
        public static bool ValidarSeStringNaoPossuiNumeros(string nome) => !nome.ValidarApenasCaracteres();

        public static bool ValidarSeIntNaoPossuiLetras(string numero) => !numero.ValidarApenasNumeros();
    }
}

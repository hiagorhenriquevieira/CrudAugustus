namespace CrudAugustusFashion.Model
{
    public class ContaBancariaModel
    {
        public int Id { get; set; }
        public string TipoConta { get; set; }
        public int Conta { get; set; }
        public int Agencia { get; set; }
        public string Banco { get; set; }
    }
}
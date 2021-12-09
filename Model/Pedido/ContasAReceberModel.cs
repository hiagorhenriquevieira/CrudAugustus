using CrudAugustusFashion.Model.Produto;

namespace CrudAugustusFashion.Model.Pedido
{
    public class ContasAReceberModel
    {
        public int IdContasAReceber { get; set; }
        public int IdVenda { get; set; }
        public int Ativo { get; set; }
        public Dinheiro ValorAPagar  { get; set; }
    }
}
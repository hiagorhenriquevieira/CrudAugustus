using System.ComponentModel;

namespace CrudAugustusFashion.Enums
{
    public enum EOrdenarPor
    {
        [Description (" Order by QuantidadeVendas ")]
        Quantidade,
        [Description (" Order by TotalDesconto ")]
        TotalDesconto,
        [Description (" Order by TotalLiquido ")]
        TotalLiquido

    }
}

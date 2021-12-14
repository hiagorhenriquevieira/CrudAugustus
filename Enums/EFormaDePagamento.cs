using System.ComponentModel;

namespace CrudAugustusFashion.Enums
{
    public enum EFormaDePagamento
    {
        [Description("AVISTA")]
        AVISTA,
        [Description("APRAZO")]
        APRAZO,
        [Description("DEBITO")]
        DEBITO,
        [Description("CREDITO")]
        CREDITO
    }
}

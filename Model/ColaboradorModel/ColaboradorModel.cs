using CrudAugustusFashion.Model.Usuario; 

namespace CrudAugustusFashion.Model
{
    public class ColaboradorModel : UsuarioModel
    {
        public int IdColaborador { get; set; }
        public int Salario { get; set; }
        public int PorcentagemComissao { get; set; }
        public ContaBancariaModel ContasBancarias { get; set; }
        public bool Ativo { get; set; }
        public ColaboradorModel()
        {
            ContasBancarias = new ContaBancariaModel();
        }

    }
}

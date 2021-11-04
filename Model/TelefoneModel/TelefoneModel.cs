
namespace CrudAugustusFashion.Model
{
    public class TelefoneModel 
    {
        public int IdUsuario { get; set; }
        public int IdTelefone { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public override string ToString()
        {
            return $"Telefone: {Telefone} Celular: {Celular}";
        }
    }
}

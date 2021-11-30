namespace CrudAugustusFashion.Model.Usuario
{
    public class NomeCompleto
    {
        public NomeCompleto(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public override string ToString()
        {
            return $"{Nome} {SobreNome}";
        }

        public NomeCompleto()
        {

        }
    }
}

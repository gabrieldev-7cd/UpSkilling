namespace WindowsFormsUPSKILLINGGAMA.Models
{
    public class ClienteModel : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ClienteModel() {}

        public ClienteModel(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
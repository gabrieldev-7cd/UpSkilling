namespace WindowsFormsUPSKILLINGGAMA.Models
{
    public class VeiculoModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int TipoServico { get; set; }

        public VeiculoModel() {}

        public VeiculoModel(int id, int idcliente, string marca, string modelo, string placa, int tipoServico)
        {
            Id = id;
            IdCliente = idcliente;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            TipoServico = tipoServico;
        }
    }
}

using System;

namespace WindowsFormsUPSKILLINGGAMA.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; } = "";

        public TicketModel() {}

        public TicketModel(int id, int idVeiculo)
        {
            Id = id;
            IdVeiculo = idVeiculo;
            DataEntrada = DateTime.Now.ToString();
        }
    }
}

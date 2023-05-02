using System;

namespace WindowsFormsUPSKILLINGGAMA.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; } = null;

        public TicketModel() {}

        public TicketModel(int id, int idVeiculo)
        {
            Id = id;
            IdVeiculo = idVeiculo;
            DataEntrada = DateTime.Now;
        }
    }
}

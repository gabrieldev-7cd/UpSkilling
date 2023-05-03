using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Models.DTO;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class TicketService : ITicketService
    {
        private readonly GenericRepository<TicketModel> _ticketRepository;
        private readonly GenericRepository<VeiculoModel> _veiculoRepository;

        public TicketService(TipoBaseEnum driver)
        {
            _ticketRepository = ConfigurationBase<TicketModel>.SelecionaDriver(driver);
            _veiculoRepository = ConfigurationBase<VeiculoModel>.SelecionaDriver(driver);
        }

        public List<TicketModel> Listar()
        {
           return _ticketRepository.Listar();
        }

        public TicketModel Recuperar(int id)
        {
            return _ticketRepository.Recuperar(id);
        }

        public TicketModel Cadastrar(int idveiculo, DateTime dataEntrada)
        {
           TicketModel novoTicket = new TicketModel(_ticketRepository.ObterId(), idveiculo);
            novoTicket.DataEntrada = dataEntrada.ToString();

            _ticketRepository.Cadastrar(novoTicket);

            return novoTicket;
        }

        public TicketModel Alterar(int id, int idveiculo, DateTime dataCadastro, DateTime? dataSaida)
        {
            TicketModel ticket = new TicketModel(id, idveiculo);
            ticket.DataEntrada = dataCadastro.ToString();
            ticket.DataSaida = dataSaida.ToString();

            _ticketRepository.Alterar(ticket);
            return ticket;
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public bool VeiculoEstacionado(int idVeiculo)
        {
            var veiculos = _ticketRepository.Listar();

            if (veiculos.Where(x => x.IdVeiculo.Equals(idVeiculo) && x.DataSaida == "").ToList().Any()) return true;

            return false;
        }

        //Calcula o valor do estacionamento de acordo com o tipo de serviço contratado.
        public double CalculaTotalTicket(TicketModel ticket, ContextoOpcao contexto)
        {
            double valorTotal = 0D;

            var tipoServicoVeiculo = (TipoServicoEnum)_veiculoRepository.Recuperar(ticket.IdVeiculo).TipoServico;

            //Se o ticket não foi finalizado o valor vai ser processado a partir da data de início até o atual momento.
            var diff = DateTime.Parse((ticket.DataSaida.Equals("") ? DateTime.Now.ToString() : ticket.DataSaida)).Subtract(DateTime.Parse(ticket.DataEntrada));

            switch(tipoServicoVeiculo)
            {
                case TipoServicoEnum.Mensalista:
                    if(diff.TotalDays > 30) return valorTotal = (diff.TotalDays / 30) * contexto.ValorTarifaMesalidade;
                    return contexto.ValorTarifaMesalidade;

                case TipoServicoEnum.Diaria:
                    if (diff.TotalDays > 1) return valorTotal = diff.TotalDays * contexto.ValorTarifaDiaria;
                    return contexto.ValorTarifaDiaria;
                

                case TipoServicoEnum.Hora:
                    if (diff.TotalHours > 1) return valorTotal = diff.TotalHours * contexto.ValorTarifaHora;
                    return contexto.ValorTarifaHora;

                default:
                    return valorTotal;
            }
        }

        public List<ListaVendasDto> listagemVendas(ContextoOpcao contexto)
        {
            List<ListaVendasDto> lista = new List<ListaVendasDto>();
            var tickets = Listar();

            foreach(var ticket in tickets)
            {
                var veiculo = _veiculoRepository.Recuperar(ticket.IdVeiculo);
                var registro = new ListaVendasDto();
                registro.Id = ticket.Id;
                registro.DataEntrada = ticket.DataEntrada;
                registro.DataSaida = ticket.DataSaida;
                registro.Veiculo = $"Fab:{veiculo.Marca} Mod: {veiculo.Modelo}";
                registro.Placa = veiculo.Placa;
                registro.Valor = $"R$ {CalculaTotalTicket(ticket, contexto).ToString("N2")}";
                lista.Add(registro);
            }

            return lista;
        }
    }
}

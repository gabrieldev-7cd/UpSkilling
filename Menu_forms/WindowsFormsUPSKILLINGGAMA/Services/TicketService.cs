using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class TicketService : ITicketService
    {
        private readonly GenericRepository<TicketModel> _ticketRepository;

        public TicketService(TipoBaseEnum driver)
        {
            _ticketRepository = ConfigurationBase<TicketModel>.SelecionaDriver(driver);
        }

        public List<TicketModel> Listar()
        {
           return _ticketRepository.Listar();
        }

        public TicketModel Recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Cadastrar(int idveiculo)
        {
           TicketModel novoTicket = new TicketModel(_ticketRepository.ObterId(), idveiculo);

           return _ticketRepository.Cadastrar(novoTicket);
        }

        public bool Alterar(int id, int idveiculo, DateTime dataCadastro, DateTime? dataSaida)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }


    }
}

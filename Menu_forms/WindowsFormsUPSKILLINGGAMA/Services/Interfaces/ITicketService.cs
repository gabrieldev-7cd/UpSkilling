
using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA.Services.Interfaces
{
    public interface ITicketService
    {
        List<TicketModel> Listar();
        TicketModel Recuperar(int id);
        TicketModel Cadastrar(int idveiculo, DateTime dataEntrada);
        TicketModel Alterar(int id, int idveiculo, DateTime dataCadastro, DateTime? dataSaida);
        bool Excluir(int id);
    }
}

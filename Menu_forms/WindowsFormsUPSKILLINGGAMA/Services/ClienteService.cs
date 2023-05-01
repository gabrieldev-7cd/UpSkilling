using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class ClienteService : IClienteService
    {
        private readonly GenericRepository<ClienteModel> _clienteRepository;

        public ClienteService(TipoBaseEnum driver)
        {
            _clienteRepository = ConfigurationBase<ClienteModel>.SelecionaDriver(driver);
        }

        public List<ClienteModel> Listar()
        {
            return _clienteRepository.Listar();
        }

        public ClienteModel Recuperar(int id)
        {
            return _clienteRepository.Recuperar(id);
        }

        public bool Cadastrar(string nome, string telefone)
        {
            int id = _clienteRepository.ObterId();
            ClienteModel novoCliente = new ClienteModel(id, nome, telefone);

            return _clienteRepository.Cadastrar(novoCliente);
        }

        public bool Alterar(string nome, string telefone)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            return _clienteRepository.Excluir(id);
        }
    }
}

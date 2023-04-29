using System;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class ClienteService<ClienteModel> : IBaseService<ClienteModel>
    {
        private readonly GenericRepository<ClienteModel> _clienteRepository;

        public ClienteService(TipoBaseEnum driver)
        {
            ConfigurationBase<ClienteModel>.SelecionaDriver(driver);
        }

        public List<ClienteModel> Listar(ClienteModel entity)
        {
            throw new NotImplementedException();
        }
        public ClienteModel Recuperar(ClienteModel entity)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Cadastrar(ClienteModel entity)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Alterar(ClienteModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(ClienteModel entity)
        {
            throw new NotImplementedException();
        }
    }
}

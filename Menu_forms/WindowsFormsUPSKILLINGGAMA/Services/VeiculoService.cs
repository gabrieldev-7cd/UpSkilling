using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.Models.DTO;

namespace WindowsFormsUPSKILLINGGAMA.Services
{
    public class VeiculoService : IVeiculosService
    {
        private readonly GenericRepository<VeiculoModel> _veiculoRepository;

        public VeiculoService(TipoBaseEnum driver)
        {
            _veiculoRepository = ConfigurationBase<VeiculoModel>.SelecionaDriver(driver);

        }
        public List<VeiculoModel> Listar()
        {
            return _veiculoRepository.Listar();
        }

        public VeiculoModel Recuperar(int id)
        {
            return _veiculoRepository.Recuperar(id);
        }

        public bool Cadastrar(string marca, string modelo, string placa, int tipo_servico, int idcliente)
        {
            int id = _veiculoRepository.ObterId();
            VeiculoModel novoVeiculo = new VeiculoModel(id, idcliente, marca, modelo, placa, tipo_servico);

            _veiculoRepository.Cadastrar(novoVeiculo);
            return true;
        }

        public bool Alterar(int id, string marca, string modelo, string placa, int tipo_servico, int idcliente)
        {
            VeiculoModel novoVeiculo = new VeiculoModel(id, idcliente, marca, modelo, placa, tipo_servico);

            _veiculoRepository.Alterar(novoVeiculo);
            return true;
        }


        public bool Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ListaVeiculoDto> VeiculoLista()
        {
            return new List<ListaVeiculoDto>();
        }
    }
}

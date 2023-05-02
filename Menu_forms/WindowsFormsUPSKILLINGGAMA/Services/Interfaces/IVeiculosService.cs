using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA.Services.Interfaces
{
    public interface IVeiculosService
    {
        List<VeiculoModel> Listar();
        VeiculoModel Recuperar(int id);
        bool Cadastrar(string marca, string modelo, string placa, int tipo_servico, int idcliente);
        bool Alterar(int id, string marca, string modelo, string placa, int tipo_servico, int idcliente);
        bool Excluir(int id);
    }
}

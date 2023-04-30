
using System.Collections.Generic;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA.Services.Interfaces
{
    public interface IClienteService
    {
        List<ClienteModel> Listar();
        ClienteModel Recuperar(int id);
        bool Cadastrar(string nome, string telefone);
        bool Alterar(string nome, string telefone);
        bool Excluir(int id);
    }
}

using WindowsFormsUPSKILLINGGAMA.Configurations;

namespace WindowsFormsUPSKILLINGGAMA.Models
{
    // Classe que guarda as opcoes de contexto do usuario
    public class ContextoOpcao
    {
        public TipoServicoEnum Servico { get; set; }

        public TipoBaseEnum TipoBaseSelecionada { get; set; }

        public double ValorTarifaMinuto = 0.05D;
        public double ValorTarifaHora = 1D;
        public double ValorTarifaDiaria = 5D;
        public double ValorTarifaMesalidade = 70D;
    }
}

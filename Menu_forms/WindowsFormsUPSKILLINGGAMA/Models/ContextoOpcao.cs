using WindowsFormsUPSKILLINGGAMA.Configurations;

namespace WindowsFormsUPSKILLINGGAMA.Models
{
    // Classe que guarda as opcoes de contexto do usuario
    public class ContextoOpcao
    {
        public TipoServicoEnum Servico { get; set; }

        public TipoBaseEnum TipoBaseSelecionada { get; set; }

        public float ValorTarifa = 1F;
    }
}

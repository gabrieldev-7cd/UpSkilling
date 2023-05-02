using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_Historico_Vendas : Form
    {
        private readonly VeiculoService _veiculoService;
        private readonly TicketService  _ticketService;

        public frm_Historico_Vendas(ContextoOpcao contexto)
        {
            _ticketService = new TicketService(contexto.TipoBaseSelecionada);
            _veiculoService = new VeiculoService(contexto.TipoBaseSelecionada);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_hist_vendas_Load(object sender, EventArgs e)
        {
            string[] serviceOptions = Enum.GetNames(typeof(TipoServicoEnum)).ToArray();
            //Carrega as opções do painel de seleção de tipo de serviço.
            BindingSource bSource = new BindingSource();
            bSource.DataSource = serviceOptions;
            cb_fil_servico.DataSource = bSource.DataSource;

            AtualizarDados();
        }

        private void AtualizarDados()
        {
            BindingSource dataBinding = new BindingSource();
            dataBinding.DataSource = _ticketService.Listar();
            dataGridTickets.DataSource = dataBinding;
            dataGridTickets.AllowUserToAddRows = false;
        }
        private void cb_fil_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o tipo de serviço selecionado no ComboBox
            foreach (var tipoServico in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                
            }
        }

        private void dataGridTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource dataBinding = new BindingSource();
            dataBinding.DataSource = _ticketService.Listar();
            dataGridTickets.DataSource = dataBinding;
            dataGridTickets.AllowUserToAddRows = false;
        }

        private void btn_voltar_hist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voltar ao Menu Principal?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

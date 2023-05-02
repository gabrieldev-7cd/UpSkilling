using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_Menu_Principal : Form
    {
        private ContextoOpcao contextoOpcao = new ContextoOpcao();

        public frm_Menu_Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_cdt_clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes frm = new frm_Clientes(contextoOpcao);
            frm.Show();
        }

        private void btn_cdt_veiculos_Click(object sender, EventArgs e)
        {
            frm_Veiculos frm = new frm_Veiculos(contextoOpcao);
            frm.Show();
        }

        private void btn_hist_vendas_Click(object sender, EventArgs e)
        {
            frm_Historico_Vendas frm = new frm_Historico_Vendas(contextoOpcao);
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clientes frm = new frm_Clientes(contextoOpcao);
            frm.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Veiculos frm = new frm_Veiculos(contextoOpcao);
            frm.Show();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            string[] baseOptions = Enum.GetNames(typeof(TipoBaseEnum)).ToArray();
            //Carrega as opções do painel de seleção de tipo base.
            BindingSource bSource = new BindingSource();
            bSource.DataSource = baseOptions;
            comboBox1.DataSource = bSource.DataSource;
        }

        private void selecao_base_Click(object sender, EventArgs e)
        {
            var opcao = comboBox1.SelectedIndex;
            contextoOpcao.TipoBaseSelecionada = (TipoBaseEnum)opcao; // opcao passada pelo index.
            panel1.Hide();
        }

        private void btn_cad_ticket_Click(object sender, EventArgs e)
        {
            frm_Ticket frm = new frm_Ticket();
            frm.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Historico_Vendas frm = new frm_Historico_Vendas(contextoOpcao);
            frm.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ticket frm = new frm_Ticket();
            frm.Show();
        }
    }
}

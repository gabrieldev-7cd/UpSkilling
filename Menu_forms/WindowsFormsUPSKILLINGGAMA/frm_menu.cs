using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_menu : Form
    {
        private ContextoOpcao contextoOpcao = new ContextoOpcao();

        public frm_menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_cdt_clientes_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes(contextoOpcao);
            frm.Show();
        }

        private void btn_cdt_veiculos_Click(object sender, EventArgs e)
        {
            frm_veiculos frm = new frm_veiculos(contextoOpcao);
            frm.Show();
        }

        private void btn_hist_vendas_Click(object sender, EventArgs e)
        {
            frm_hist_vendas frm = new frm_hist_vendas(contextoOpcao);
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes(contextoOpcao);
            frm.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_veiculos frm = new frm_veiculos(contextoOpcao);
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
            frm_ticket frm = new frm_ticket();
            frm.Show();
        }
    }
}

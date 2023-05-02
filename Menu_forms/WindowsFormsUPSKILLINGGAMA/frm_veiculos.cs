using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_veiculos : Form
    {
        private readonly VeiculoService _veiculoService;
        private readonly ClienteService _clienteService;

        public frm_veiculos(ContextoOpcao contexto)
        {
            _veiculoService = new VeiculoService(contexto.TipoBaseSelecionada);
            _clienteService = new ClienteService(contexto.TipoBaseSelecionada);

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            VeiculoModel veiculo = new VeiculoModel();

            veiculo.Modelo = this.txt_modelo.Text;
            veiculo.Placa = this.txt_placa.Text;

            _veiculoService.Cadastrar(
                txt_marca.Text,
                txt_modelo.Text,
                txt_placa.Text,
                selectServico.SelectedIndex, 
                (int)cb_id_cliente.SelectedValue
            );

            txt_marca.Text = string.Empty;
            txt_modelo.Text = string.Empty;
            txt_placa.Text = string.Empty;

            MessageBox.Show("Veículo cadastrado com sucesso!");
            AtualizarDados();
        }

        private void frm_veiculos_Load(object sender, EventArgs e)
        {
            AtualizarDados();

            string[] serviceOptions = Enum.GetNames(typeof(TipoServicoEnum)).ToArray();
            //Carrega as opções do painel de seleção de tipo de serviço.
            BindingSource bSource = new BindingSource();
            bSource.DataSource = serviceOptions;
            selectServico.DataSource = bSource.DataSource;

            var clientesOptions = _clienteService.Listar();
            bSource.DataSource = clientesOptions;
            cb_id_cliente.DataSource = clientesOptions;
            cb_id_cliente.DisplayMember = "Nome";
            cb_id_cliente.ValueMember = "Id";
        }

        private void AtualizarDados()
        {
            BindingSource dataBinding = new BindingSource();
            dataBinding.DataSource = _veiculoService.Listar(); //Aplicar View Listagem veículos
            dataGridVeiculos.DataSource = dataBinding;
        }

        private void dataGridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

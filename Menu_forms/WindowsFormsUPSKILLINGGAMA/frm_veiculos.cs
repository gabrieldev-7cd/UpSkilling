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
    public partial class frm_Veiculos : Form
    {
        private readonly VeiculoService _veiculoService;
        private readonly ClienteService _clienteService;

        public frm_Veiculos(ContextoOpcao contexto)
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
            if (string.IsNullOrWhiteSpace(txt_marca.Text) || string.IsNullOrWhiteSpace(txt_modelo.Text) || string.IsNullOrWhiteSpace(txt_placa.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
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

        private void btn_editar_veiculos_Click(object sender, EventArgs e)
        {
            frm_EditarVeiculo frm = new frm_EditarVeiculo();
            frm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voltar ao Menu Principal?",
               "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var row = dataGridVeiculos.CurrentCell.OwningRow;

            if (row != null)
            {
                int idCliente = int.Parse(row.Cells["ID"].Value.ToString());
                string veiculo = row.Cells["Id"].Value != null ? row.Cells["IdCliente"].Value.ToString() : "";

                if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: {veiculo}?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = _clienteService.Excluir(idCliente);

                    MessageBox.Show(resultado == true ? "Veículo excluído com sucesso!"
                        : "Não foi possível excluir o cliente!");
                }
            }


            AtualizarDados();
        }

        private void btn_salvar_editv_Click(object sender, EventArgs e)
        {/*
            if (string.IsNullOrWhiteSpace(txt_marca.Text)
                || string.IsNullOrWhiteSpace(txt_modelo.Text)
                || string.IsNullOrWhiteSpace(txt_placa.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            var row = dataGridViewClientes.CurrentCell.OwningRow;
            int idCliente = int.Parse(row.Cells["ID"].Value.ToString());

            bool resultado = _clienteService.Alterar(idCliente, txt_marca.Text, txtPhoneNumberEdit.Text);

            btnSaveEdit.Enabled = false;

            MessageBox.Show(resultado == true ? "Dados atualizados com sucesso!"
                : "Não foi possível atualizar o cliente!");

            txtNameEdit.Text = string.Empty;
            txtPhoneNumberEdit.Text = string.Empty;

            AtualizarDados();*/
        }

        private void cb_id_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

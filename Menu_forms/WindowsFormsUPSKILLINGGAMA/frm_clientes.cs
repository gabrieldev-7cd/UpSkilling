using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_clientes : Form
    {
        private IClienteService _clienteService;

        public frm_clientes(ContextoOpcao contexto)
        {
            _clienteService = new ClienteService(contexto.TipoBaseSelecionada);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            BindingSource dataBinding = new BindingSource();
            dataBinding.DataSource = _clienteService.Listar();
            dataGridViewClientes.DataSource = dataBinding;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();

            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_telefone.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            bool resultado = _clienteService.Cadastrar(this.txt_nome.Text, this.txt_telefone.Text);

            MessageBox.Show(resultado == true ? "Cliente cadastrado com sucesso!" : "Não foi possível cadastrar o cliente!");

            cliente.Nome = string.Empty;
            cliente.Telefone = string.Empty;

            AtualizarDados();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var row = dataGridViewClientes.CurrentCell.OwningRow;

            if (row != null)
            {
                string idCliente = row.Cells["ID"].Value.ToString();
                string nomeCliente = row.Cells["Nome"].Value.ToString();

                if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: {nomeCliente} ?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }


            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", 
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

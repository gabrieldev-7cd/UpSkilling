using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_telefone.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            bool resultado = _clienteService.Cadastrar(this.txt_nome.Text, this.txt_telefone.Text);
            AtualizarDados();

            MessageBox.Show(resultado == true ? "Cliente cadastrado com sucesso!" 
                : "Não foi possível cadastrar o cliente!");

            txt_nome.Text = string.Empty;
            txt_telefone.Text = string.Empty;

            AtualizarDados();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var row = dataGridViewClientes.CurrentCell.OwningRow;

            if (row != null)
            {
                int idCliente = int.Parse(row.Cells["ID"].Value.ToString());
                string nomeCliente = row.Cells["Nome"].Value.ToString();

                if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: {nomeCliente} ?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = _clienteService.Excluir(idCliente);

                    MessageBox.Show(resultado == true ? "Cliente excluido com sucesso!" 
                        : "Não foi possível excluir o cliente!");
                }
            }

            AtualizarDados();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", 
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            var row = dataGridViewClientes.CurrentCell.OwningRow;

            if (row != null)
            {
                string nomeCliente = row.Cells["Nome"].Value.ToString();
                string telefoneCliente = row.Cells["Telefone"].Value.ToString();

                txtNameEdit.Text = nomeCliente;
                txtPhoneNumberEdit.Text = telefoneCliente;

                if (!string.IsNullOrWhiteSpace(txtNameEdit.Text) 
                    && !string.IsNullOrWhiteSpace(txtPhoneNumberEdit.Text))
                    btnSaveEdit.Enabled = true;
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameEdit.Text) 
                || string.IsNullOrWhiteSpace(txtPhoneNumberEdit.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            var row = dataGridViewClientes.CurrentCell.OwningRow;
            int idCliente = int.Parse(row.Cells["ID"].Value.ToString());

            bool resultado = _clienteService.Alterar(idCliente, txtNameEdit.Text, txtPhoneNumberEdit.Text);

            btnSaveEdit.Enabled = false;

            MessageBox.Show(resultado == true ? "Dados atualizados com sucesso!"
                : "Não foi possível atualizar o cliente!");

            txtNameEdit.Text = string.Empty;
            txtPhoneNumberEdit.Text = string.Empty;

            AtualizarDados();
        }
    }
}

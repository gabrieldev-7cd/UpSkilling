using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dataGridView1.DataSource = dataBinding;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();

            bool resultado = _clienteService.Cadastrar(this.txt_nome.Text, this.txt_telefone.Text);
            AtualizarDados();

            MessageBox.Show(resultado == true ? "Cliente cadastrado com sucesso!" : "Não foi possível cadastrar o cliente!");
            cliente.Nome = string.Empty;
            cliente.Telefone = string.Empty;
        }
    }
}

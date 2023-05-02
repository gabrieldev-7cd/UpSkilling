﻿using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_hist_vendas : Form
    {
        private readonly VeiculoService _veiculoService;
        private readonly TicketService  _ticketService;

        public frm_hist_vendas(ContextoOpcao contexto)
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
    }
}

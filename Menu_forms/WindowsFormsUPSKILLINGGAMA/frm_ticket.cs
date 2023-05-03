using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.DAL;
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Models.DTO;
using WindowsFormsUPSKILLINGGAMA.Services;
using WindowsFormsUPSKILLINGGAMA.Services.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_Ticket : Form
    {
        private readonly TicketService _ticketService;
        private readonly VeiculoService _veiculoService;
        private ContextoOpcao _contexto;

        public frm_Ticket(ContextoOpcao contexto)
        {
            _ticketService = new TicketService(contexto.TipoBaseSelecionada);
            _veiculoService = new VeiculoService(contexto.TipoBaseSelecionada);
            _contexto = contexto;

            InitializeComponent();
        }

        public void btn_reg_entrada_Click(object sender, EventArgs e)
        {

            var item = (ComboBoxVeiculos)cb_veiculo_entrada.SelectedItem;

            if (!_ticketService.VeiculoEstacionado(item.Id))
            {
                var novoTicket = _ticketService.Cadastrar(item.Id, DateTime.Parse(dateEntrada.Text));

                // Exibir a data e hora + tipo de serviço em um rótulo
                lbl_dathra_entrada.Text = novoTicket.DataEntrada.ToString();
                lbl_tpo_servico.Text = ((TipoServicoEnum)_veiculoService.Recuperar(novoTicket.IdVeiculo).TipoServico).ToString();

                lbl_tpo_servico.Text = $"Valor do Mensalista: {_contexto.ValorTarifaMesalidade.ToString("N2")}\n" +
                                       $"Valor da Diária: {_contexto.ValorTarifaDiaria.ToString("N2")}\n" +
                                       $"Valor da Hora: {_contexto.ValorTarifaHora.ToString("N2")}";

                cb_veiculo_saida.Text = string.Empty;
                AtualizaDados();
            }
            else
            {
                MessageBox.Show("Este veículo já esta estacionado no momento!");
                AtualizaDados();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_dathra_entrada_Click(object sender, EventArgs e)
        {
           
        }

        

        private void cb_tpo_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_tpo_servico_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btn_reg_saida_Click(object sender, EventArgs e)
        {
            var veiculo = (ComboBoxVeiculos)cb_veiculo_saida.SelectedItem;

            var ticket = (_ticketService.Listar()).Where(t => t.IdVeiculo == veiculo.Id && t.DataSaida == "").First();

            var ticketAtualizado = _ticketService.Alterar(ticket.Id, veiculo.Id, DateTime.Parse(ticket.DataEntrada), DateTime.Parse(dataSaida.Text));

            lbl_dathra_entrada2.Text = ticketAtualizado.DataEntrada;
            lbl_dathra_saida.Text = ticketAtualizado.DataSaida;
            lbl_tempo_estacionado.Text = (DateTime.Parse(ticketAtualizado.DataSaida).Subtract(DateTime.Parse(ticketAtualizado.DataEntrada))).ToString();
            lbl_vlr_servico.Text = _ticketService.CalculaTotalTicket(ticketAtualizado, _contexto).ToString("N2");

            cb_veiculo_saida.Text = string.Empty;
            AtualizaDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
             if (MessageBox.Show("Deseja voltar ao Menu Principal?",
                 "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 Close();
             }
            
        }

        private void frm_Ticket_Load(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void AtualizaDados()
        {
            var veiculosCadastrados = _veiculoService.Listar();
            List<ComboBoxVeiculos> veiculos = new List<ComboBoxVeiculos>();
            BindingSource bindingSource = new BindingSource();

            foreach (var veiculo in veiculosCadastrados.Where(x => !_ticketService.VeiculoEstacionado(x.Id)))
            {
                veiculos.Add(new ComboBoxVeiculos(veiculo.Id, $"Mod: {veiculo.Modelo}, Placa:{veiculo.Placa}"));
            }

            bindingSource.DataSource = veiculos;
            if (veiculos.Any())
            {
                //veiculos nao estacionados
                cb_veiculo_entrada.DataSource = bindingSource;
                cb_veiculo_entrada.ValueMember = "Id";
                cb_veiculo_entrada.DisplayMember = "Display";
            }
            else
            {
                cb_veiculo_saida.DataSource = bindingSource;
            }

            veiculos.Clear();
            foreach (var veiculo in veiculosCadastrados.Where(x => _ticketService.VeiculoEstacionado(x.Id)))
            {
                veiculos.Add(new ComboBoxVeiculos(veiculo.Id, $"Mod:{veiculo.Modelo}, Placa:{veiculo.Placa}"));
            }

            bindingSource.DataSource = veiculos;
            if (veiculos.Any())
            {
                // veiculos estacionados.
                cb_veiculo_saida.DataSource = bindingSource;
                cb_veiculo_saida.ValueMember = "Id";
                cb_veiculo_saida.DisplayMember = "Display";
            }
            else
            {
                cb_veiculo_saida.DataSource = bindingSource;
            }
        }

        private void cb_veiculo_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

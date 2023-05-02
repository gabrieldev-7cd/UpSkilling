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
using WindowsFormsUPSKILLINGGAMA.Models;
using WindowsFormsUPSKILLINGGAMA.Services;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_ticket : Form

    {
        // Lista para armazenar as placas já cadastradas
        List<string> placasCadastradas = new List<string>();

        public frm_ticket()
        {
            InitializeComponent();

            // Preenchendo a ComboBox com os valores do enum
            foreach (var servicoSelecionado in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                cb_tpo_servicoent.Items.Add(servicoSelecionado);
            }
        }
        public void btn_reg_entrada_Click(object sender, EventArgs e)
        {
            
            // Obter a data e hora atual
            DateTime dataHoraEntrada = DateTime.Now;

            // Obter o tipo de serviço selecionado no ComboBox
            foreach (var tipoServico in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                cb_tpo_servicoent.Items.Add(tipoServico);
            }

            // Obter a placa inserida pelo usuário
            string placa = txt_placa_ent.Text.Trim().ToUpper();

            // Verificar se a placa já foi cadastrada
            if (placasCadastradas.Contains(placa))
            {
                MessageBox.Show("Já existe um ticket com esse tipo de serviço para essa placa, favor reavaliar", "Placa duplicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adicionar a placa à lista de placas cadastradas
            placasCadastradas.Add(placa);


            // Definir o objeto ValorServico com os valores desejados
            ValorServicoModel valorServico = new ValorServicoModel();
            int mensalista = valorServico.Mensalista; // retorna 90
            int diaria = valorServico.Diaria; // retorna 25
            double hora = valorServico.Hora; // retorna 7.5


            // Exibir a data e hora + tipo de serviço em um rótulo
            lbl_dathra_entrada.Text = dataHoraEntrada.ToString();
            lbl_tpo_servico.Text = $"Valor do Mensalista: {valorServico.Mensalista}\n" +
                                   $"Valor da Diária: {valorServico.Diaria}\n" +
                                   $"Valor da Hora: {valorServico.Hora}";
            
            // Limpar o campo de placa
            txt_placa_ent.Text = "";
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
            // Obter a data e hora atual
            DateTime dataHoraSaida = DateTime.Now;
            
            // Obter a placa inserida pelo usuário
            string placa = txt_placa_sai.Text.Trim().ToUpper();

            // Verificar se a placa já foi cadastrada
            if (!placasCadastradas.Contains(placa))
            {
                MessageBox.Show("Não foi encontrada nenhuma entrada para esta placa", "Placa não encontrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*
            // Encontrar o horário de entrada da placa
            DateTime dataHoraEntrada = DateTime.MinValue;
            foreach (var ticket in TicketModel)
            {
                if (ticket.Placa == placa)
                {
                    dataHoraEntrada = ticket.DataHoraEntrada;
                    break;
                }
             }*/

            // Definir o objeto ValorServico com os valores desejados

            /*
            // Calcular o valor do serviço
            TimeSpan tempoEstacionado = dataHoraSaida - dataHoraEntrada;
            double valorServico = 0;
            if (tempoEstacionado.TotalDays >= 1)
            {
                valorServico = valorServico.Diaria * Math.Ceiling(tempoEstacionado.TotalDays);
            }
            else if (tempoEstacionado.TotalHours >= 1)
            {
                valorServico = valorServico.Hora * Math.Ceiling(tempoEstacionado.TotalHours);
            }
            else
            {
                valorServico = valorServico.Hora;
            }

            // Exibir os detalhes do ticket em um rótulo
            lbl_dathra_saida.Text = dataHoraSaida.ToString();
            lbl_tempo_estacionado.Text = $"Tempo estacionado: {tempoEstacionado}";
            lbl_vlr_servico.Text = $"Valor do serviço: R${valorServico.ToString("0.00")}";  */

            // Remover a placa da lista de placas cadastradas
            placasCadastradas.Remove(placa);

            // Limpar o campo de placa
            txt_placa_sai.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {          
             if (MessageBox.Show("Deseja voltar ao Menu Principal?",
                 "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 Close();
             }
            
        }
    }
}

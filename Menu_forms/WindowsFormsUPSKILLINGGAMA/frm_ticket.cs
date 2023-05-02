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
        {/*
            // Calcular o tempo de permanência do veículo
            TimeSpan tempoPermanencia = dataHoraSaida - dataHoraEntrada;

            // Calcular o valor total do serviço
            double valorTotal = 0;
            switch (tipoServico)
            {
                case TipoServicoEnum.Hora:
                    valorTotal = tempoPermanencia.TotalHours * valorServico.Hora;
                    break;
                case TipoServicoEnum.Diaria:
                    valorTotal = Math.Ceiling(tempoPermanencia.TotalDays) * valorServico.Diaria;
                    break;
                case TipoServicoEnum.Mensalista:
                    valorTotal = valorServico.Mensalista;
                    break;
            }

            // Exibir a placa, data e hora de entrada, tipo de serviço, data e hora de saída e valor total em um rótulo
            lbl_placa.Text = $"Placa: {placa}";
            lbl_dathra_entrada.Text = $"Data e hora de entrada: {dataHoraEntrada}";
            lbl_tpo_servico.Text = $"Tipo de serviço: {tipoServico}";
            lbl_dathra_saida.Text = $"Data e hora de saída: {dataHoraSaida}";
            lbl_valor_total.Text = $"Valor total: R$ {valorTotal:F2}";
        }

        // Limpar o campo de placa
        txt_placa_ent.Text = "";*/
        }
    }
}

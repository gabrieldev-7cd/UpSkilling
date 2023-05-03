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
using WindowsFormsUPSKILLINGGAMA.Models.DTO;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_EditarVeiculo : Form
    {
        public frm_EditarVeiculo()
        {
            InitializeComponent();
        }
       
        private void cb_editvei_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_save_newveiculo_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentCell.OwningRow;

            if (row != null)
            {
                string marca = row.Cells["Marca"].Value.ToString();
                string modelo = row.Cells["Modelo"].Value.ToString();
                string placa = row.Cells["Placa"].Value.ToString();

                txt_old_marca.Text = marca;
                txt_old_modelo.Text = modelo;
                txt_old_placa.Text = placa;

                if (!string.IsNullOrWhiteSpace(txt_old_marca.Text)
                    && !string.IsNullOrWhiteSpace(txt_old_modelo.Text)
                    && !string.IsNullOrWhiteSpace(txt_old_placa.Text))
                    btn_save_newveiculo.Enabled = true;
            }
        }

        private void txt_old_marca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

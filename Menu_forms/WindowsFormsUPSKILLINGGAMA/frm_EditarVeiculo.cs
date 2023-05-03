using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_EditarVeiculo : Form
    {
        public frm_EditarVeiculo()
        {
            InitializeComponent();
        }

        private List<VeiculoModel> _veiculos;

        private void cb_old_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeiculoModel veiculoSelecionado = (VeiculoModel) cb_old_marca.SelectedItem;
        }
            


        private void btn_save_newveiculo_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_registro_Click(object sender, EventArgs e)
        {

        }
    }
}

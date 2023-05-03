namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_EditarVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_old_marca = new System.Windows.Forms.Label();
            this.txt_new_marca = new System.Windows.Forms.TextBox();
            this.txt_new_modelo = new System.Windows.Forms.TextBox();
            this.txt_new_placa = new System.Windows.Forms.TextBox();
            this.lbl_old_modelo = new System.Windows.Forms.Label();
            this.lbl_old_placa = new System.Windows.Forms.Label();
            this.lbl_new_marca = new System.Windows.Forms.Label();
            this.lbl_new_modelo = new System.Windows.Forms.Label();
            this.lbl_new_placa = new System.Windows.Forms.Label();
            this.lbl_editvei_Cliente = new System.Windows.Forms.Label();
            this.cb_editvei_cliente = new System.Windows.Forms.ComboBox();
            this.btn_save_newveiculo = new System.Windows.Forms.Button();
            this.btn_excluir_registro = new System.Windows.Forms.Button();
            this.btn_voltar_menuP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_old_marca = new System.Windows.Forms.ComboBox();
            this.cb_old_modelo = new System.Windows.Forms.ComboBox();
            this.cb_old_placa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_old_marca
            // 
            this.lbl_old_marca.AutoSize = true;
            this.lbl_old_marca.Location = new System.Drawing.Point(10, 78);
            this.lbl_old_marca.Name = "lbl_old_marca";
            this.lbl_old_marca.Size = new System.Drawing.Size(64, 13);
            this.lbl_old_marca.TabIndex = 0;
            this.lbl_old_marca.Text = "Marca Atual";
            // 
            // txt_new_marca
            // 
            this.txt_new_marca.Location = new System.Drawing.Point(348, 75);
            this.txt_new_marca.Name = "txt_new_marca";
            this.txt_new_marca.Size = new System.Drawing.Size(145, 20);
            this.txt_new_marca.TabIndex = 14;
            // 
            // txt_new_modelo
            // 
            this.txt_new_modelo.Location = new System.Drawing.Point(348, 101);
            this.txt_new_modelo.Name = "txt_new_modelo";
            this.txt_new_modelo.Size = new System.Drawing.Size(145, 20);
            this.txt_new_modelo.TabIndex = 15;
            // 
            // txt_new_placa
            // 
            this.txt_new_placa.Location = new System.Drawing.Point(348, 127);
            this.txt_new_placa.Name = "txt_new_placa";
            this.txt_new_placa.Size = new System.Drawing.Size(145, 20);
            this.txt_new_placa.TabIndex = 16;
            // 
            // lbl_old_modelo
            // 
            this.lbl_old_modelo.AutoSize = true;
            this.lbl_old_modelo.Location = new System.Drawing.Point(5, 104);
            this.lbl_old_modelo.Name = "lbl_old_modelo";
            this.lbl_old_modelo.Size = new System.Drawing.Size(69, 13);
            this.lbl_old_modelo.TabIndex = 17;
            this.lbl_old_modelo.Text = "Modelo Atual";
            // 
            // lbl_old_placa
            // 
            this.lbl_old_placa.AutoSize = true;
            this.lbl_old_placa.Location = new System.Drawing.Point(13, 130);
            this.lbl_old_placa.Name = "lbl_old_placa";
            this.lbl_old_placa.Size = new System.Drawing.Size(61, 13);
            this.lbl_old_placa.TabIndex = 18;
            this.lbl_old_placa.Text = "Placa Atual";
            // 
            // lbl_new_marca
            // 
            this.lbl_new_marca.AutoSize = true;
            this.lbl_new_marca.Location = new System.Drawing.Point(280, 78);
            this.lbl_new_marca.Name = "lbl_new_marca";
            this.lbl_new_marca.Size = new System.Drawing.Size(66, 13);
            this.lbl_new_marca.TabIndex = 19;
            this.lbl_new_marca.Text = "Nova Marca";
            // 
            // lbl_new_modelo
            // 
            this.lbl_new_modelo.AutoSize = true;
            this.lbl_new_modelo.Location = new System.Drawing.Point(275, 105);
            this.lbl_new_modelo.Name = "lbl_new_modelo";
            this.lbl_new_modelo.Size = new System.Drawing.Size(71, 13);
            this.lbl_new_modelo.TabIndex = 20;
            this.lbl_new_modelo.Text = "Novo Modelo";
            // 
            // lbl_new_placa
            // 
            this.lbl_new_placa.AutoSize = true;
            this.lbl_new_placa.Location = new System.Drawing.Point(283, 131);
            this.lbl_new_placa.Name = "lbl_new_placa";
            this.lbl_new_placa.Size = new System.Drawing.Size(63, 13);
            this.lbl_new_placa.TabIndex = 21;
            this.lbl_new_placa.Text = "Nova Placa";
            // 
            // lbl_editvei_Cliente
            // 
            this.lbl_editvei_Cliente.AutoSize = true;
            this.lbl_editvei_Cliente.Location = new System.Drawing.Point(30, 42);
            this.lbl_editvei_Cliente.Name = "lbl_editvei_Cliente";
            this.lbl_editvei_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_editvei_Cliente.TabIndex = 22;
            this.lbl_editvei_Cliente.Text = "Cliente";
            // 
            // cb_editvei_cliente
            // 
            this.cb_editvei_cliente.FormattingEnabled = true;
            this.cb_editvei_cliente.Location = new System.Drawing.Point(76, 39);
            this.cb_editvei_cliente.Name = "cb_editvei_cliente";
            this.cb_editvei_cliente.Size = new System.Drawing.Size(145, 21);
            this.cb_editvei_cliente.TabIndex = 23;
            // 
            // btn_save_newveiculo
            // 
            this.btn_save_newveiculo.Location = new System.Drawing.Point(523, 15);
            this.btn_save_newveiculo.Name = "btn_save_newveiculo";
            this.btn_save_newveiculo.Size = new System.Drawing.Size(75, 40);
            this.btn_save_newveiculo.TabIndex = 24;
            this.btn_save_newveiculo.Text = "Salvar Novo Veículo";
            this.btn_save_newveiculo.UseVisualStyleBackColor = true;
            this.btn_save_newveiculo.Click += new System.EventHandler(this.btn_save_newveiculo_Click);
            // 
            // btn_excluir_registro
            // 
            this.btn_excluir_registro.Location = new System.Drawing.Point(523, 61);
            this.btn_excluir_registro.Name = "btn_excluir_registro";
            this.btn_excluir_registro.Size = new System.Drawing.Size(75, 40);
            this.btn_excluir_registro.TabIndex = 25;
            this.btn_excluir_registro.Text = "Excluir Registro";
            this.btn_excluir_registro.UseVisualStyleBackColor = true;
            this.btn_excluir_registro.Click += new System.EventHandler(this.btn_excluir_registro_Click);
            // 
            // btn_voltar_menuP
            // 
            this.btn_voltar_menuP.Location = new System.Drawing.Point(523, 107);
            this.btn_voltar_menuP.Name = "btn_voltar_menuP";
            this.btn_voltar_menuP.Size = new System.Drawing.Size(75, 40);
            this.btn_voltar_menuP.TabIndex = 26;
            this.btn_voltar_menuP.Text = "Voltar ao Menu";
            this.btn_voltar_menuP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 222);
            this.dataGridView1.TabIndex = 27;
            // 
            // cb_old_marca
            // 
            this.cb_old_marca.FormattingEnabled = true;
            this.cb_old_marca.Location = new System.Drawing.Point(76, 75);
            this.cb_old_marca.Name = "cb_old_marca";
            this.cb_old_marca.Size = new System.Drawing.Size(145, 21);
            this.cb_old_marca.TabIndex = 28;
            this.cb_old_marca.SelectedIndexChanged += new System.EventHandler(this.cb_old_marca_SelectedIndexChanged);
            // 
            // cb_old_modelo
            // 
            this.cb_old_modelo.FormattingEnabled = true;
            this.cb_old_modelo.Location = new System.Drawing.Point(76, 100);
            this.cb_old_modelo.Name = "cb_old_modelo";
            this.cb_old_modelo.Size = new System.Drawing.Size(145, 21);
            this.cb_old_modelo.TabIndex = 29;
            // 
            // cb_old_placa
            // 
            this.cb_old_placa.FormattingEnabled = true;
            this.cb_old_placa.Location = new System.Drawing.Point(76, 126);
            this.cb_old_placa.Name = "cb_old_placa";
            this.cb_old_placa.Size = new System.Drawing.Size(145, 21);
            this.cb_old_placa.TabIndex = 30;
            // 
            // frm_EditarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 411);
            this.Controls.Add(this.cb_old_placa);
            this.Controls.Add(this.cb_old_modelo);
            this.Controls.Add(this.cb_old_marca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_voltar_menuP);
            this.Controls.Add(this.btn_excluir_registro);
            this.Controls.Add(this.btn_save_newveiculo);
            this.Controls.Add(this.cb_editvei_cliente);
            this.Controls.Add(this.lbl_editvei_Cliente);
            this.Controls.Add(this.lbl_new_placa);
            this.Controls.Add(this.lbl_new_modelo);
            this.Controls.Add(this.lbl_new_marca);
            this.Controls.Add(this.lbl_old_placa);
            this.Controls.Add(this.lbl_old_modelo);
            this.Controls.Add(this.txt_new_placa);
            this.Controls.Add(this.txt_new_modelo);
            this.Controls.Add(this.txt_new_marca);
            this.Controls.Add(this.lbl_old_marca);
            this.Name = "frm_EditarVeiculo";
            this.Text = "Editar Cadastro de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_old_marca;
        private System.Windows.Forms.TextBox txt_new_marca;
        private System.Windows.Forms.TextBox txt_new_modelo;
        private System.Windows.Forms.TextBox txt_new_placa;
        private System.Windows.Forms.Label lbl_old_modelo;
        private System.Windows.Forms.Label lbl_old_placa;
        private System.Windows.Forms.Label lbl_new_marca;
        private System.Windows.Forms.Label lbl_new_modelo;
        private System.Windows.Forms.Label lbl_new_placa;
        private System.Windows.Forms.Label lbl_editvei_Cliente;
        private System.Windows.Forms.ComboBox cb_editvei_cliente;
        private System.Windows.Forms.Button btn_save_newveiculo;
        private System.Windows.Forms.Button btn_excluir_registro;
        private System.Windows.Forms.Button btn_voltar_menuP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_old_marca;
        private System.Windows.Forms.ComboBox cb_old_modelo;
        private System.Windows.Forms.ComboBox cb_old_placa;
    }
}
﻿namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_veiculos
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dataGridVeiculos = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.selectServico = new System.Windows.Forms.ComboBox();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            this.cb_id_cliente = new System.Windows.Forms.ComboBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(404, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dataGridVeiculos
            // 
            this.dataGridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculos.Location = new System.Drawing.Point(12, 116);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.RowHeadersWidth = 51;
            this.dataGridVeiculos.Size = new System.Drawing.Size(465, 194);
            this.dataGridVeiculos.TabIndex = 16;
            this.dataGridVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVeiculos_CellContentClick);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(404, 68);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(404, 39);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(279, 64);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(30, 67);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 12;
            this.lbl_modelo.Text = "Modelo";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(73, 64);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(145, 20);
            this.txt_modelo.TabIndex = 11;
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(25, 15);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(68, 13);
            this.lbl_id_cliente.TabIndex = 9;
            this.lbl_id_cliente.Text = "ID do Cliente";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(33, 90);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_placa.TabIndex = 18;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(73, 90);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(145, 20);
            this.txt_placa.TabIndex = 19;
            // 
            // selectServico
            // 
            this.selectServico.FormattingEnabled = true;
            this.selectServico.Location = new System.Drawing.Point(255, 37);
            this.selectServico.Name = "selectServico";
            this.selectServico.Size = new System.Drawing.Size(121, 21);
            this.selectServico.TabIndex = 20;
            this.selectServico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tpo_servico
            // 
            this.lbl_tpo_servico.AutoSize = true;
            this.lbl_tpo_servico.Location = new System.Drawing.Point(274, 15);
            this.lbl_tpo_servico.Name = "lbl_tpo_servico";
            this.lbl_tpo_servico.Size = new System.Drawing.Size(80, 13);
            this.lbl_tpo_servico.TabIndex = 21;
            this.lbl_tpo_servico.Text = "Tipo de serviço";
            // 
            // cb_id_cliente
            // 
            this.cb_id_cliente.FormattingEnabled = true;
            this.cb_id_cliente.Location = new System.Drawing.Point(97, 11);
            this.cb_id_cliente.Name = "cb_id_cliente";
            this.cb_id_cliente.Size = new System.Drawing.Size(121, 21);
            this.cb_id_cliente.TabIndex = 22;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(73, 39);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(145, 20);
            this.txt_marca.TabIndex = 24;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(30, 42);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 23;
            this.lbl_marca.Text = "Marca";
            this.lbl_marca.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 324);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.cb_id_cliente);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.selectServico);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dataGridVeiculos);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.lbl_id_cliente);
            this.Name = "frm_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos";
            this.Load += new System.EventHandler(this.frm_veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridVeiculos;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.ComboBox selectServico;
        private System.Windows.Forms.Label lbl_tpo_servico;
        private System.Windows.Forms.ComboBox cb_id_cliente;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_marca;
    }
}
namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_Ticket
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
            this.lbl_dathra_entrada = new System.Windows.Forms.Label();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            this.btn_reg_entrada = new System.Windows.Forms.Button();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reg_saida = new System.Windows.Forms.Button();
            this.lbl_dathra_entrada2 = new System.Windows.Forms.Label();
            this.lbl_dathra_saida = new System.Windows.Forms.Label();
            this.lbl_vlr_servico = new System.Windows.Forms.Label();
            this.lbl_tempo_estacionado = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.cb_veiculo_entrada = new System.Windows.Forms.ComboBox();
            this.cb_veiculo_saida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dataSaida = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dathra_entrada
            // 
            this.lbl_dathra_entrada.AutoSize = true;
            this.lbl_dathra_entrada.Location = new System.Drawing.Point(64, 152);
            this.lbl_dathra_entrada.Name = "lbl_dathra_entrada";
            this.lbl_dathra_entrada.Size = new System.Drawing.Size(119, 13);
            this.lbl_dathra_entrada.TabIndex = 1;
            this.lbl_dathra_entrada.Text = "Data e Hora da entrada";
            // 
            // lbl_tpo_servico
            // 
            this.lbl_tpo_servico.AutoSize = true;
            this.lbl_tpo_servico.Location = new System.Drawing.Point(64, 173);
            this.lbl_tpo_servico.Name = "lbl_tpo_servico";
            this.lbl_tpo_servico.Size = new System.Drawing.Size(82, 13);
            this.lbl_tpo_servico.TabIndex = 2;
            this.lbl_tpo_servico.Text = "Tipo de Serviço";
            // 
            // btn_reg_entrada
            // 
            this.btn_reg_entrada.Location = new System.Drawing.Point(244, 177);
            this.btn_reg_entrada.Name = "btn_reg_entrada";
            this.btn_reg_entrada.Size = new System.Drawing.Size(112, 23);
            this.btn_reg_entrada.TabIndex = 5;
            this.btn_reg_entrada.Text = "Registrar Entrada";
            this.btn_reg_entrada.UseVisualStyleBackColor = true;
            this.btn_reg_entrada.Click += new System.EventHandler(this.btn_reg_entrada_Click);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(217, 94);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(156, 13);
            this.lbl_placa.TabIndex = 6;
            this.lbl_placa.Text = "Selecione o veículo Disponível";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Ticket_saida;
            this.pictureBox2.Location = new System.Drawing.Point(440, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 358);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Ticket_entrada___;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 358);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Selecione o veículo Estacionado";
            // 
            // btn_reg_saida
            // 
            this.btn_reg_saida.Location = new System.Drawing.Point(698, 177);
            this.btn_reg_saida.Name = "btn_reg_saida";
            this.btn_reg_saida.Size = new System.Drawing.Size(112, 23);
            this.btn_reg_saida.TabIndex = 29;
            this.btn_reg_saida.Text = "Registrar Saída";
            this.btn_reg_saida.UseVisualStyleBackColor = true;
            this.btn_reg_saida.Click += new System.EventHandler(this.btn_reg_saida_Click);
            // 
            // lbl_dathra_entrada2
            // 
            this.lbl_dathra_entrada2.AutoSize = true;
            this.lbl_dathra_entrada2.Location = new System.Drawing.Point(499, 152);
            this.lbl_dathra_entrada2.Name = "lbl_dathra_entrada2";
            this.lbl_dathra_entrada2.Size = new System.Drawing.Size(119, 13);
            this.lbl_dathra_entrada2.TabIndex = 33;
            this.lbl_dathra_entrada2.Text = "Data e Hora da entrada";
            // 
            // lbl_dathra_saida
            // 
            this.lbl_dathra_saida.AutoSize = true;
            this.lbl_dathra_saida.Location = new System.Drawing.Point(499, 187);
            this.lbl_dathra_saida.Name = "lbl_dathra_saida";
            this.lbl_dathra_saida.Size = new System.Drawing.Size(110, 13);
            this.lbl_dathra_saida.TabIndex = 34;
            this.lbl_dathra_saida.Text = "Data e Hora da saída";
            // 
            // lbl_vlr_servico
            // 
            this.lbl_vlr_servico.AutoSize = true;
            this.lbl_vlr_servico.Location = new System.Drawing.Point(539, 296);
            this.lbl_vlr_servico.Name = "lbl_vlr_servico";
            this.lbl_vlr_servico.Size = new System.Drawing.Size(28, 13);
            this.lbl_vlr_servico.TabIndex = 35;
            this.lbl_vlr_servico.Text = "0,00";
            this.lbl_vlr_servico.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tempo_estacionado
            // 
            this.lbl_tempo_estacionado.AutoSize = true;
            this.lbl_tempo_estacionado.Location = new System.Drawing.Point(499, 226);
            this.lbl_tempo_estacionado.Name = "lbl_tempo_estacionado";
            this.lbl_tempo_estacionado.Size = new System.Drawing.Size(102, 13);
            this.lbl_tempo_estacionado.TabIndex = 36;
            this.lbl_tempo_estacionado.Text = "Tempo Estacionado";
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_menu.Location = new System.Drawing.Point(726, 336);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(111, 23);
            this.btn_menu.TabIndex = 37;
            this.btn_menu.Text = "Voltar ao Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_veiculo_entrada
            // 
            this.cb_veiculo_entrada.FormattingEnabled = true;
            this.cb_veiculo_entrada.Location = new System.Drawing.Point(221, 119);
            this.cb_veiculo_entrada.Name = "cb_veiculo_entrada";
            this.cb_veiculo_entrada.Size = new System.Drawing.Size(166, 21);
            this.cb_veiculo_entrada.TabIndex = 38;
            // 
            // cb_veiculo_saida
            // 
            this.cb_veiculo_saida.FormattingEnabled = true;
            this.cb_veiculo_saida.Location = new System.Drawing.Point(666, 119);
            this.cb_veiculo_saida.Name = "cb_veiculo_saida";
            this.cb_veiculo_saida.Size = new System.Drawing.Size(171, 21);
            this.cb_veiculo_saida.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "R$ ";
            // 
            // dateEntrada
            // 
            this.dateEntrada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEntrada.Location = new System.Drawing.Point(221, 146);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(166, 20);
            this.dateEntrada.TabIndex = 41;
            // 
            // dataSaida
            // 
            this.dataSaida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataSaida.Location = new System.Drawing.Point(666, 146);
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(171, 20);
            this.dataSaida.TabIndex = 42;
            // 
            // frm_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 371);
            this.Controls.Add(this.dataSaida);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_veiculo_saida);
            this.Controls.Add(this.cb_veiculo_entrada);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lbl_tempo_estacionado);
            this.Controls.Add(this.lbl_vlr_servico);
            this.Controls.Add(this.lbl_dathra_saida);
            this.Controls.Add(this.lbl_dathra_entrada2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reg_saida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_reg_entrada);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.lbl_dathra_entrada);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Ticket";
            this.Text = "Cadastro de ticket";
            this.Load += new System.EventHandler(this.frm_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dathra_entrada;
        private System.Windows.Forms.Label lbl_tpo_servico;
        private System.Windows.Forms.Button btn_reg_entrada;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reg_saida;
        private System.Windows.Forms.Label lbl_dathra_entrada2;
        private System.Windows.Forms.Label lbl_dathra_saida;
        private System.Windows.Forms.Label lbl_vlr_servico;
        private System.Windows.Forms.Label lbl_tempo_estacionado;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.ComboBox cb_veiculo_entrada;
        private System.Windows.Forms.ComboBox cb_veiculo_saida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DateTimePicker dataSaida;
    }
}
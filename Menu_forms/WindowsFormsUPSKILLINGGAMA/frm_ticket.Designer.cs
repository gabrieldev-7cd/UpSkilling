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
            this.dt_entrada = new System.Windows.Forms.DateTimePicker();
            this.cb_tpo_servicoent = new System.Windows.Forms.ComboBox();
            this.btn_reg_entrada = new System.Windows.Forms.Button();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa_ent = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_placa_sai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reg_saida = new System.Windows.Forms.Button();
            this.cb_tpo_servicsai = new System.Windows.Forms.ComboBox();
            this.dt_saida = new System.Windows.Forms.DateTimePicker();
            this.lbl_dathra_entrada2 = new System.Windows.Forms.Label();
            this.lbl_dathra_saida = new System.Windows.Forms.Label();
            this.lbl_vlr_servico = new System.Windows.Forms.Label();
            this.lbl_tempo_estacionado = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
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
            // dt_entrada
            // 
            this.dt_entrada.Location = new System.Drawing.Point(220, 149);
            this.dt_entrada.Name = "dt_entrada";
            this.dt_entrada.Size = new System.Drawing.Size(112, 20);
            this.dt_entrada.TabIndex = 26;
            // 
            // cb_tpo_servicoent
            // 
            this.cb_tpo_servicoent.FormattingEnabled = true;
            this.cb_tpo_servicoent.Location = new System.Drawing.Point(221, 179);
            this.cb_tpo_servicoent.Name = "cb_tpo_servicoent";
            this.cb_tpo_servicoent.Size = new System.Drawing.Size(112, 21);
            this.cb_tpo_servicoent.TabIndex = 4;
            // 
            // btn_reg_entrada
            // 
            this.btn_reg_entrada.Location = new System.Drawing.Point(220, 221);
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
            this.lbl_placa.Location = new System.Drawing.Point(236, 103);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(82, 13);
            this.lbl_placa.TabIndex = 6;
            this.lbl_placa.Text = "Esceva a Placa";
            // 
            // txt_placa_ent
            // 
            this.txt_placa_ent.Location = new System.Drawing.Point(220, 119);
            this.txt_placa_ent.Name = "txt_placa_ent";
            this.txt_placa_ent.Size = new System.Drawing.Size(113, 20);
            this.txt_placa_ent.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Ticket_saida;
            this.pictureBox2.Location = new System.Drawing.Point(339, 12);
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
            // txt_placa_sai
            // 
            this.txt_placa_sai.Location = new System.Drawing.Point(565, 119);
            this.txt_placa_sai.Name = "txt_placa_sai";
            this.txt_placa_sai.Size = new System.Drawing.Size(113, 20);
            this.txt_placa_sai.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Esceva a Placa";
            // 
            // btn_reg_saida
            // 
            this.btn_reg_saida.Location = new System.Drawing.Point(565, 221);
            this.btn_reg_saida.Name = "btn_reg_saida";
            this.btn_reg_saida.Size = new System.Drawing.Size(112, 23);
            this.btn_reg_saida.TabIndex = 29;
            this.btn_reg_saida.Text = "Registrar Saída";
            this.btn_reg_saida.UseVisualStyleBackColor = true;
            this.btn_reg_saida.Click += new System.EventHandler(this.btn_reg_saida_Click);
            // 
            // cb_tpo_servicsai
            // 
            this.cb_tpo_servicsai.FormattingEnabled = true;
            this.cb_tpo_servicsai.Location = new System.Drawing.Point(566, 179);
            this.cb_tpo_servicsai.Name = "cb_tpo_servicsai";
            this.cb_tpo_servicsai.Size = new System.Drawing.Size(112, 21);
            this.cb_tpo_servicsai.TabIndex = 28;
            // 
            // dt_saida
            // 
            this.dt_saida.Location = new System.Drawing.Point(565, 149);
            this.dt_saida.Name = "dt_saida";
            this.dt_saida.Size = new System.Drawing.Size(112, 20);
            this.dt_saida.TabIndex = 32;
            // 
            // lbl_dathra_entrada2
            // 
            this.lbl_dathra_entrada2.AutoSize = true;
            this.lbl_dathra_entrada2.Location = new System.Drawing.Point(389, 149);
            this.lbl_dathra_entrada2.Name = "lbl_dathra_entrada2";
            this.lbl_dathra_entrada2.Size = new System.Drawing.Size(119, 13);
            this.lbl_dathra_entrada2.TabIndex = 33;
            this.lbl_dathra_entrada2.Text = "Data e Hora da entrada";
            // 
            // lbl_dathra_saida
            // 
            this.lbl_dathra_saida.AutoSize = true;
            this.lbl_dathra_saida.Location = new System.Drawing.Point(398, 187);
            this.lbl_dathra_saida.Name = "lbl_dathra_saida";
            this.lbl_dathra_saida.Size = new System.Drawing.Size(110, 13);
            this.lbl_dathra_saida.TabIndex = 34;
            this.lbl_dathra_saida.Text = "Data e Hora da saída";
            // 
            // lbl_vlr_servico
            // 
            this.lbl_vlr_servico.AutoSize = true;
            this.lbl_vlr_servico.Location = new System.Drawing.Point(425, 294);
            this.lbl_vlr_servico.Name = "lbl_vlr_servico";
            this.lbl_vlr_servico.Size = new System.Drawing.Size(24, 13);
            this.lbl_vlr_servico.TabIndex = 35;
            this.lbl_vlr_servico.Text = "R$ ";
            this.lbl_vlr_servico.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tempo_estacionado
            // 
            this.lbl_tempo_estacionado.AutoSize = true;
            this.lbl_tempo_estacionado.Location = new System.Drawing.Point(398, 226);
            this.lbl_tempo_estacionado.Name = "lbl_tempo_estacionado";
            this.lbl_tempo_estacionado.Size = new System.Drawing.Size(102, 13);
            this.lbl_tempo_estacionado.TabIndex = 36;
            this.lbl_tempo_estacionado.Text = "Tempo Estacionado";
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_menu.Location = new System.Drawing.Point(220, 261);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(111, 23);
            this.btn_menu.TabIndex = 37;
            this.btn_menu.Text = "Voltar ao Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 371);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lbl_tempo_estacionado);
            this.Controls.Add(this.lbl_vlr_servico);
            this.Controls.Add(this.lbl_dathra_saida);
            this.Controls.Add(this.lbl_dathra_entrada2);
            this.Controls.Add(this.txt_placa_sai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reg_saida);
            this.Controls.Add(this.cb_tpo_servicsai);
            this.Controls.Add(this.dt_saida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_placa_ent);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_reg_entrada);
            this.Controls.Add(this.cb_tpo_servicoent);
            this.Controls.Add(this.dt_entrada);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.lbl_dathra_entrada);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_ticket";
            this.Text = "Cadastro de ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dathra_entrada;
        private System.Windows.Forms.Label lbl_tpo_servico;
        private System.Windows.Forms.DateTimePicker dt_entrada;
        private System.Windows.Forms.ComboBox cb_tpo_servicoent;
        private System.Windows.Forms.Button btn_reg_entrada;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa_ent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_placa_sai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reg_saida;
        private System.Windows.Forms.ComboBox cb_tpo_servicsai;
        private System.Windows.Forms.DateTimePicker dt_saida;
        private System.Windows.Forms.Label lbl_dathra_entrada2;
        private System.Windows.Forms.Label lbl_dathra_saida;
        private System.Windows.Forms.Label lbl_vlr_servico;
        private System.Windows.Forms.Label lbl_tempo_estacionado;
        private System.Windows.Forms.Button btn_menu;
    }
}
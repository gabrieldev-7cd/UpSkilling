namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_ticket
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_dathra_entrada = new System.Windows.Forms.Label();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            this.dt_entrada = new System.Windows.Forms.DateTimePicker();
            this.cb_tpo_servico = new System.Windows.Forms.ComboBox();
            this.btn_reg_entrada = new System.Windows.Forms.Button();
            this.lbl_ecr_placa = new System.Windows.Forms.Label();
            this.txt_rcb_placa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // cb_tpo_servico
            // 
            this.cb_tpo_servico.FormattingEnabled = true;
            this.cb_tpo_servico.Location = new System.Drawing.Point(221, 179);
            this.cb_tpo_servico.Name = "cb_tpo_servico";
            this.cb_tpo_servico.Size = new System.Drawing.Size(112, 21);
            this.cb_tpo_servico.TabIndex = 4;
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
            // lbl_ecr_placa
            // 
            this.lbl_ecr_placa.AutoSize = true;
            this.lbl_ecr_placa.Location = new System.Drawing.Point(236, 103);
            this.lbl_ecr_placa.Name = "lbl_ecr_placa";
            this.lbl_ecr_placa.Size = new System.Drawing.Size(82, 13);
            this.lbl_ecr_placa.TabIndex = 6;
            this.lbl_ecr_placa.Text = "Esceva a Placa";
            // 
            // txt_rcb_placa
            // 
            this.txt_rcb_placa.Location = new System.Drawing.Point(220, 119);
            this.txt_rcb_placa.Name = "txt_rcb_placa";
            this.txt_rcb_placa.Size = new System.Drawing.Size(113, 20);
            this.txt_rcb_placa.TabIndex = 25;
            // 
            // frm_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_rcb_placa);
            this.Controls.Add(this.lbl_ecr_placa);
            this.Controls.Add(this.btn_reg_entrada);
            this.Controls.Add(this.cb_tpo_servico);
            this.Controls.Add(this.dt_entrada);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.lbl_dathra_entrada);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_ticket";
            this.Text = "frm_ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dathra_entrada;
        private System.Windows.Forms.Label lbl_tpo_servico;
        private System.Windows.Forms.DateTimePicker dt_entrada;
        private System.Windows.Forms.ComboBox cb_tpo_servico;
        private System.Windows.Forms.Button btn_reg_entrada;
        private System.Windows.Forms.Label lbl_ecr_placa;
        private System.Windows.Forms.TextBox txt_rcb_placa;
    }
}
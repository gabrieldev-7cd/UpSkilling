namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_Menu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cdt_clientes = new System.Windows.Forms.Button();
            this.btn_cdt_veiculos = new System.Windows.Forms.Button();
            this.btn_hist_venda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selecao_base = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cad_ticket = new System.Windows.Forms.Button();
            this.pic_menu_estac = new System.Windows.Forms.PictureBox();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu_estac)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.ticketToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // btn_cdt_clientes
            // 
            this.btn_cdt_clientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cdt_clientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cdt_clientes.Location = new System.Drawing.Point(12, 42);
            this.btn_cdt_clientes.Name = "btn_cdt_clientes";
            this.btn_cdt_clientes.Size = new System.Drawing.Size(75, 55);
            this.btn_cdt_clientes.TabIndex = 2;
            this.btn_cdt_clientes.Text = "Cadastrar Clientes";
            this.btn_cdt_clientes.UseVisualStyleBackColor = false;
            this.btn_cdt_clientes.Click += new System.EventHandler(this.btn_cdt_clientes_Click);
            // 
            // btn_cdt_veiculos
            // 
            this.btn_cdt_veiculos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cdt_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cdt_veiculos.Location = new System.Drawing.Point(104, 42);
            this.btn_cdt_veiculos.Name = "btn_cdt_veiculos";
            this.btn_cdt_veiculos.Size = new System.Drawing.Size(75, 55);
            this.btn_cdt_veiculos.TabIndex = 3;
            this.btn_cdt_veiculos.Text = "Cadastrar Veículos";
            this.btn_cdt_veiculos.UseVisualStyleBackColor = false;
            this.btn_cdt_veiculos.Click += new System.EventHandler(this.btn_cdt_veiculos_Click);
            // 
            // btn_hist_venda
            // 
            this.btn_hist_venda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hist_venda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_hist_venda.Location = new System.Drawing.Point(286, 42);
            this.btn_hist_venda.Name = "btn_hist_venda";
            this.btn_hist_venda.Size = new System.Drawing.Size(75, 55);
            this.btn_hist_venda.TabIndex = 4;
            this.btn_hist_venda.Text = "Histórico de venda";
            this.btn_hist_venda.UseVisualStyleBackColor = false;
            this.btn_hist_venda.Click += new System.EventHandler(this.btn_hist_vendas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selecao_base);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(133, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 119);
            this.panel1.TabIndex = 5;
            // 
            // selecao_base
            // 
            this.selecao_base.Location = new System.Drawing.Point(70, 73);
            this.selecao_base.Name = "selecao_base";
            this.selecao_base.Size = new System.Drawing.Size(75, 23);
            this.selecao_base.TabIndex = 2;
            this.selecao_base.Text = "Selecionar";
            this.selecao_base.UseVisualStyleBackColor = true;
            this.selecao_base.Click += new System.EventHandler(this.selecao_base_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE A BASE";
            // 
            // btn_cad_ticket
            // 
            this.btn_cad_ticket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cad_ticket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cad_ticket.Location = new System.Drawing.Point(194, 42);
            this.btn_cad_ticket.Name = "btn_cad_ticket";
            this.btn_cad_ticket.Size = new System.Drawing.Size(75, 55);
            this.btn_cad_ticket.TabIndex = 6;
            this.btn_cad_ticket.Text = "Cadastrar Ticket";
            this.btn_cad_ticket.UseVisualStyleBackColor = false;
            this.btn_cad_ticket.Click += new System.EventHandler(this.btn_cad_ticket_Click);
            // 
            // pic_menu_estac
            // 
            this.pic_menu_estac.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Vaga;
            this.pic_menu_estac.Location = new System.Drawing.Point(-9, 27);
            this.pic_menu_estac.Name = "pic_menu_estac";
            this.pic_menu_estac.Size = new System.Drawing.Size(508, 282);
            this.pic_menu_estac.TabIndex = 0;
            this.pic_menu_estac.TabStop = false;
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 300);
            this.Controls.Add(this.btn_cad_ticket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_hist_venda);
            this.Controls.Add(this.btn_cdt_veiculos);
            this.Controls.Add(this.btn_cdt_clientes);
            this.Controls.Add(this.pic_menu_estac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu_estac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_menu_estac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.Button btn_cdt_clientes;
        private System.Windows.Forms.Button btn_cdt_veiculos;
        private System.Windows.Forms.Button btn_hist_venda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selecao_base;
        private System.Windows.Forms.Button btn_cad_ticket;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}


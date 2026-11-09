
namespace Logclinic
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelFaixaTop = new System.Windows.Forms.Panel();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnconvenios = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnLedger = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelFaixaTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFaixaTop
            // 
            this.panelFaixaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panelFaixaTop.Controls.Add(this.lblOperador);
            this.panelFaixaTop.Controls.Add(this.btnLogout);
            this.panelFaixaTop.Controls.Add(this.pictureBox1);
            this.panelFaixaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFaixaTop.Location = new System.Drawing.Point(0, 0);
            this.panelFaixaTop.Name = "panelFaixaTop";
            this.panelFaixaTop.Size = new System.Drawing.Size(1184, 88);
            this.panelFaixaTop.TabIndex = 0;
            this.panelFaixaTop.UseWaitCursor = true;
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOperador.AutoEllipsis = true;
            this.lblOperador.AutoSize = true;
            this.lblOperador.ForeColor = System.Drawing.Color.White;
            this.lblOperador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOperador.Location = new System.Drawing.Point(1013, 28);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(20, 16);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "...";
            this.lblOperador.UseWaitCursor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1090, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.UseWaitCursor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnConfiguracoes);
            this.panelMenu.Controls.Add(this.btnRelatorios);
            this.panelMenu.Controls.Add(this.btnEstoque);
            this.panelMenu.Controls.Add(this.btnconvenios);
            this.panelMenu.Controls.Add(this.btnServicos);
            this.panelMenu.Controls.Add(this.btnFinanceiro);
            this.panelMenu.Controls.Add(this.btnLedger);
            this.panelMenu.Controls.Add(this.btnAgenda);
            this.panelMenu.Controls.Add(this.btnPaciente);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 88);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 743);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.UseWaitCursor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 670);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(251, 67);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.UseWaitCursor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.Image")));
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 603);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(251, 67);
            this.btnConfiguracoes.TabIndex = 9;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.UseWaitCursor = true;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 536);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(251, 67);
            this.btnRelatorios.TabIndex = 8;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.UseWaitCursor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 469);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(251, 67);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.UseWaitCursor = true;
            // 
            // btnconvenios
            // 
            this.btnconvenios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconvenios.FlatAppearance.BorderSize = 0;
            this.btnconvenios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnconvenios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvenios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvenios.ForeColor = System.Drawing.Color.White;
            this.btnconvenios.Image = ((System.Drawing.Image)(resources.GetObject("btnconvenios.Image")));
            this.btnconvenios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconvenios.Location = new System.Drawing.Point(0, 402);
            this.btnconvenios.Name = "btnconvenios";
            this.btnconvenios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnconvenios.Size = new System.Drawing.Size(251, 67);
            this.btnconvenios.TabIndex = 6;
            this.btnconvenios.Text = "Convênios";
            this.btnconvenios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconvenios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconvenios.UseVisualStyleBackColor = true;
            this.btnconvenios.UseWaitCursor = true;
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.White;
            this.btnServicos.Image = ((System.Drawing.Image)(resources.GetObject("btnServicos.Image")));
            this.btnServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.Location = new System.Drawing.Point(0, 335);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicos.Size = new System.Drawing.Size(251, 67);
            this.btnServicos.TabIndex = 5;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.UseWaitCursor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 268);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(251, 67);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.UseWaitCursor = true;
            // 
            // btnLedger
            // 
            this.btnLedger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLedger.FlatAppearance.BorderSize = 0;
            this.btnLedger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedger.ForeColor = System.Drawing.Color.White;
            this.btnLedger.Image = ((System.Drawing.Image)(resources.GetObject("btnLedger.Image")));
            this.btnLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLedger.Location = new System.Drawing.Point(0, 201);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLedger.Size = new System.Drawing.Size(251, 67);
            this.btnLedger.TabIndex = 3;
            this.btnLedger.Text = "Ledger";
            this.btnLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLedger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.UseWaitCursor = true;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(0, 134);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgenda.Size = new System.Drawing.Size(251, 67);
            this.btnAgenda.TabIndex = 2;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.UseWaitCursor = true;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 67);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(251, 67);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.UseWaitCursor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(251, 67);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.UseWaitCursor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(251, 88);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(933, 743);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.UseWaitCursor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 831);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelFaixaTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(2000, 1500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Clinic";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelFaixaTop.ResumeLayout(false);
            this.panelFaixaTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFaixaTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnconvenios;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnLedger;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnLogout;
    }
}



namespace Logclinic
{
    partial class FrmServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupServicosCadAlter = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTempo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomeProcedimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelComandos = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProcedimento = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datagridProcedimentos = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.groupServicosCadAlter.SuspendLayout();
            this.panelComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProcedimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.label2);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(933, 68);
            this.panelTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulte, adicione ou gerencie os serviços e procedimentos.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Serviçoss e Procedimentos";
            // 
            // groupServicosCadAlter
            // 
            this.groupServicosCadAlter.Controls.Add(this.label6);
            this.groupServicosCadAlter.Controls.Add(this.cboTempo);
            this.groupServicosCadAlter.Controls.Add(this.txtDescricao);
            this.groupServicosCadAlter.Controls.Add(this.txtValor);
            this.groupServicosCadAlter.Controls.Add(this.txtNomeProcedimento);
            this.groupServicosCadAlter.Controls.Add(this.label5);
            this.groupServicosCadAlter.Controls.Add(this.label4);
            this.groupServicosCadAlter.Controls.Add(this.label3);
            this.groupServicosCadAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupServicosCadAlter.Location = new System.Drawing.Point(12, 142);
            this.groupServicosCadAlter.Name = "groupServicosCadAlter";
            this.groupServicosCadAlter.Size = new System.Drawing.Size(897, 306);
            this.groupServicosCadAlter.TabIndex = 2;
            this.groupServicosCadAlter.TabStop = false;
            this.groupServicosCadAlter.Text = "Cadastrar ou alterar Serviços ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descrição:";
            // 
            // cboTempo
            // 
            this.cboTempo.FormattingEnabled = true;
            this.cboTempo.Location = new System.Drawing.Point(631, 72);
            this.cboTempo.Name = "cboTempo";
            this.cboTempo.Size = new System.Drawing.Size(195, 24);
            this.cboTempo.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(61, 140);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(765, 139);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(249, 74);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 22);
            this.txtValor.TabIndex = 4;
            // 
            // txtNomeProcedimento
            // 
            this.txtNomeProcedimento.Location = new System.Drawing.Point(249, 32);
            this.txtNomeProcedimento.Name = "txtNomeProcedimento";
            this.txtNomeProcedimento.Size = new System.Drawing.Size(577, 22);
            this.txtNomeProcedimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = " Tempo Estimado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor do Procedimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Procedimento:";
            // 
            // panelComandos
            // 
            this.panelComandos.Controls.Add(this.button4);
            this.panelComandos.Controls.Add(this.button3);
            this.panelComandos.Controls.Add(this.button2);
            this.panelComandos.Controls.Add(this.label7);
            this.panelComandos.Controls.Add(this.cboProcedimento);
            this.panelComandos.Controls.Add(this.button1);
            this.panelComandos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComandos.Location = new System.Drawing.Point(0, 68);
            this.panelComandos.Name = "panelComandos";
            this.panelComandos.Size = new System.Drawing.Size(933, 68);
            this.panelComandos.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(769, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 24);
            this.button4.TabIndex = 5;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(655, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(541, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Procedimento:";
            // 
            // cboProcedimento
            // 
            this.cboProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcedimento.FormattingEnabled = true;
            this.cboProcedimento.Location = new System.Drawing.Point(152, 24);
            this.cboProcedimento.Name = "cboProcedimento";
            this.cboProcedimento.Size = new System.Drawing.Size(235, 24);
            this.cboProcedimento.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datagridProcedimentos
            // 
            this.datagridProcedimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridProcedimentos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagridProcedimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridProcedimentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridProcedimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProcedimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProcedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProcedimentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridProcedimentos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridProcedimentos.Location = new System.Drawing.Point(12, 454);
            this.datagridProcedimentos.Name = "datagridProcedimentos";
            this.datagridProcedimentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProcedimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridProcedimentos.RowHeadersWidth = 30;
            this.datagridProcedimentos.Size = new System.Drawing.Size(897, 256);
            this.datagridProcedimentos.TabIndex = 4;
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(933, 743);
            this.Controls.Add(this.datagridProcedimentos);
            this.Controls.Add(this.panelComandos);
            this.Controls.Add(this.groupServicosCadAlter);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServicos";
            this.Text = "frmServicos";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.groupServicosCadAlter.ResumeLayout(false);
            this.groupServicosCadAlter.PerformLayout();
            this.panelComandos.ResumeLayout(false);
            this.panelComandos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProcedimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupServicosCadAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelComandos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNomeProcedimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTempo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProcedimento;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datagridProcedimentos;
    }
}
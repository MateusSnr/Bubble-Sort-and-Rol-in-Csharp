namespace TP06_200581
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.LstBoxAlturasFornecidas = new System.Windows.Forms.ListBox();
            this.GrpAlturasFornecidas = new System.Windows.Forms.GroupBox();
            this.GrpAlturasEmRol = new System.Windows.Forms.GroupBox();
            this.LstBoxAlturasEmRol = new System.Windows.Forms.ListBox();
            this.TmrAnimacao = new System.Windows.Forms.Timer(this.components);
            this.MenuStr = new System.Windows.Forms.MenuStrip();
            this.MenuDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.Limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstatisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalcularRol = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalcularMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMsgAnimacao = new System.Windows.Forms.Label();
            this.GrpBoxEntradaAltura = new System.Windows.Forms.GroupBox();
            this.LblComplementoQtd = new System.Windows.Forms.Label();
            this.TxtBoxEntradaQuantidade = new System.Windows.Forms.TextBox();
            this.TxtBoxEntradaAltura = new System.Windows.Forms.TextBox();
            this.LblComplementoAltura = new System.Windows.Forms.Label();
            this.LblContagemAltura = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpMediaDasAlturas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCalculoMediaDasAlturas = new System.Windows.Forms.Label();
            this.GrpAlturasFornecidas.SuspendLayout();
            this.GrpAlturasEmRol.SuspendLayout();
            this.MenuStr.SuspendLayout();
            this.GrpBoxEntradaAltura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpMediaDasAlturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstBoxAlturasFornecidas
            // 
            this.LstBoxAlturasFornecidas.FormattingEnabled = true;
            this.LstBoxAlturasFornecidas.ItemHeight = 16;
            this.LstBoxAlturasFornecidas.Location = new System.Drawing.Point(6, 25);
            this.LstBoxAlturasFornecidas.Name = "LstBoxAlturasFornecidas";
            this.LstBoxAlturasFornecidas.Size = new System.Drawing.Size(201, 164);
            this.LstBoxAlturasFornecidas.TabIndex = 0;
            // 
            // GrpAlturasFornecidas
            // 
            this.GrpAlturasFornecidas.Controls.Add(this.LstBoxAlturasFornecidas);
            this.GrpAlturasFornecidas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpAlturasFornecidas.Location = new System.Drawing.Point(3, 31);
            this.GrpAlturasFornecidas.Name = "GrpAlturasFornecidas";
            this.GrpAlturasFornecidas.Size = new System.Drawing.Size(214, 206);
            this.GrpAlturasFornecidas.TabIndex = 1;
            this.GrpAlturasFornecidas.TabStop = false;
            this.GrpAlturasFornecidas.Text = "Alturas fornecidas:";
            this.GrpAlturasFornecidas.Enter += new System.EventHandler(this.GrpAlturasFornecidas_Enter);
            // 
            // GrpAlturasEmRol
            // 
            this.GrpAlturasEmRol.Controls.Add(this.LstBoxAlturasEmRol);
            this.GrpAlturasEmRol.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpAlturasEmRol.Location = new System.Drawing.Point(3, 243);
            this.GrpAlturasEmRol.Name = "GrpAlturasEmRol";
            this.GrpAlturasEmRol.Size = new System.Drawing.Size(214, 207);
            this.GrpAlturasEmRol.TabIndex = 2;
            this.GrpAlturasEmRol.TabStop = false;
            this.GrpAlturasEmRol.Text = "Alturas em ROL:";
            // 
            // LstBoxAlturasEmRol
            // 
            this.LstBoxAlturasEmRol.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstBoxAlturasEmRol.FormattingEnabled = true;
            this.LstBoxAlturasEmRol.ItemHeight = 14;
            this.LstBoxAlturasEmRol.Location = new System.Drawing.Point(9, 25);
            this.LstBoxAlturasEmRol.Name = "LstBoxAlturasEmRol";
            this.LstBoxAlturasEmRol.Size = new System.Drawing.Size(198, 158);
            this.LstBoxAlturasEmRol.TabIndex = 0;
            // 
            // TmrAnimacao
            // 
            this.TmrAnimacao.Enabled = true;
            this.TmrAnimacao.Tick += new System.EventHandler(this.TmrAnimacao_Tick);
            // 
            // MenuStr
            // 
            this.MenuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDetalhes,
            this.MenuEstatisticas});
            this.MenuStr.Location = new System.Drawing.Point(0, 0);
            this.MenuStr.Name = "MenuStr";
            this.MenuStr.Size = new System.Drawing.Size(567, 24);
            this.MenuStr.TabIndex = 3;
            this.MenuStr.Text = "MenuStr";
            // 
            // MenuDetalhes
            // 
            this.MenuDetalhes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Limpar,
            this.MenuSobre});
            this.MenuDetalhes.Name = "MenuDetalhes";
            this.MenuDetalhes.Size = new System.Drawing.Size(64, 20);
            this.MenuDetalhes.Text = "Detalhes";
            // 
            // Limpar
            // 
            this.Limpar.Image = global::TP06_200581.Properties.Resources.actions_edit_clear_15784__1_;
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(111, 22);
            this.Limpar.Text = "Limpar";
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // MenuSobre
            // 
            this.MenuSobre.Image = global::TP06_200581.Properties.Resources.user_icon_icons_com_57997;
            this.MenuSobre.Name = "MenuSobre";
            this.MenuSobre.Size = new System.Drawing.Size(111, 22);
            this.MenuSobre.Text = "Sobre";
            this.MenuSobre.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // MenuEstatisticas
            // 
            this.MenuEstatisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCalcularRol,
            this.MenuCalcularMedia});
            this.MenuEstatisticas.Name = "MenuEstatisticas";
            this.MenuEstatisticas.Size = new System.Drawing.Size(76, 20);
            this.MenuEstatisticas.Text = "Estatísticas";
            // 
            // MenuCalcularRol
            // 
            this.MenuCalcularRol.Image = global::TP06_200581.Properties.Resources._3440925_business_calculator_ecommerce_finance_marketing_math_office_107525__1_;
            this.MenuCalcularRol.Name = "MenuCalcularRol";
            this.MenuCalcularRol.Size = new System.Drawing.Size(180, 22);
            this.MenuCalcularRol.Text = "Calcular Rol";
            this.MenuCalcularRol.Click += new System.EventHandler(this.MenuCalcularRol_Click);
            // 
            // MenuCalcularMedia
            // 
            this.MenuCalcularMedia.Image = global::TP06_200581.Properties.Resources._3592863_accounting_calculate_calculation_calculator_general_math_office_107744;
            this.MenuCalcularMedia.Name = "MenuCalcularMedia";
            this.MenuCalcularMedia.Size = new System.Drawing.Size(180, 22);
            this.MenuCalcularMedia.Text = "Calcular Média";
            this.MenuCalcularMedia.Click += new System.EventHandler(this.MenuCalcularMedia_Click);
            // 
            // LblMsgAnimacao
            // 
            this.LblMsgAnimacao.AutoSize = true;
            this.LblMsgAnimacao.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgAnimacao.Location = new System.Drawing.Point(219, 31);
            this.LblMsgAnimacao.Name = "LblMsgAnimacao";
            this.LblMsgAnimacao.Size = new System.Drawing.Size(347, 23);
            this.LblMsgAnimacao.TabIndex = 4;
            this.LblMsgAnimacao.Text = "Forneça até 50 alturas de uma determinada amostra";
            this.LblMsgAnimacao.Click += new System.EventHandler(this.LblAnimacao_Click);
            // 
            // GrpBoxEntradaAltura
            // 
            this.GrpBoxEntradaAltura.Controls.Add(this.LblComplementoQtd);
            this.GrpBoxEntradaAltura.Controls.Add(this.TxtBoxEntradaQuantidade);
            this.GrpBoxEntradaAltura.Controls.Add(this.TxtBoxEntradaAltura);
            this.GrpBoxEntradaAltura.Controls.Add(this.LblComplementoAltura);
            this.GrpBoxEntradaAltura.Controls.Add(this.LblContagemAltura);
            this.GrpBoxEntradaAltura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxEntradaAltura.Location = new System.Drawing.Point(223, 73);
            this.GrpBoxEntradaAltura.Name = "GrpBoxEntradaAltura";
            this.GrpBoxEntradaAltura.Size = new System.Drawing.Size(332, 79);
            this.GrpBoxEntradaAltura.TabIndex = 5;
            this.GrpBoxEntradaAltura.TabStop = false;
            this.GrpBoxEntradaAltura.Text = "Forneça a altura";
            // 
            // LblComplementoQtd
            // 
            this.LblComplementoQtd.AutoSize = true;
            this.LblComplementoQtd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComplementoQtd.Location = new System.Drawing.Point(13, 35);
            this.LblComplementoQtd.Name = "LblComplementoQtd";
            this.LblComplementoQtd.Size = new System.Drawing.Size(78, 16);
            this.LblComplementoQtd.TabIndex = 4;
            this.LblComplementoQtd.Text = "Quantidade:";
            // 
            // TxtBoxEntradaQuantidade
            // 
            this.TxtBoxEntradaQuantidade.Location = new System.Drawing.Point(94, 29);
            this.TxtBoxEntradaQuantidade.MaxLength = 2;
            this.TxtBoxEntradaQuantidade.Name = "TxtBoxEntradaQuantidade";
            this.TxtBoxEntradaQuantidade.Size = new System.Drawing.Size(39, 26);
            this.TxtBoxEntradaQuantidade.TabIndex = 3;
            this.TxtBoxEntradaQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBoxEntradaQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxEntradaQuantidade_Validating);
            // 
            // TxtBoxEntradaAltura
            // 
            this.TxtBoxEntradaAltura.Location = new System.Drawing.Point(256, 29);
            this.TxtBoxEntradaAltura.MaxLength = 3;
            this.TxtBoxEntradaAltura.Name = "TxtBoxEntradaAltura";
            this.TxtBoxEntradaAltura.Size = new System.Drawing.Size(39, 26);
            this.TxtBoxEntradaAltura.TabIndex = 2;
            this.TxtBoxEntradaAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBoxEntradaAltura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxEntradaAltura_Validating);
            // 
            // LblComplementoAltura
            // 
            this.LblComplementoAltura.AutoSize = true;
            this.LblComplementoAltura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComplementoAltura.Location = new System.Drawing.Point(196, 35);
            this.LblComplementoAltura.Name = "LblComplementoAltura";
            this.LblComplementoAltura.Size = new System.Drawing.Size(54, 16);
            this.LblComplementoAltura.TabIndex = 1;
            this.LblComplementoAltura.Text = "° Altura:";
            // 
            // LblContagemAltura
            // 
            this.LblContagemAltura.AutoSize = true;
            this.LblContagemAltura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContagemAltura.Location = new System.Drawing.Point(166, 35);
            this.LblContagemAltura.Name = "LblContagemAltura";
            this.LblContagemAltura.Size = new System.Drawing.Size(15, 16);
            this.LblContagemAltura.TabIndex = 0;
            this.LblContagemAltura.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP06_200581.Properties.Resources.alturas_pessoas_paises__2___1_;
            this.pictureBox1.Location = new System.Drawing.Point(223, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 151);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // GrpMediaDasAlturas
            // 
            this.GrpMediaDasAlturas.Controls.Add(this.label1);
            this.GrpMediaDasAlturas.Controls.Add(this.LblCalculoMediaDasAlturas);
            this.GrpMediaDasAlturas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMediaDasAlturas.Location = new System.Drawing.Point(223, 316);
            this.GrpMediaDasAlturas.Name = "GrpMediaDasAlturas";
            this.GrpMediaDasAlturas.Size = new System.Drawing.Size(319, 134);
            this.GrpMediaDasAlturas.TabIndex = 7;
            this.GrpMediaDasAlturas.TabStop = false;
            this.GrpMediaDasAlturas.Text = "Média das Alturas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "(centímetros)";
            // 
            // LblCalculoMediaDasAlturas
            // 
            this.LblCalculoMediaDasAlturas.AutoSize = true;
            this.LblCalculoMediaDasAlturas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalculoMediaDasAlturas.Location = new System.Drawing.Point(91, 61);
            this.LblCalculoMediaDasAlturas.Name = "LblCalculoMediaDasAlturas";
            this.LblCalculoMediaDasAlturas.Size = new System.Drawing.Size(0, 16);
            this.LblCalculoMediaDasAlturas.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP06_200581.Properties.Resources.D_NQ_NP_997869_MLB31696361166_082019_O;
            this.ClientSize = new System.Drawing.Size(567, 455);
            this.Controls.Add(this.GrpMediaDasAlturas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrpBoxEntradaAltura);
            this.Controls.Add(this.LblMsgAnimacao);
            this.Controls.Add(this.GrpAlturasEmRol);
            this.Controls.Add(this.GrpAlturasFornecidas);
            this.Controls.Add(this.MenuStr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStr;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Algoritmo Rol e Cálculo da Média";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.GrpAlturasFornecidas.ResumeLayout(false);
            this.GrpAlturasEmRol.ResumeLayout(false);
            this.MenuStr.ResumeLayout(false);
            this.MenuStr.PerformLayout();
            this.GrpBoxEntradaAltura.ResumeLayout(false);
            this.GrpBoxEntradaAltura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpMediaDasAlturas.ResumeLayout(false);
            this.GrpMediaDasAlturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxAlturasFornecidas;
        private System.Windows.Forms.GroupBox GrpAlturasFornecidas;
        private System.Windows.Forms.GroupBox GrpAlturasEmRol;
        private System.Windows.Forms.ListBox LstBoxAlturasEmRol;
        private System.Windows.Forms.Timer TmrAnimacao;
        private System.Windows.Forms.MenuStrip MenuStr;
        private System.Windows.Forms.ToolStripMenuItem MenuDetalhes;
        private System.Windows.Forms.ToolStripMenuItem Limpar;
        private System.Windows.Forms.ToolStripMenuItem MenuSobre;
        private System.Windows.Forms.ToolStripMenuItem MenuEstatisticas;
        private System.Windows.Forms.ToolStripMenuItem MenuCalcularRol;
        private System.Windows.Forms.ToolStripMenuItem MenuCalcularMedia;
        private System.Windows.Forms.Label LblMsgAnimacao;
        private System.Windows.Forms.GroupBox GrpBoxEntradaAltura;
        private System.Windows.Forms.TextBox TxtBoxEntradaAltura;
        private System.Windows.Forms.Label LblComplementoAltura;
        private System.Windows.Forms.Label LblContagemAltura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrpMediaDasAlturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCalculoMediaDasAlturas;
        private System.Windows.Forms.TextBox TxtBoxEntradaQuantidade;
        private System.Windows.Forms.Label LblComplementoQtd;
    }
}


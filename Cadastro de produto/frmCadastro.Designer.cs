namespace Cadastro_de_produto
{
    partial class frmCadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.mspMenuprincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mspProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mspCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mspMenu.SuspendLayout();
            this.gpbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 107);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(26, 172);
            this.txtPreco.MaxLength = 1000;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(158, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(23, 156);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 335);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 32);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(26, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID";
            // 
            // mspMenu
            // 
            this.mspMenu.BackColor = System.Drawing.Color.LightPink;
            this.mspMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspMenuprincipal,
            this.mspProduto,
            this.mspCaixa});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mspMenu.Size = new System.Drawing.Size(482, 24);
            this.mspMenu.TabIndex = 17;
            this.mspMenu.Text = "menuStrip1";
            // 
            // mspMenuprincipal
            // 
            this.mspMenuprincipal.Name = "mspMenuprincipal";
            this.mspMenuprincipal.Size = new System.Drawing.Size(50, 20);
            this.mspMenuprincipal.Text = "Menu";
            this.mspMenuprincipal.Click += new System.EventHandler(this.mspMenuprincipal_Click);
            // 
            // mspProduto
            // 
            this.mspProduto.Name = "mspProduto";
            this.mspProduto.Size = new System.Drawing.Size(67, 20);
            this.mspProduto.Text = "Produtos";
            this.mspProduto.Click += new System.EventHandler(this.mspProduto_Click);
            // 
            // mspCaixa
            // 
            this.mspCaixa.Name = "mspCaixa";
            this.mspCaixa.Size = new System.Drawing.Size(48, 20);
            this.mspCaixa.Text = "Caixa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(26, 234);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(158, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 218);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(192, 335);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 32);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.lblDescricao);
            this.gpbCadastro.Controls.Add(this.txtDescricao);
            this.gpbCadastro.Controls.Add(this.lblId);
            this.gpbCadastro.Controls.Add(this.txtId);
            this.gpbCadastro.Controls.Add(this.lblPreco);
            this.gpbCadastro.Controls.Add(this.lblNome);
            this.gpbCadastro.Controls.Add(this.txtPreco);
            this.gpbCadastro.Controls.Add(this.txtNome);
            this.gpbCadastro.Location = new System.Drawing.Point(12, 40);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(447, 277);
            this.gpbCadastro.TabIndex = 22;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro do Produto";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(374, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 32);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(283, 335);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 32);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(99, 335);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 32);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.mspMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem mspMenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem mspProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolStripMenuItem mspCaixa;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
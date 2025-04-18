namespace Cadastro_de_produto
{
    partial class frmAtualizarProdutos
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mspMenuprincipal = new System.Windows.Forms.MenuStrip();
            this.mspMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mspCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mspProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mspVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenuprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(37, 86);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(199, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(37, 238);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(199, 22);
            this.txtPreco.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 66);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(33, 218);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(43, 16);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(395, 336);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(157, 41);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 161);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 142);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // mspMenuprincipal
            // 
            this.mspMenuprincipal.BackColor = System.Drawing.Color.LightPink;
            this.mspMenuprincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMenuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspMenu,
            this.mspCadastro,
            this.mspProdutos,
            this.mspVoltar});
            this.mspMenuprincipal.Location = new System.Drawing.Point(0, 0);
            this.mspMenuprincipal.Name = "mspMenuprincipal";
            this.mspMenuprincipal.Size = new System.Drawing.Size(595, 28);
            this.mspMenuprincipal.TabIndex = 9;
            this.mspMenuprincipal.Text = "menuStrip1";
            // 
            // mspMenu
            // 
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(60, 24);
            this.mspMenu.Text = "Menu";
            // 
            // mspCadastro
            // 
            this.mspCadastro.Name = "mspCadastro";
            this.mspCadastro.Size = new System.Drawing.Size(82, 24);
            this.mspCadastro.Text = "Cadastro";
            // 
            // mspProdutos
            // 
            this.mspProdutos.Name = "mspProdutos";
            this.mspProdutos.Size = new System.Drawing.Size(82, 24);
            this.mspProdutos.Text = "Produtos";
            // 
            // mspVoltar
            // 
            this.mspVoltar.Name = "mspVoltar";
            this.mspVoltar.Size = new System.Drawing.Size(62, 24);
            this.mspVoltar.Text = "Voltar";
            // 
            // frmAtualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 404);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mspMenuprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mspMenuprincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAtualizarProdutos";
            this.Text = "Atualizar Produtos";
            this.mspMenuprincipal.ResumeLayout(false);
            this.mspMenuprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MenuStrip mspMenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem mspMenu;
        private System.Windows.Forms.ToolStripMenuItem mspCadastro;
        private System.Windows.Forms.ToolStripMenuItem mspProdutos;
        private System.Windows.Forms.ToolStripMenuItem mspVoltar;
    }
}
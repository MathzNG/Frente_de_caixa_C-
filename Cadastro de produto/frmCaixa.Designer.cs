namespace Cadastro_de_produto
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.lblInvisibleTotal = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblInvisiblepreco = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.pctFundo = new System.Windows.Forms.PictureBox();
            this.lblNada = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPreco.Location = new System.Drawing.Point(53, 196);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(113, 40);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço :";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantidade.Location = new System.Drawing.Point(53, 372);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(172, 40);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValorTotal.Location = new System.Drawing.Point(635, 503);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(101, 40);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Total :";
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.ItemHeight = 16;
            this.ltbProdutos.Location = new System.Drawing.Point(532, 15);
            this.ltbProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(491, 420);
            this.ltbProdutos.TabIndex = 4;
            this.ltbProdutos.SelectedIndexChanged += new System.EventHandler(this.ltbProdutos_SelectedIndexChanged);
            // 
            // lblInvisibleTotal
            // 
            this.lblInvisibleTotal.AutoSize = true;
            this.lblInvisibleTotal.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvisibleTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvisibleTotal.Location = new System.Drawing.Point(777, 508);
            this.lblInvisibleTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvisibleTotal.Name = "lblInvisibleTotal";
            this.lblInvisibleTotal.Size = new System.Drawing.Size(0, 40);
            this.lblInvisibleTotal.TabIndex = 5;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudQuantidade.Location = new System.Drawing.Point(73, 416);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(129, 22);
            this.nudQuantidade.TabIndex = 6;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // lblInvisiblepreco
            // 
            this.lblInvisiblepreco.AutoSize = true;
            this.lblInvisiblepreco.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvisiblepreco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvisiblepreco.Location = new System.Drawing.Point(235, 196);
            this.lblInvisiblepreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvisiblepreco.Name = "lblInvisiblepreco";
            this.lblInvisiblepreco.Size = new System.Drawing.Size(0, 40);
            this.lblInvisiblepreco.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(16, 636);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(113, 34);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(897, 620);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(113, 34);
            this.btnConfirma.TabIndex = 12;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click_1);
            this.btnConfirma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnConfirma_KeyDown);
            // 
            // pctFundo
            // 
            this.pctFundo.Image = ((System.Drawing.Image)(resources.GetObject("pctFundo.Image")));
            this.pctFundo.Location = new System.Drawing.Point(-2, -1);
            this.pctFundo.Margin = new System.Windows.Forms.Padding(4);
            this.pctFundo.Name = "pctFundo";
            this.pctFundo.Size = new System.Drawing.Size(1040, 686);
            this.pctFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFundo.TabIndex = 0;
            this.pctFundo.TabStop = false;
            // 
            // lblNada
            // 
            this.lblNada.AutoSize = true;
            this.lblNada.Location = new System.Drawing.Point(239, 74);
            this.lblNada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNada.Name = "lblNada";
            this.lblNada.Size = new System.Drawing.Size(0, 16);
            this.lblNada.TabIndex = 13;
            this.lblNada.Visible = false;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CustomFormat = "yyyy/MM/dd";
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(61, 30);
            this.dtpDataVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(125, 22);
            this.dtpDataVenda.TabIndex = 14;
            this.dtpDataVenda.Value = new System.DateTime(2025, 4, 27, 0, 0, 0, 0);
            // 
            // cbbProduto
            // 
            this.cbbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(53, 117);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(172, 30);
            this.cbbProduto.TabIndex = 15;
            this.cbbProduto.SelectedIndexChanged += new System.EventHandler(this.cbbProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(53, 74);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(113, 40);
            this.lblProduto.TabIndex = 16;
            this.lblProduto.Text = "Código";
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 686);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.lblNada);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblInvisiblepreco);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblInvisibleTotal);
            this.Controls.Add(this.ltbProdutos);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.pctFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Label lblInvisibleTotal;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblInvisiblepreco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.PictureBox pctFundo;
        private System.Windows.Forms.Label lblNada;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
    }
}
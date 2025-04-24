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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.pctFundo = new System.Windows.Forms.PictureBox();
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
            this.ltbProdutos.Location = new System.Drawing.Point(559, 15);
            this.ltbProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(464, 372);
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
            this.nudQuantidade.Location = new System.Drawing.Point(80, 421);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(113, 34);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.LightPink;
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker2.Location = new System.Drawing.Point(61, 39);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(897, 620);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pctFundo.Location = new System.Drawing.Point(0, 0);
            this.pctFundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctFundo.Name = "pctFundo";
            this.pctFundo.Size = new System.Drawing.Size(1040, 686);
            this.pctFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFundo.TabIndex = 0;
            this.pctFundo.TabStop = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 686);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.dateTimePicker2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.PictureBox pctFundo;
    }
}
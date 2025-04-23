namespace Cadastro_de_produto
{
    partial class frmVendas
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalvendas = new System.Windows.Forms.Label();
            this.ltbValor = new System.Windows.Forms.ListBox();
            this.lblData = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTotaldasvendas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // lblTotalvendas
            // 
            this.lblTotalvendas.AutoSize = true;
            this.lblTotalvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalvendas.Location = new System.Drawing.Point(35, 191);
            this.lblTotalvendas.Name = "lblTotalvendas";
            this.lblTotalvendas.Size = new System.Drawing.Size(118, 18);
            this.lblTotalvendas.TabIndex = 1;
            this.lblTotalvendas.Text = "Total de Vendas:";
            // 
            // ltbValor
            // 
            this.ltbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbValor.FormattingEnabled = true;
            this.ltbValor.ItemHeight = 18;
            this.ltbValor.Location = new System.Drawing.Point(204, 61);
            this.ltbValor.Name = "ltbValor";
            this.ltbValor.Size = new System.Drawing.Size(262, 220);
            this.ltbValor.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(35, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 18);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data da Venda";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(51, 111);
            this.maskedTextBox1.Mask = "99/99/9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // lblTotaldasvendas
            // 
            this.lblTotaldasvendas.AutoSize = true;
            this.lblTotaldasvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaldasvendas.Location = new System.Drawing.Point(33, 238);
            this.lblTotaldasvendas.Name = "lblTotaldasvendas";
            this.lblTotaldasvendas.Size = new System.Drawing.Size(123, 25);
            this.lblTotaldasvendas.TabIndex = 8;
            this.lblTotaldasvendas.Text = "lblInvisivel";
            this.lblTotaldasvendas.Visible = false;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 373);
            this.Controls.Add(this.lblTotaldasvendas);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.ltbValor);
            this.Controls.Add(this.lblTotalvendas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVendas";
            this.Text = "Vendas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalvendas;
        private System.Windows.Forms.ListBox ltbValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTotaldasvendas;
    }
}
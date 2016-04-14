namespace Terminal
{
    partial class CozinhaBar
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
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPreparacao = new System.Windows.Forms.DataGridView();
            this.idprep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoPrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPreparacao = new System.Windows.Forms.Button();
            this.buttonPronto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreparacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.AllowUserToAddRows = false;
            this.dataGridPedidos.AllowUserToDeleteRows = false;
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.quantidade,
            this.estado});
            this.dataGridPedidos.Location = new System.Drawing.Point(14, 65);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.ReadOnly = true;
            this.dataGridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPedidos.Size = new System.Drawing.Size(452, 350);
            this.dataGridPedidos.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // dataGridPreparacao
            // 
            this.dataGridPreparacao.AllowUserToAddRows = false;
            this.dataGridPreparacao.AllowUserToDeleteRows = false;
            this.dataGridPreparacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreparacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprep,
            this.descricaoPrep,
            this.quantidade2,
            this.estadoPrep});
            this.dataGridPreparacao.Location = new System.Drawing.Point(490, 65);
            this.dataGridPreparacao.Name = "dataGridPreparacao";
            this.dataGridPreparacao.ReadOnly = true;
            this.dataGridPreparacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPreparacao.Size = new System.Drawing.Size(445, 350);
            this.dataGridPreparacao.TabIndex = 1;
            // 
            // idprep
            // 
            this.idprep.HeaderText = "ID";
            this.idprep.Name = "idprep";
            this.idprep.ReadOnly = true;
            // 
            // descricaoPrep
            // 
            this.descricaoPrep.HeaderText = "Descrição";
            this.descricaoPrep.Name = "descricaoPrep";
            this.descricaoPrep.ReadOnly = true;
            // 
            // quantidade2
            // 
            this.quantidade2.HeaderText = "Quantidade";
            this.quantidade2.Name = "quantidade2";
            this.quantidade2.ReadOnly = true;
            // 
            // estadoPrep
            // 
            this.estadoPrep.HeaderText = "Estado";
            this.estadoPrep.Name = "estadoPrep";
            this.estadoPrep.ReadOnly = true;
            // 
            // buttonPreparacao
            // 
            this.buttonPreparacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreparacao.Location = new System.Drawing.Point(170, 421);
            this.buttonPreparacao.Name = "buttonPreparacao";
            this.buttonPreparacao.Size = new System.Drawing.Size(154, 84);
            this.buttonPreparacao.TabIndex = 2;
            this.buttonPreparacao.Text = "Em Preparação";
            this.buttonPreparacao.UseVisualStyleBackColor = true;
            this.buttonPreparacao.Click += new System.EventHandler(this.buttonPreparacao_Click);
            // 
            // buttonPronto
            // 
            this.buttonPronto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPronto.Location = new System.Drawing.Point(638, 421);
            this.buttonPronto.Name = "buttonPronto";
            this.buttonPronto.Size = new System.Drawing.Size(154, 84);
            this.buttonPronto.TabIndex = 3;
            this.buttonPronto.Text = "Pronto";
            this.buttonPronto.UseVisualStyleBackColor = true;
            this.buttonPronto.Click += new System.EventHandler(this.buttonPronto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pedidos em espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedidos em preparação";
            // 
            // CozinhaBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPronto);
            this.Controls.Add(this.buttonPreparacao);
            this.Controls.Add(this.dataGridPreparacao);
            this.Controls.Add(this.dataGridPedidos);
            this.Name = "CozinhaBar";
            this.Text = "CozinhaBar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreparacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.DataGridView dataGridPreparacao;
        private System.Windows.Forms.Button buttonPreparacao;
        private System.Windows.Forms.Button buttonPronto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprep;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoPrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPrep;
    }
}
﻿namespace Sala
{
    partial class Sala
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelMesa = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.comboBoxQuantidade = new System.Windows.Forms.ComboBox();
            this.comboBoxMesa = new System.Windows.Forms.ComboBox();
            this.buttonPedir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelTipoMutavel = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(81, 31);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.AccessibleName = "comboBoxMenu";
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(18, 62);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(230, 21);
            this.comboBoxMenu.TabIndex = 1;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesa.Location = new System.Drawing.Point(15, 133);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(80, 31);
            this.labelMesa.TabIndex = 3;
            this.labelMesa.Text = "Mesa";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(281, 9);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(154, 31);
            this.labelQuantidade.TabIndex = 4;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidade
            // 
            this.comboBoxQuantidade.FormattingEnabled = true;
            this.comboBoxQuantidade.Location = new System.Drawing.Point(287, 62);
            this.comboBoxQuantidade.Name = "comboBoxQuantidade";
            this.comboBoxQuantidade.Size = new System.Drawing.Size(230, 21);
            this.comboBoxQuantidade.TabIndex = 5;
            // 
            // comboBoxMesa
            // 
            this.comboBoxMesa.FormattingEnabled = true;
            this.comboBoxMesa.Location = new System.Drawing.Point(18, 176);
            this.comboBoxMesa.Name = "comboBoxMesa";
            this.comboBoxMesa.Size = new System.Drawing.Size(230, 21);
            this.comboBoxMesa.TabIndex = 6;
            // 
            // buttonPedir
            // 
            this.buttonPedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedir.Location = new System.Drawing.Point(381, 251);
            this.buttonPedir.Name = "buttonPedir";
            this.buttonPedir.Size = new System.Drawing.Size(136, 85);
            this.buttonPedir.TabIndex = 7;
            this.buttonPedir.Text = "Pedir";
            this.buttonPedir.UseVisualStyleBackColor = true;
            this.buttonPedir.Click += new System.EventHandler(this.buttonPedir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(21, 251);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(136, 85);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(281, 133);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(67, 31);
            this.labelTipo.TabIndex = 9;
            this.labelTipo.Text = "Tipo";
            // 
            // labelTipoMutavel
            // 
            this.labelTipoMutavel.AutoSize = true;
            this.labelTipoMutavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoMutavel.Location = new System.Drawing.Point(281, 166);
            this.labelTipoMutavel.Name = "labelTipoMutavel";
            this.labelTipoMutavel.Size = new System.Drawing.Size(0, 25);
            this.labelTipoMutavel.TabIndex = 10;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // mesa
            // 
            this.mesa.HeaderText = "Mesa";
            this.mesa.Name = "mesa";
            this.mesa.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // gridPedidos
            // 
            this.gridPedidos.AllowUserToAddRows = false;
            this.gridPedidos.AllowUserToDeleteRows = false;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.mesa,
            this.tipo,
            this.estado});
            this.gridPedidos.Location = new System.Drawing.Point(21, 355);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.gridPedidos.RowTemplate.ReadOnly = true;
            this.gridPedidos.Size = new System.Drawing.Size(545, 150);
            this.gridPedidos.TabIndex = 11;
            // 
            // Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 517);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.labelTipoMutavel);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonPedir);
            this.Controls.Add(this.comboBoxMesa);
            this.Controls.Add(this.comboBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelMesa);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.labelMenu);
            this.Name = "Sala";
            this.Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox comboBoxQuantidade;
        private System.Windows.Forms.ComboBox comboBoxMesa;
        private System.Windows.Forms.Button buttonPedir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelTipoMutavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView gridPedidos;
    }
}
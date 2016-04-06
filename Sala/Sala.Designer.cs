namespace Sala
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
            this.buttonPedir.Location = new System.Drawing.Point(381, 281);
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
            this.buttonCancelar.Location = new System.Drawing.Point(21, 281);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(136, 85);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
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
            // Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 398);
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
            this.Text = "Form1";
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
    }
}
﻿namespace projetoMJM
{
    partial class AdicionarProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProjeto));
            this.adicionar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orcamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.integrante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prazo = new System.Windows.Forms.MaskedTextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.Gold;
            this.adicionar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.Location = new System.Drawing.Point(323, 398);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(146, 36);
            this.adicionar.TabIndex = 12;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(323, 136);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(318, 35);
            this.tipo.TabIndex = 11;
            this.tipo.TextChanged += new System.EventHandler(this.tipo_TextChanged);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(323, 91);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(318, 35);
            this.nome.TabIndex = 10;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do Projeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adicionar Projeto ";
            // 
            // descricao
            // 
            this.descricao.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(323, 179);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(318, 35);
            this.descricao.TabIndex = 15;
            this.descricao.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição do Projeto";
            // 
            // orcamento
            // 
            this.orcamento.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orcamento.Location = new System.Drawing.Point(323, 225);
            this.orcamento.Name = "orcamento";
            this.orcamento.Size = new System.Drawing.Size(318, 35);
            this.orcamento.TabIndex = 17;
            this.orcamento.TextChanged += new System.EventHandler(this.orcamento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Orçamento do Projeto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prazo do Projeto";
            // 
            // integrante
            // 
            this.integrante.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrante.Location = new System.Drawing.Point(323, 355);
            this.integrante.Name = "integrante";
            this.integrante.Size = new System.Drawing.Size(318, 35);
            this.integrante.TabIndex = 21;
            this.integrante.TextChanged += new System.EventHandler(this.integrante_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Integrantes do Projeto";
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(323, 44);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(318, 35);
            this.codigo.TabIndex = 23;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Código do Projeto";
            // 
            // prazo
            // 
            this.prazo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazo.Location = new System.Drawing.Point(323, 310);
            this.prazo.Margin = new System.Windows.Forms.Padding(2);
            this.prazo.Mask = "00/00/0000";
            this.prazo.Name = "prazo";
            this.prazo.Size = new System.Drawing.Size(108, 35);
            this.prazo.TabIndex = 60;
            this.prazo.ValidatingType = typeof(System.DateTime);
            this.prazo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.prazo_MaskInputRejected);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(323, 267);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(318, 35);
            this.status.TabIndex = 62;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(115, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Status do Projeto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::projetoMJM.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(674, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::projetoMJM.Properties.Resources.pngwing_com__11_;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::projetoMJM.Properties.Resources.pngwing_com__12_;
            this.pictureBox3.Location = new System.Drawing.Point(739, -56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // AdicionarProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 440);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prazo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.integrante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orcamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(788, 479);
            this.MinimumSize = new System.Drawing.Size(788, 479);
            this.Name = "AdicionarProjeto";
            this.Text = "CadastroProjeto";
            this.Load += new System.EventHandler(this.AdicionarProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox integrante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox prazo;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        protected internal System.Windows.Forms.PictureBox pictureBox3;
    }
}
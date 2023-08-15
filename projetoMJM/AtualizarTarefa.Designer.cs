namespace projetoMJM
{
    partial class AtualizarTarefa
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
            this.prazo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tarefa1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.integrante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Atualizar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // prazo
            // 
            this.prazo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazo.Location = new System.Drawing.Point(316, 323);
            this.prazo.Margin = new System.Windows.Forms.Padding(2);
            this.prazo.Mask = "00/00/0000";
            this.prazo.Name = "prazo";
            this.prazo.Size = new System.Drawing.Size(108, 35);
            this.prazo.TabIndex = 72;
            this.prazo.ValidatingType = typeof(System.DateTime);
            this.prazo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.prazo_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 71;
            this.label6.Text = "Prazo";
            // 
            // tarefa1
            // 
            this.tarefa1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarefa1.Location = new System.Drawing.Point(316, 223);
            this.tarefa1.Name = "tarefa1";
            this.tarefa1.Size = new System.Drawing.Size(318, 35);
            this.tarefa1.TabIndex = 70;
            this.tarefa1.TextChanged += new System.EventHandler(this.tarefa1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tarefa";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(316, 274);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(318, 35);
            this.status.TabIndex = 68;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "Status";
            // 
            // integrante
            // 
            this.integrante.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrante.Location = new System.Drawing.Point(316, 175);
            this.integrante.Name = "integrante";
            this.integrante.Size = new System.Drawing.Size(318, 35);
            this.integrante.TabIndex = 66;
            this.integrante.TextChanged += new System.EventHandler(this.integrante_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Integrante";
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Gold;
            this.Atualizar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(310, 371);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(169, 36);
            this.Atualizar.TabIndex = 64;
            this.Atualizar.Text = "Atualizar Tarefa";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(316, 124);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(318, 35);
            this.codigo.TabIndex = 63;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Código da Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Atualizar Tarefa";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(316, 77);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(318, 35);
            this.nome.TabIndex = 75;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 74;
            this.label7.Text = "Nome do Projeto";
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
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::projetoMJM.Properties.Resources.pngwing10;
            this.pictureBox3.Location = new System.Drawing.Point(-4, -72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::projetoMJM.Properties.Resources.pngwing9;
            this.pictureBox4.Location = new System.Drawing.Point(736, -56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 99);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // AtualizarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prazo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarefa1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.integrante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(788, 478);
            this.MinimumSize = new System.Drawing.Size(788, 478);
            this.Name = "AtualizarTarefa";
            this.Text = "AtualizarTarefa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox prazo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tarefa1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox integrante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
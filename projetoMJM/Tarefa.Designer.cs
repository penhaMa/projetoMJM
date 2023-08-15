namespace projetoMJM
{
    partial class Tarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefa));
            this.Adicionar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.integrante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tarefa1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prazo = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.Gold;
            this.Adicionar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.Location = new System.Drawing.Point(413, 457);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(225, 44);
            this.Adicionar.TabIndex = 51;
            this.Adicionar.Text = "Adicionar Tarefa";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(421, 126);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(423, 42);
            this.codigo.TabIndex = 49;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 35);
            this.label2.TabIndex = 48;
            this.label2.Text = "Código do Projeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "Gerenciador de Tarefa";
            // 
            // integrante
            // 
            this.integrante.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrante.Location = new System.Drawing.Point(421, 192);
            this.integrante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.integrante.Name = "integrante";
            this.integrante.Size = new System.Drawing.Size(423, 42);
            this.integrante.TabIndex = 53;
            this.integrante.TextChanged += new System.EventHandler(this.integrante_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 35);
            this.label3.TabIndex = 52;
            this.label3.Text = "Integrante";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(421, 320);
            this.status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(423, 42);
            this.status.TabIndex = 55;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 54;
            this.label4.Text = "Status";
            // 
            // tarefa1
            // 
            this.tarefa1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarefa1.Location = new System.Drawing.Point(421, 258);
            this.tarefa1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tarefa1.Name = "tarefa1";
            this.tarefa1.Size = new System.Drawing.Size(423, 42);
            this.tarefa1.TabIndex = 57;
            this.tarefa1.TextChanged += new System.EventHandler(this.tarefa1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 35);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tarefa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 35);
            this.label6.TabIndex = 58;
            this.label6.Text = "Prazo";
            // 
            // prazo
            // 
            this.prazo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazo.Location = new System.Drawing.Point(421, 382);
            this.prazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prazo.Mask = "00/00/0000";
            this.prazo.Name = "prazo";
            this.prazo.Size = new System.Drawing.Size(143, 42);
            this.prazo.TabIndex = 59;
            this.prazo.ValidatingType = typeof(System.DateTime);
            this.prazo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.prazo_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::projetoMJM.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(899, 450);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Tarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prazo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarefa1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.integrante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1045, 579);
            this.MinimumSize = new System.Drawing.Size(1045, 579);
            this.Name = "Tarefa";
            this.Text = "Tarefa";
            this.Load += new System.EventHandler(this.Tarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox integrante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tarefa1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox prazo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
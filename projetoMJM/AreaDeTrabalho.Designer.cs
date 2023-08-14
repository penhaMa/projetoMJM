namespace projetoMJM
{
    partial class AreaDeTrabalho
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.ExcluirP = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Adicionar Projeto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gerenciador de Projetos MJM";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(171, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Black;
            this.Sair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(641, 389);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(119, 38);
            this.Sair.TabIndex = 27;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ExcluirP
            // 
            this.ExcluirP.BackColor = System.Drawing.Color.Gold;
            this.ExcluirP.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirP.Location = new System.Drawing.Point(408, 302);
            this.ExcluirP.Name = "ExcluirP";
            this.ExcluirP.Size = new System.Drawing.Size(193, 36);
            this.ExcluirP.TabIndex = 28;
            this.ExcluirP.Text = "Excluir Projeto";
            this.ExcluirP.UseVisualStyleBackColor = false;
            this.ExcluirP.Click += new System.EventHandler(this.ExcluirP_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(292, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "Atualizar Projeto";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(508, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "Adicionar Tarefa";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::projetoMJM.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(347, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // AreaDeTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ExcluirP);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(788, 478);
            this.MinimumSize = new System.Drawing.Size(788, 478);
            this.Name = "AreaDeTrabalho";
            this.Text = "AreaDeTrabalho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button ExcluirP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
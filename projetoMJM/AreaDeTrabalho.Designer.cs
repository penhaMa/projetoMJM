﻿namespace projetoMJM
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Adicionar Projeto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Área de Trabalho";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(315, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(315, 369);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(193, 36);
            this.Sair.TabIndex = 27;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ExcluirP
            // 
            this.ExcluirP.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirP.Location = new System.Drawing.Point(315, 322);
            this.ExcluirP.Name = "ExcluirP";
            this.ExcluirP.Size = new System.Drawing.Size(193, 36);
            this.ExcluirP.TabIndex = 28;
            this.ExcluirP.Text = "Excluir Projeto";
            this.ExcluirP.UseVisualStyleBackColor = true;
            this.ExcluirP.Click += new System.EventHandler(this.ExcluirP_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(315, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "Gerenciar Projeto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(315, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "Adicionar Tarefa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AreaDeTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 442);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ExcluirP);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(789, 481);
            this.MinimumSize = new System.Drawing.Size(789, 481);
            this.Name = "AreaDeTrabalho";
            this.Text = "AreaDeTrabalho";
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
    }
}
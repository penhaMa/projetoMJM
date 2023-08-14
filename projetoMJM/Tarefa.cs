﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMJM
{
    public partial class Tarefa : Form
    {
        DAO cone;
        public Tarefa()
        {
            InitializeComponent();
            cone = new DAO();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Codigo

        private void integrante_TextChanged(object sender, EventArgs e)
        {

        }//Integrante

        private void tarefa1_TextChanged(object sender, EventArgs e)
        {

        }//Tarefa

        private void status_TextChanged(object sender, EventArgs e)
        {

        }//Status

        private void prazo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Prazo

        private void Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string result = cone.CadastrarTarefa(codigo.Text, integrante.Text, tarefa1.Text, status.Text, Convert.ToDateTime(prazo.Text), "bancoTarefa");
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch

        }//Adicionar

        private void Tarefa_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto

using System;
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
    public partial class AtualizarTarefa : Form
    {
        DAO conectar;
        public AtualizarTarefa()
        {
            InitializeComponent();
            conectar = new DAO();//Conecta a DAO
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            conectar.AtualizarTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa", "nomeProjeto", nome.Text);//Atualiza o nome do projeto
            conectar.AtualizarTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa", "integrante", integrante.Text);//Atualiza o integrante
            conectar.AtualizarTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa", "tarefa", tarefa1.Text);//Atualiza a tarefa
            conectar.AtualizarTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa", "stat", status.Text);//Atualiza o stat
            conectar.AtualizarTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa", "prazo", prazo.Text);//Atualiza o prazo
            
            MessageBox.Show("Dados Atualizados com Sucesso!");//Mensagem para o úsuario 
        }//Atualizar

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

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Nome do Projeto

    }//Fim da classe
}//Fim do Projeto

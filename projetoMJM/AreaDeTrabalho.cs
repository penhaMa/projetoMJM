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
    public partial class AreaDeTrabalho : Form
    {
        AdicionarProjeto cada;
        ExcluirProjeto exc;
        Atualizar gere;
        Tarefa tare;
        Buscar bus;
        public AreaDeTrabalho()
        {
            InitializeComponent();
            cada = new AdicionarProjeto();
            exc = new ExcluirProjeto();
            gere= new Atualizar();
            tare= new Tarefa();
            bus = new Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cada.ShowDialog();
        }//Adicionar Projeto

        private void button5_Click(object sender, EventArgs e)
        {
            gere.ShowDialog();
        }//Gerenciador Projeto

        private void button6_Click(object sender, EventArgs e)
        {
            tare.ShowDialog();
        }//Adicionar Tarefa

        private void button2_Click(object sender, EventArgs e)
        {
            bus.ShowDialog();
        }//Buscar

        private void ExcluirP_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }// Excluir Projeto

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

    }//Fim da Classe
}//Fim do Projeto

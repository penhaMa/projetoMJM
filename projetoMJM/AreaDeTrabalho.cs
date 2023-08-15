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
            cada = new AdicionarProjeto();//Conecta com a Adicionar Projeto
            exc = new ExcluirProjeto();//Conecta com a Excluir Projeto
            gere = new Atualizar();//Conecta com a Atualizar Projeto
            tare = new Tarefa();//Conecta com a Adicionar Tarefa
            bus = new Buscar();//Conecta com a Buscar
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

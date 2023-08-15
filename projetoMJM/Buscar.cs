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
    public partial class Buscar : Form
    {
        DAO consul;
        TelaTarefa tar;
        public Buscar()
        {
            consul = new DAO();
            InitializeComponent();//Instancia os componentes
            ConfigurarDataGrid();//Configura o DataGrid
            NomeColunas();//Nomear os títulos das colunas  
            tar = new TelaTarefa();//Conecta com a tela de tarefas
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Nome";//Adiciona um nome a coluna 0
            dataGridView1.Columns[1].Name = "Tipo";//Adiciona um nome a coluna 1
            dataGridView1.Columns[2].Name = "Descrição";//Adiciona um nome a coluna 2
            dataGridView1.Columns[3].Name = "Orçamento";//Adiciona um nome a coluna 3
            dataGridView1.Columns[4].Name = "Status";//Adiciona um nome a coluna 4
            dataGridView1.Columns[5].Name = "Prazo";//Adiciona um nome a coluna 5
            dataGridView1.Columns[6].Name = "Integrante";//Adiciona um nome a coluna 6

        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 7;//Número de Colunas
        }

        public void AdicionarDados()
        {
            consul.PreencherVetor(Convert.ToInt32(codigo.Text), "projeto");
            for (int i = 0; i < consul.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.nome[i], consul.tipo[i], consul.descricao[i], consul.orcamento[i], consul.statu[i], consul.prazoProjeto[i], consul.integrante[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método

        private void button2_Click(object sender, EventArgs e)
        {

        }//Voltar para a Área de trabalho

        private void label2_Click(object sender, EventArgs e)
        {

        }//Label

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//DataGrid

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }//Buscar

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Código

        private void tarefa_Click(object sender, EventArgs e)
        {
            tar.ShowDialog();
        }//Tela de Tarefa

    }//Fim da Classe
}//Fim do Projeto

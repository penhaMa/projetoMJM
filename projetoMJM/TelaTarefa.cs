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
    public partial class TelaTarefa : Form
    {
        DAO consul;
        AtualizarTarefa atu;
        public TelaTarefa()
        {
            consul = new DAO();//Conecta com a DAO
            InitializeComponent();//Instanciar os Componentes
            ConfigurarDataGrid();//Configura o DataGrid
            NomeColunas();//Nomear os títulos das colunas  
            atu = new AtualizarTarefa();
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Nome Projeto";//Adiciona um nome a coluna 0
            dataGridView1.Columns[1].Name = "Integrante";//Adiciona um nome a coluna 1
            dataGridView1.Columns[2].Name = "Tarefa";//Adiciona um nome a coluna 2
            dataGridView1.Columns[3].Name = "Status";//Adiciona um nome a coluna 3
            dataGridView1.Columns[4].Name = "Prazo";//Adiciona um nome a coluna 4

        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 5;//Quantidade de Colunas
        }

        public void AdicionarDados()
        {
            consul.PreencherTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa");
            for (int i = 0; i < consul.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.nomeProjeto[i],consul.integrante1[i], consul.tarefa[i], consul.stat[i], consul.prazo[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método
        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Codigo

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//DataGrid

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }//Buscar

        private void button2_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Atualizar Tarefa

    }//Fim da Classe
}//Fim do Projeto

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
        public Buscar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//Nomear os títulos das colunas  
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Tipo";
            dataGridView1.Columns[2].Name = "Descrição";
            dataGridView1.Columns[3].Name = "Orçamento";
            dataGridView1.Columns[4].Name = "Status";
            dataGridView1.Columns[5].Name = "Integrante";
        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 6;
        }

        public void AdicionarDados()
        {
            consul.PreencherVetor(Convert.ToInt32(codigo.Text), "projeto");
            for (int i = 0; i < consul.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.nome[i], consul.tipo[i], consul.descricao[i], consul.orcamento[i], consul.statu[i], consul.integrante[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método

        private void button2_Click(object sender, EventArgs e)
        {

        }//Voltar para a Área de trabalho

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }//Buscar

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Código

    }//Fim da Classe
}//Fim do Projeto

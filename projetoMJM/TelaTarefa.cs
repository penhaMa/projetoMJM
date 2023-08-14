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
        public TelaTarefa()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//Nomear os títulos das colunas  
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Integrante";
            dataGridView1.Columns[1].Name = "Tarefa";
            dataGridView1.Columns[2].Name = "Status";
            dataGridView1.Columns[3].Name = "Prazo";

        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 4;
        }

        public void AdicionarDados()
        {
            consul.PreencherTarefa(Convert.ToInt32(codigo.Text), "bancoTarefa");
            for (int i = 0; i < consul.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.integrante1[i], consul.tarefa[i], consul.stat[i], consul.prazo[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método
        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }//Buscar
    }
}

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
    public partial class ExcluirTarefa : Form
    {
        DAO conec;
        public ExcluirTarefa()
        {
            InitializeComponent();
            conec = new DAO();
        }

        private void codigoTarefa_TextChanged(object sender, EventArgs e)
        {
            
        }//Codigo Tarefa

        private void button1_Click(object sender, EventArgs e)
        {
            string result = conec.ExcluirTarefa(Convert.ToInt32(codigoTarefa.Text), "bancoTarefa");
            MessageBox.Show(result);
        }//Excluir

    }//Fim da Classe    
}//Fim do Projeto

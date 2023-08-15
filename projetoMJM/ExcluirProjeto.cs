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
    public partial class ExcluirProjeto : Form
    {
        DAO exc;
        
        public ExcluirProjeto()
        {
            InitializeComponent();
            exc = new DAO();//Conecta com a DAO
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt32(codigo.Text), "projeto");
            MessageBox.Show(result);
        }//Excluir

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Codigo

    }//Fim da Classe
}//Fim do Projeto

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoMJM
{
    public partial class Cadastrar : Form
    {
        DAO conectar;
        
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.Cadastrar(login.Text, senha.Text, "entrar"); ;
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch

        }//Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }// Sair

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }//Fim da Classe
}//Fim do Projeto

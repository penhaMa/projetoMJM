using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoMJM
{
    public partial class Login : Form
    {
        Cadastrar cad;
        DAO conectar;
        AreaDeTrabalho areaL;
        public Login()
        {
            InitializeComponent();
            areaL = new AreaDeTrabalho();
            conectar = new DAO();
            cad = new Cadastrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conectar.Acessar(login1.Text, senha1.Text, "entrar");
            for (int i = 0; i < conectar.QuatidadeDados(); i++)
            {
                if (login1.Text == conectar.login[i] & senha1.Text == conectar.senha[i])
                {
                    MessageBox.Show("Login Bem sucedido");
                    areaL.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos");
                }
            }
        }//Entrar

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

        private void login1_TextChanged(object sender, EventArgs e)
        {

        }//Login

        private void senha1_TextChanged(object sender, EventArgs e)
        {

        }//Senha

        private void cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//Cadastrar

    }//Fim da Classe
}//Fim do projeto

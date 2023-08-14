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

namespace projetoMJM
{
    public partial class Login : Form
    {
        DAO conectar;
        AreaDeTrabalho areaL;
        public Login()
        {
            InitializeComponent();
            areaL = new AreaDeTrabalho();
            conectar = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                conectar.Acessar(login1.Text, senha1.Text, "projeto");
                for (int i = 0; i < conectar.QuatidadeDados(); i++)
                {
                    if(conectar.login[i] == login1.Text || conectar.senha[i] == senha1.Text);
                    {
                        MessageBox.Show("Login Bem sucedido");
                    }

                }//Adicionando dados no dataGridView1
            }
            catch (Exception erro)
            {
                MessageBox.Show("Login ou senha incorretos!\n\n" + erro.Message);
            }//Fim do try catch
        

            areaL.ShowDialog();
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

    }//Fim da Classe
}//Fim do projeto

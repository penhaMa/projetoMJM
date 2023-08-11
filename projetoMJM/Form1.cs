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
    public partial class Form1 : Form
    {
        DAO conectar;
        Login log;
        public Form1()
        {
            InitializeComponent();
            log= new Login();
            conectar =new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
        }//Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }// Sair

    }//Fim da Classe
}//Fim do Projeto

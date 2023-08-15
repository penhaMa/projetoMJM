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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();//Conecta com a DAO
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void tipo_TextChanged(object sender, EventArgs e)
        {

        }//Tipo

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }//Descrição

        private void orcamento_TextChanged(object sender, EventArgs e)
        {

        }//Orçamento

        private void status_TextChanged(object sender, EventArgs e)
        {

        }//Status

        private void integrante_TextChanged(object sender, EventArgs e)
        {

        }//Integrante

        private void button3_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "nome", nome.Text);//Atualiza o nome
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "tipo", tipo.Text);//Atualiza o tipo
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "descricao", descricao.Text);//Atualiza a descrição
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "orcamento", orcamento.Text);//Atualiza o orçamento
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "statu", status.Text);//Atualiza o status
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "prazo", prazo.Text);//Atualiza o prazo
            atu.Atualizar(Convert.ToInt32(codigo.Text), "projeto", "integrante", integrante.Text);//Atualiza o integrante
            MessageBox.Show("Dados Atualizados com Sucesso!");//Mensagem para o úsuario 
        }//Atualizar

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }//Código

        private void prazo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Prazo

    }//Fim da Classe
}//Fim do Projeto

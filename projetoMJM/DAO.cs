using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoMJM
{
    class DAO
    {
        public MySqlConnection conexao;//Conexao com o banco de dados
        public string[] nome;//Vetor que guarda o nome
        public string[] tipo;//Vetor que guarda o tipo
        public string[] descricao;//Vetor que guarda a descrição
        public double[] orcamento;//Vetor que guarda o orçamento
        public string[] statu;//Vetor que guarda o status
        public string[] integrante;//Vetor que guarda o integrante
        public string[] login;//Vetor que guarda o login
        public string[] senha;//Vetor que guarda o senha
        public string[] tarefa;//Vetor que guarda a tarefa
        public string[] integrante1;//Vetor que guarda o integrante1 
        public string[] stat;//Vetor que guarda o status1
        public string[] prazo;//Vetor que guarda o prazo
        public int i;//Variavel do Vetor
        public int contador;//Contador do i

        public DAO() 
        {
            conexao  = new MySqlConnection("server=localhost;database=projetomjm;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
                MessageBox.Show("Conectado");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do construtor
        }//Fim da DAO

        //Métodos de inserção
        public string Inserir(int codigo, string nome, string tipo, string descricao, double orcamento, string statu, string integrante,string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(codigo, nome, tipo, descricao, orcamento, statu, integrante) values('{codigo}','{nome}','{tipo}','{descricao}','{orcamento}','{statu}','{integrante}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim da inserir

        //Método de Busca
        public void PreencherVetor(int codigo, string nomeTabela)
        {
            string query = $"Select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.nome = new string[100];
            this.tipo = new string[100];
            this.descricao = new string[100];
            this.orcamento = new double[100];
            this.statu = new string[100];
            this.integrante = new string[100];
           

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                nome[i] = leitura["nome"] + "";//Mostra o dado que deseja pegar
                tipo[i] = leitura["tipo"] + "";//Mostra o dado que deseja pegar
                descricao[i] = leitura["descricao"] + "";//Mostra o dado que deseja pegar
                orcamento[i] = Convert.ToDouble(leitura["orcamento"]);//Mostra o dado que deseja pegar
                statu[i] = leitura["statu"] + "";//Mostra o dado que deseja pegar
                integrante[i] = leitura["integrante"] + "";//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicaxão
            leitura.Close();
        }//Fim do método

        public int QuatidadeDados()
        {
            return contador;
        }//Fim do método Quantidade de Dados

        public string Excluir(int codigo, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido";
            return resultado;
        }//Fim do método Excluir

        public string Atualizar(int codigo, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//fim do método Atualizar

        public string Cadastrar(string login, string senha, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(login, senha) values('{login}','{senha}')";
            MySqlCommand sql = new MySqlCommand(cadastrar, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim do método Cadastrar

        public void Acessar(string verificaLogin, string verificaSenha, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where login = '{verificaLogin}' and senha = '{verificaSenha}'";
            //Acessa os dados do banco de dados

            //Instanciar
            this.login = new string[100];
            this.senha = new string[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(acessar, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();
            

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                login[i] = leitura["login"] + "";//Mostra o dado que deseja pegar
                senha[i] = leitura["senha"] + "";//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }

        public string CadastrarTarefa(string codigo, string integrante, string tarefa ,string stat, DateTime prazo, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(codigo, integrante, tarefa, stat, prazo) values('{codigo}','{integrante}','{tarefa}','{stat}','{prazo}')";
            MySqlCommand sql = new MySqlCommand(cadastrar, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
            //Método cadastrar tarefa 
        }

        //Método de Busca
        public void PreencherTarefa(int codigo, string nomeTabela)
        {
            string query = $"Select * from {nomeTabela} where codigo = '{codigo}'";

            //Instanciar
            this.integrante1 = new string[100];
            this.tarefa = new string[100];
            this.stat = new string[100];
            this.prazo = new string [100];


            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                integrante1[i] = leitura["integrante"] + "";//Mostra o dado que deseja pegar
                tarefa[i] = leitura["tarefa"] + "";//Mostra o dado que deseja pegar
                stat[i] = leitura["stat"] + "";//Mostra o dado que deseja pegar
                prazo[i] = leitura["prazo"] + "";//Mostra o dado que deseja pegar
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicaxão
            leitura.Close();
        }//Fim do método Preencher Tarefa

    }//Fim de Classe
}//Fim do Projeto

﻿using System;
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
        public MySqlConnection conexao;
        public string[] nome;
        public string[] tipo;
        public string[] descricao;
        public double[] orcamento;
        public string[] statu;
        public string[] integrante;
        public string[] login;
        public string[] senha;
        public int i;
        public int contador;

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

        //Método de Consulta
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
                nome[i] = leitura["nome"] + "";
                tipo[i] = leitura["tipo"] + "";
                descricao[i] = leitura["descricao"] + "";
                orcamento[i] = Convert.ToDouble(leitura["orcamento"]);
                statu[i] = leitura["statu"] + "";
                integrante[i] = leitura["integrante"] + "";
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicaxão
            leitura.Close();
        }//Fim do método

        public int QuatidadeDados()
        {
            return contador;
        }//Fim do método

        public string Excluir(int codigo, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido";
            return resultado;
        }//Fim do método

        public string Atualizar(int codigo, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//fim do método

        public string Cadastrar(string login, string senha, string nomeTabela)
        {
            string cadastrar = $"Insert into {nomeTabela}(login, senha) values('{login}','{senha}')";
            MySqlCommand sql = new MySqlCommand(cadastrar, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }

        public void Acessar(string verificaLogin, string verificaSenha, string nomeTabela)
        {
            string acessar = $"select * from {nomeTabela} where login = '{verificaLogin}' and senha = '{verificaSenha}'";

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
                login[i] = leitura["login"] + "";
                senha[i] = leitura["senha"] + "";
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicasão
            leitura.Close();
        }
        

    }//Fim de Classe
}//Fim do Projeto

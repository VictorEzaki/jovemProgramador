using Model;
using MySqlConnector;

namespace Repository
{
    public class PessoaList
    {
        private static MySqlConnection conexao;
        public static List<Pessoa> pessoas = [];

        public static void InitConexao()
        {
            string info = "server=localhost;database=projetointegradoexemp; user id=root;password=''";
            conexao = new MySqlConnection(info);

            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível se conectar com o banco");
            }
        }

        public static void CloseConexao()
        {
            conexao.Close();
        }

        public static void Sincronizar()
        {
            InitConexao();

            string query = "SELECT * FROM pessoas";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32(reader["id"].ToString());
                pessoa.Nome = reader["nome"].ToString();
                pessoa.Cpf = reader["cpf"].ToString();
                pessoa.Idade = Convert.ToInt32(reader["Idade"].ToString());
                pessoas.Add(pessoa);
            }

            CloseConexao();
        }

        public static void Cadastrar(Pessoa pessoa)
        {
            InitConexao();
            string insert = "INSERT INTO pessoas (nome, idade, cpf) VALUES (@Nome, @Idade, @Cpf)";
            MySqlCommand command = new MySqlCommand(insert, conexao);
            try
            {
                if (pessoa.Nome == null || pessoa.Idade < 0 || pessoa.Cpf == null)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    command.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    command.Parameters.AddWithValue("@Idade", pessoa.Idade);
                    command.Parameters.AddWithValue("@Cpf", pessoa.Cpf);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        pessoa.Id = Convert.ToInt32(command.LastInsertedId);
                        MessageBox.Show("Pessoa cadastrada com sucesso");
                        pessoas.Add(pessoa);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu ruim: " + e.Message);
            }

            CloseConexao();
        }

        public static void Alterar(string nome, string cpf, int idade, int indice)
        {
            InitConexao();
            MessageBox.Show("iniciando");
            string alterar = "UPDATE pessoas SET nome = @Nome, idade = @Idade, cpf = @Cpf WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(alterar, conexao);
            Pessoa pessoa = pessoas[indice];
            try
            {
                if (nome != null || idade > 0 || cpf != null)
                {
                    command.Parameters.AddWithValue("@Id", pessoa.Id);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Cpf", cpf);
                    command.Parameters.AddWithValue("@Idade", idade);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        pessoa.Nome = nome;
                        pessoa.Idade = idade;
                        pessoa.Cpf = cpf;
                    }
                    else
                    {
                        MessageBox.Show(rowsAffected.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a execução do comando: " + ex.Message);
            }
            CloseConexao();
        }

        public static void Delete(int indice)
        {
            InitConexao();

            string delete = "DELETE FROM pessoas WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", pessoas[indice].Id);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                pessoas.RemoveAt(indice);
                MessageBox.Show("Pessoa deletada com sucesso");
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada");
            }

            CloseConexao();
        }
    }
}
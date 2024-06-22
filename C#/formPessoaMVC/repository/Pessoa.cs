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

        public static void Cadastrar()
        {

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
                MessageBox.Show("Deletado pessoa com sucesso");
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada");
            }
            CloseConexao();
        }
    }
}
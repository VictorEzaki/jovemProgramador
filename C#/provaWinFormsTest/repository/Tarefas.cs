using Model;
using MySqlConnector;

namespace ListTarefas
{
    public class ListaTarefas
    {
        private static MySqlConnection conexao;
        public static List<Tarefas> tarefas = [];

        public static void InitConexao()
        {
            string info = "server=localhost;database=tarefas; user id=root;password=''";
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
            string query = "SELECT * FROM tarefas";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())  
            {
                Tarefas tarefa = new Tarefas();
                tarefa.IdTarefas = Convert.ToInt32(reader["IdTarefas"].ToString());
                tarefa.Nome = reader["NomeTarefa"].ToString();
                tarefa.Data = reader["Data"].ToString();
                tarefa.Hora = reader["Hora"].ToString();
                tarefa.Situacao = Convert.ToBoolean(reader["Situacao"].ToString());
                tarefas.Add(tarefa);

            }
            CloseConexao();
        }

        public static void Cadastrar(Tarefas tarefa)
        {
            InitConexao();

            string insert = "INSERT INTO tarefas(nomeTarefa, data, hora, situacao) VALUES(@NomeTarefa, @Data, @Hora, @Situacao)";
            MySqlCommand command = new MySqlCommand(insert, conexao);
            try
            {
                if (tarefa.Nome == null || tarefa.Data == null || tarefa.Hora == null)
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    command.Parameters.AddWithValue("@NomeTarefa", tarefa.Nome);
                    command.Parameters.AddWithValue("@Data", tarefa.Data);
                    command.Parameters.AddWithValue("@Hora", tarefa.Hora);
                    command.Parameters.AddWithValue("@Situacao", tarefa.Situacao);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        tarefa.IdTarefas = Convert.ToInt32(command.LastInsertedId);
                        MessageBox.Show("Tarefa Cadastrada com sucesso!");
                        tarefas.Add(tarefa);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar a tarefa");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu ruim: " + e.Message);
            }

            CloseConexao();
        }

        public static void AlterarTarefa(string nome, string data, string hora, int indice)
        {
            InitConexao();
            MessageBox.Show("iniciando");
            string alterar = "UPDATE tarefas SET nomeTarefa = @Nome, hora = @Hora, data = @Data WHERE idTarefas = @IdTarefas";
            MySqlCommand command = new MySqlCommand(alterar, conexao);
            Tarefas tarefa = tarefas[indice];
            try
            {
                if (nome != null || hora != null || data != null)
                {
                    command.Parameters.AddWithValue("@IdTarefas", tarefa.IdTarefas);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Data", data);
                    command.Parameters.AddWithValue("@Hora", hora);
                    command.Parameters.AddWithValue("@Situacao", tarefa.Situacao);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        tarefa.Nome = nome;
                        tarefa.Hora = hora;
                        tarefa.Data = data;
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

            string delete = "DELETE FROM tarefas WHERE idTarefas = @IdTarefas";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@IdTarefas", tarefas[indice].IdTarefas);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                tarefas.RemoveAt(indice);
                MessageBox.Show("Tarefa deletada com sucesso");
            }
            else
            {
                MessageBox.Show("Tarefa não encontrada");
            }

            CloseConexao();
        }
    }
}
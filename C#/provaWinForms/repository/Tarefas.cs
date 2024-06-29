using Model;
using MySqlConnector;

namespace Repo
{
    public class ListaTarefas
    {
        private static MySqlConnection conexao;
        public static List<Tarefas> tarefas = [];

        public static List<Tarefas> ListarTarefas()
        {
            return tarefas;
        }
        public static void InitConexao()
        {
            string info = "server=localhost;database=provawinforms; user id=root;password=''";
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

        public static List<Tarefas> Sincronizar()
        {
            InitConexao();

            string query = "SELECT * FROM tarefas";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Tarefas tarefa = new Tarefas();

                tarefa.Id = Convert.ToInt32(reader["id"].ToString());
                tarefa.Tarefa = reader["tarefa"].ToString();
                tarefa.Data = reader["data"].ToString();
                tarefa.Hora = reader["hora"].ToString();
                tarefa.Situacao = reader["situacao"].ToString();
                tarefas.Add(tarefa);
            }

            CloseConexao();

            return tarefas;
        }

        public static void Cadastrar(Tarefas tarefa)
        {
            InitConexao();

            string insert = "INSERT INTO tarefas(tarefa, data, hora, situacao) VALUES(@Tarefa, @Data, @Hora, @Situacao)";
            MySqlCommand command = new MySqlCommand(insert, conexao);

            try
            {
                if (tarefa.Tarefa == null || tarefa.Data == null || tarefa.Hora == null)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    command.Parameters.AddWithValue("@Tarefa", tarefa.Tarefa);
                    command.Parameters.AddWithValue("@Data", tarefa.Data);
                    command.Parameters.AddWithValue("@Hora", tarefa.Hora);
                    command.Parameters.AddWithValue("@Situacao", tarefa.Situacao);

                    int rowsAffected = command.ExecuteNonQuery();
                    tarefa.Id = Convert.ToInt32(command.LastInsertedId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tarefa cadastrada com sucesso!");
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
                MessageBox.Show(e.Message);
            }

            CloseConexao();
        }

        public static void Alterar(string tarefa, string data, string hora, int indice)
        {
            InitConexao();

            string update = "UPDATE tarefas SET tarefa = @Tarefa, data = @Data, hora = @Hora WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            Tarefas task = tarefas[indice];

            try
            {
                if (tarefa == null || data == null || hora == null)
                {
                    MessageBox.Show("Tarefa não encontrada");
                }
                else
                {
                    command.Parameters.AddWithValue("@Id", task.Id);
                    command.Parameters.AddWithValue("@Tarefa", tarefa);
                    command.Parameters.AddWithValue("@Data", data);
                    command.Parameters.AddWithValue("@Hora", hora);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        task.Tarefa = tarefa;
                        task.Data = data;
                        task.Hora = hora;
                    }
                    else
                    {
                        MessageBox.Show(rowsAffected.ToString());
                    }
                    MessageBox.Show("Tarefa alterada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CloseConexao();
        }

        public static void Delete(int indice)
        {
            InitConexao();

            string delete = "DELETE FROM tarefas WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", tarefas[indice].Id);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                tarefas.RemoveAt(indice);
                MessageBox.Show("Tarefa deletada com sucesso!");
            }
            else
            {
                MessageBox.Show("Tarefa não encontrada");
            }

            CloseConexao();
        }

        public static void AlterarStatus(int indice, string situacao)
        {
            InitConexao();

            string update = "UPDATE tarefas SET situacao = @Situacao WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            Tarefas tarefa = tarefas[indice];

            try
            {
                command.Parameters.AddWithValue("@Id", tarefa.Id);
                command.Parameters.AddWithValue("@Situacao", situacao);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    tarefa.Situacao = situacao;
                    MessageBox.Show("Status alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível aterar o status da tarefa");
                }
            }
            catch
            {
                MessageBox.Show("Deu ruim");
            }

            CloseConexao();
        }
    }
}
using Controller;
using Model;
namespace Views
{
    public class PessoaView : Form
    {
        private readonly Label LblNome;
        private readonly Label LblCpf;
        private readonly Label LblIdade;
        private readonly TextBox InpNome;
        private readonly TextBox InpCpf;
        private readonly TextBox InpIdade;
        private readonly Button BtnCadastrar;
        private readonly Button BtnAlterar;
        private readonly Button BtnListar;
        private readonly Button BtnDeletar;
        private readonly DataGridView DGV;

        public PessoaView()
        {
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;

            LblNome = new Label
            {
                Text = "Nome: ",
                Size = new Size(50, 20),
                Location = new Point((this.ClientSize.Width / 2) - 100, 50),
            };

            InpNome = new TextBox
            {
                Name = "Nome",
                Size = new Size (150, 20),
                Location = new Point((this.ClientSize.Width / 2) - 50, 50)
            };

            LblIdade = new Label
            {
                Text = "Idade: ",
                Size = new Size(50, 20),
                Location = new Point((this.ClientSize.Width / 2) - 100, 100),
            };
            

            InpIdade = new TextBox
            {
                Name = "Idade",
                Size = new Size (150, 20),
                Location = new Point((this.ClientSize.Width / 2) - 50, 100)
            };
            
            LblCpf = new Label
            {
                Text = "Cpf: ",
                Size = new Size(50, 20),
                Location = new Point((this.ClientSize.Width / 2) - 100, 150),
            };
            
            InpCpf = new TextBox
            {
                Name = "Cpf",
                Size = new Size (150, 20),
                Location = new Point((this.ClientSize.Width / 2) - 50, 150)
            };

            BtnDeletar = new Button
            {
                Text = "Deletar",
                Size = new Size (80, 20),
                Location = new Point((this.ClientSize.Width / 2) - 180, 200)
            };
            BtnDeletar.Click += ClickDeletar;

            BtnAlterar = new Button
            {
                Text = "Alterar",
                Size = new Size (80, 20),
                Location = new Point((this.ClientSize.Width / 2) - 80, 200)
            };
            
            BtnAlterar.Click += ClickAlterar;
            
            BtnListar = new Button
            {
                Text = "Listar",
                Size = new Size (80, 20),
                Location = new Point((this.ClientSize.Width / 2) + 20, 200)
            };
            
            BtnListar.Click += ClickListar;
            
            BtnCadastrar = new Button
            {
                Text = "Cadastrar",
                Size = new Size (80, 20),
                Location = new Point((this.ClientSize.Width / 2) + 120, 200)
            };
            BtnCadastrar.Click += ClickCadastrar;

            Controls.Add(LblNome);
            Controls.Add(LblCpf);
            Controls.Add(LblIdade);
            Controls.Add(InpIdade);
            Controls.Add(InpNome);
            Controls.Add(InpCpf);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnListar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnDeletar);
            Controls.Add(DGV);
        }  

        private void Listar()
        {
            List<Pessoa> pessoas = ControllerPessoa.ListarPessoa();
            DGV.Columns.Clear();

            DGV.AutoGenerateColumns = false;
            DGV.DataSource = pessoas;

            // Adiciona colunas ao DataGridView
            DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });

            DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Idade",
                HeaderText = "Idade"
            });

            DGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "Cpf"
            });
        }

        private void ClickCadastrar(object? sender, EventArgs e)
        {
            if (InpNome.Text.Length < 1 && InpIdade.Text == "" && InpCpf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }

            ControllerPessoa.Cadastrar(InpNome.Text, InpIdade.Text, InpCpf.Text);
            Listar();
        }

        private void ClickListar(object? sender, EventArgs e)
        {
            Listar();
        }

        private void ClickDeletar(object? sender, EventArgs e)
        {

        }

        private void ClickAlterar(object? sender, EventArgs e)
        {

        }
    }
}
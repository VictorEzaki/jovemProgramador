using Controller;
using Model;

namespace Views;

public class PessoaView : Form
{
    private readonly Label LblNome;
    private readonly Label LblIdade;
    private readonly Label LblCpf;
    private readonly TextBox InpNome;
    private readonly TextBox InpIdade;
    private readonly TextBox InpCpf;
    private readonly Button BtnCadastrar;
    private readonly Button BtnAlterar;

    private readonly Button BtnDeletar;
    private readonly DataGridView DGVList;
    public PessoaView()
    {
        PessoaController.Sincronizar();
        Size = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;

        LblNome = new Label
        {
            Text = "Nome: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 50)
        };

        LblCpf = new Label
        {
            Text = "Cpf: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 100)
        };

        LblIdade = new Label
        {
            Text = "Idade: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 150)
        };

        InpNome = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 50)
        };

        InpCpf = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 100)
        };

        InpIdade = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 150)
        };

        BtnCadastrar = new Button
        {
            Text = "Cadastrar",
            Size = new Size(80, 20),
            Location = new Point((this.ClientSize.Width / 2) - 150, 200)
        };
        BtnCadastrar.Click += ClickCadastrar;

        BtnAlterar = new Button
        {
            Text = "Alterar",
            Size = new Size(80, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 200)
        };
        BtnAlterar.Click += ClickAlterar;

        BtnDeletar = new Button
        {
            Text = "Deletar",
            Size = new Size(80, 20),
            Location = new Point((this.ClientSize.Width / 2) + 50, 200)
        };
        BtnDeletar.Click += ClickDeletar;

        DGVList = new DataGridView
        {
            Size = new Size(800, 350),
            Location = new Point(0, 250),
        };

        Controls.Add(LblNome);
        Controls.Add(LblCpf);
        Controls.Add(LblIdade);
        Controls.Add(InpNome);
        Controls.Add(InpCpf);
        Controls.Add(InpIdade);
        Controls.Add(BtnCadastrar);
        Controls.Add(BtnAlterar);
        Controls.Add(BtnDeletar);
        Controls.Add(DGVList);
        Listar();
    }

    private void Listar()
    {
        List<Pessoa> pessoas = PessoaController.ListarPessoa();

        DGVList.Columns.Clear();
        DGVList.AutoGenerateColumns = false;
        DGVList.DataSource = pessoas;



        DGVList.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Id",
            DataPropertyName = "Id"
        });

        DGVList.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Nome",
            DataPropertyName = "Nome"
        });

        DGVList.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Cpf",
            DataPropertyName = "Cpf"
        });

        DGVList.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Idade",
            DataPropertyName = "Idade"
        });

        foreach (DataGridViewColumn column in DGVList.Columns)
        {
            if (column.DataPropertyName == "Id")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Nome")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Cpf")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Idade")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

    private void ClickCadastrar(object? sender, EventArgs e)
    {
        if (InpNome.Text.Length < 1 || InpCpf.Text.Length < 1 || InpIdade.Text.Length < 1)
        {
            MessageBox.Show("Preencha todos os campos!");
        }
        else
        {
            PessoaController.CriarPessoa(InpNome.Text, InpCpf.Text, InpIdade.Text);
            InpNome.Text = "";
            InpCpf.Text = "";
            InpIdade.Text = "";
        }

        Listar();
    }

    private void ClickAlterar(object? sender, EventArgs e)
    {
        int indice = DGVList.SelectedRows[0].Index;

        PessoaController.AlterarPessoa(InpNome.Text, InpCpf.Text, InpIdade.Text, indice);
        InpNome.Text = "";
        InpCpf.Text = "";
        InpIdade.Text = "";

        Listar();
    }

    private void ClickDeletar(object? sender, EventArgs e)
    {
        int indice = DGVList.SelectedRows[0].Index;

        PessoaController.DeletarPessoa(indice);

        Listar();
    }
}

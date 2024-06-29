using Controller;
using Model;

namespace Views;

public class TarefasView : Form
{
    private readonly Label LblNome;
    private readonly Label LblData;
    private readonly Label LblHora;
    private readonly TextBox InpNome;
    private readonly TextBox InpData;
    private readonly TextBox InpHora;
    private readonly Button BtnCadastrar;
    private readonly Button BtnAlterar;
    private readonly Button BtnDeletar;
    private readonly DataGridView DGVTarefas;

    public TarefasView()
    {
        ControllerTarefas.Sincronizar();
        Size = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;

        LblNome = new Label
        {
            Text = "Nome: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 50)
        };

        LblData = new Label
        {
            Text = "Data: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 100)
        };

        LblHora = new Label
        {
            Text = "Hora: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 100, 150)
        };

        InpNome = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 50)
        };

        InpData = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 50, 100)
        };

        InpHora = new TextBox
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

        DGVTarefas = new DataGridView
        {
            Size = new Size(800, 350),
            Location = new Point(0, 250),
        };

        Controls.Add(LblNome);
        Controls.Add(LblData);
        Controls.Add(LblHora);
        Controls.Add(InpNome);
        Controls.Add(InpData);
        Controls.Add(InpHora);
        Controls.Add(BtnCadastrar);
        Controls.Add(BtnAlterar);
        Controls.Add(BtnDeletar);
        Controls.Add(DGVTarefas);
        Listar();
    }

    private void Listar()
    {
        List<Tarefas> Tarefas = ControllerTarefas.ListarTarefas();

        DGVTarefas.Columns.Clear();
        DGVTarefas.AutoGenerateColumns = false;
        DGVTarefas.DataSource = Tarefas;



        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "IdTarefa",
            DataPropertyName = "idTarefa"
        });

        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Nome Tarefa",
            DataPropertyName = "nomeTarefa"
        });

        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Data",
            DataPropertyName = "Data"
        });

        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Hora",
            DataPropertyName = "Hora"
        });

        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Situacao",
            DataPropertyName = "Situacao"
        });

        foreach (DataGridViewColumn column in DGVTarefas.Columns)
        {
            if (column.DataPropertyName == "idTarefas")
                column.Width = 100;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "nomeTarefa")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Data")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Hora")
                column.Width = 100;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Situacao")
                column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

    private void ClickCadastrar(object? sender, EventArgs e)
    {
        if (InpNome.Text.Length < 1 || InpData.Text.Length < 1 || InpHora.Text.Length < 1)
        {
            MessageBox.Show("Preencha todos os campos!");
        }
        else
        {
            bool situacao = false;
            ControllerTarefas.Cadastrar(InpNome.Text, InpData.Text, InpHora.Text, situacao);
            InpNome.Text = "";
            InpData.Text = "";
            InpHora.Text = "";
        }

        Listar();
    }

    private void ClickAlterar(object? sender, EventArgs e)
    {
        int indice = DGVTarefas.SelectedRows[0].Index;

        ControllerTarefas.AlterarTarefa(InpNome.Text, InpData.Text, InpHora.Text, indice);
        InpNome.Text = "";
        InpData.Text = "";
        InpHora.Text = "";

        Listar();
    }

    private void ClickDeletar(object? sender, EventArgs e)
    {
        int indice = DGVTarefas.SelectedRows[0].Index;

        ControllerTarefas.DeletarTarefa(indice);

        Listar();
    }
}

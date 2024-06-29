using Controller;
using Model;

namespace Views;

public class ViewTarefas : Form
{
    private readonly Label LblTarefa;
    private readonly Label LblData;
    private readonly Label LblHora;
    private readonly TextBox InpTarefa;
    private readonly TextBox InpData;
    private readonly TextBox InpHora;
    private readonly Button BtnCadastrar;
    private readonly Button BtnAlterar;
    private readonly Button BtnDeletar;
    private readonly Button BtnStatus;
    private readonly DataGridView DGVTarefas;

    public ViewTarefas()
    {
        ControllerTarefas.Sincronizar();
        Size = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;

        LblTarefa = new Label
        {
            Text = "Tarefa: ",
            Size = new Size(50, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 50)
        };

        LblData = new Label
        {
            Text = "Data: (yyyy-mm-dd)",
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 100)
        };

        LblHora = new Label
        {
            Text = "Hora: (hh:mm)",
            Size = new Size(100, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 150)
        };

        InpTarefa = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 70)
        };

        InpData = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 120)
        };

        InpHora = new TextBox
        {
            Size = new Size(150, 20),
            Location = new Point((this.ClientSize.Width / 2) - 75, 170)
        };

        BtnCadastrar = new Button
        {
            Text = "Cadastrar",
            Size = new Size(80, 20),
            Location = new Point((this.ClientSize.Width / 2) + 50, 200)
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
            Location = new Point((this.ClientSize.Width / 2) - 150, 200)
        };
        BtnDeletar.Click += ClickDeletar;

        BtnStatus = new Button
        {
            Text = "Alterar Status",
            Size = new Size(100, 20),
            Location = new Point(this.ClientSize.Width - 105, 225)
        };
        BtnStatus.Click += ClickStatus;

        DGVTarefas = new DataGridView
        {
            Size = new Size(800, 350),
            Location = new Point(0, 250),
        };

        Controls.Add(LblTarefa);
        Controls.Add(LblData);
        Controls.Add(LblHora);
        Controls.Add(InpTarefa);
        Controls.Add(InpData);
        Controls.Add(InpHora);
        Controls.Add(BtnCadastrar);
        Controls.Add(BtnAlterar);
        Controls.Add(BtnDeletar);
        Controls.Add(BtnStatus);
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
            HeaderText = "Id",
            DataPropertyName = "Id"
        });

        DGVTarefas.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Tarefa",
            DataPropertyName = "Tarefa"
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
            HeaderText = "Status",
            DataPropertyName = "Situacao"
        });

        foreach (DataGridViewColumn column in DGVTarefas.Columns)
        {
            if (column.DataPropertyName == "Id")
                column.Width = 100;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (column.DataPropertyName == "Tarefa")
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
        if (InpTarefa.Text == "" || InpData.Text == "" || InpHora.Text == "")
        {
            MessageBox.Show("Preencha todos os campos!");
        }
        else
        {
            bool situacao = false;
            ControllerTarefas.Cadastrar(InpTarefa.Text, InpData.Text, InpHora.Text, situacao);
            InpTarefa.Text = "";
            InpData.Text = "";
            InpHora.Text = "";
        }

        Listar();
    }

    private void ClickAlterar(object? sender, EventArgs e)
    {
        int indice = DGVTarefas.SelectedRows[0].Index;

        if (InpTarefa.Text == "" || InpData.Text == "" || InpHora.Text == "")
        {
            MessageBox.Show("Preencha todos os campos!");
        }
        else
        {
            ControllerTarefas.AlterarTarefa(InpTarefa.Text, InpData.Text, InpHora.Text, indice);
            InpTarefa.Text = "";
            InpData.Text = "";
            InpHora.Text = "";
        }

        Listar();
    }

    private void ClickDeletar(object? sender, EventArgs e)
    {
        int indice = DGVTarefas.SelectedRows[0].Index;

        ControllerTarefas.DeletarTarefa(indice);

        Listar();
    }

    private void ClickStatus(object? sender, EventArgs e)
    {
        int indice = DGVTarefas.SelectedRows[0].Index;

        ControllerTarefas.AlterarStatus(indice);

        Listar();
    }
}

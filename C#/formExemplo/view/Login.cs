namespace view;

public class Login : Form
{
    private readonly Label LabelNome;
    private readonly Label LabelSenha;
    private readonly TextBox InputNome;
    private readonly TextBox InputSenha;
    private readonly Button ButtonLogin;
    public Login()
    {
        Size = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;

        LabelNome = new Label
        {
            Text = "Nome: ",
            Location = new Point(50, 50),
        };
        
        LabelSenha = new Label
        {
            Text = "Senha: ",
            Location = new Point(50, 200),
        };

        InputNome = new TextBox
        {
            Name = "Nome",
            Location = new Point(50, 100),  
            Size = new Size(200, 20),
        };
        
        InputSenha = new TextBox
        {
            Name = "Senha",
            Location = new Point(50, 250),    
            Size = new Size(200, 20),
        };

        ButtonLogin = new Button
        {
            Text = "Entrar",
            Location = new Point(150, 300),
        };
        ButtonLogin.Click += ClickEntrar;

        Controls.Add(LabelNome);
        Controls.Add(LabelSenha);
        Controls.Add(InputNome); // NUNCA ESQUECER DO CONTROLS
        Controls.Add(InputSenha);
        Controls.Add(ButtonLogin);
    }

    private void ClickEntrar(object? sender, EventArgs e)
    {
        if (InputNome.Text == "" || InputSenha.Text == "")
        {
            MessageBox.Show("Preencha os campos");
        }
        else
        {
            MessageBox.Show("Funcionou!");
            InputNome.Text = "";
            InputSenha.Text = "";
            new Home(this).Show();
            Hide();
        }

    }
}

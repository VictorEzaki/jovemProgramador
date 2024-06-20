using Views;

namespace formPessoa;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new PessoaView());
        
    }    
}
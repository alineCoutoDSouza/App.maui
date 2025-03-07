namespace appMaui;

public partial class MainPage  : ContentPage
{
    private readonly string[] perguntasProgramacao = {
        "Você sabe o que é um algoritmo?",
        "Você já usou Git para versionamento?",
        "Você sabe o que é um framework?",
        "Você já desenvolveu uma API?",
        "Você conhece a linguagem Python?"
    };

    private int indicePergunta = 0;

    public MainPage()
    {
        InitializeComponent();
        AtualizarPergunta();
    }

    private void AtualizarPergunta()
    {
        if (indicePergunta < perguntasProgramacao.Length)
        {
            PerguntaLabel.Text = perguntasProgramacao[indicePergunta];
            RespostaLabel.Text = "";
            indicePergunta++;
        }
        else
        {
            PerguntaLabel.Text = "🎀🐱 Fim das perguntas sobre programação! 🎀🐱";
            SimButton.IsEnabled = false;
            NaoButton.IsEnabled = false;
        }
    }

    private void OnReiniciarClicked(object sender, EventArgs e)
    {
        indicePergunta = 0; 
        SimButton.IsEnabled = true; 
        NaoButton.IsEnabled = true;
        ReiniciarBtn.IsVisible = false; 
        AtualizarPergunta(); 
    }
    private void OnSimClicked(object sender, EventArgs e)
    {
        RespostaLabel.Text = "Excelente! Continue evoluindo na programação! 💻💡";
        AtualizarPergunta();
    }

    private void OnNaoClicked(object sender, EventArgs e)
    {
        RespostaLabel.Text = "Não se preocupe, sempre há tempo para aprender! 🚀✨";
        AtualizarPergunta();
    }
    private async void OnPerguntasProgramacaoClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnNavigateToQuestionsPageClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new AboutPage());
    }
}

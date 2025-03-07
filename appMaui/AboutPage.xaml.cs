namespace appMaui;

public partial class AboutPage : ContentPage
{

    string[] perguntas = {
        "Você já programou em Python?",
        "Você já usou Git?",
        "Você conhece algoritmos e estruturas de dados?",
        "Você já desenvolveu um site responsivo?",
        "Você conhece alguma linguagem funcional?"
    };

    int indicePergunta = 0;

    public AboutPage()
    {
        InitializeComponent();
        AtualizarPergunta();
    }

    private void AtualizarPergunta()
    {
        if (indicePergunta < perguntas.Length)
        {
            PerguntaLabel.Text = perguntas[indicePergunta];
            RespostaLabel.Text = "";
            indicePergunta++;
        }
        else
        {
            PerguntaLabel.Text = "🎀🐱 Fim das perguntas! Obrigada por participar! 🎀🐱";
        }
    }

 
    private void OnSimClicked(object sender, EventArgs e)
    {
        RespostaLabel.Text = "Ótimo! Continue explorando programação! 🎓💡";
        AtualizarPergunta();
    }

    
    private void OnNaoClicked(object sender, EventArgs e)
    {
        RespostaLabel.Text = "Nunca é tarde para aprender! 🚀✨";
        AtualizarPergunta();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); 
    }
}

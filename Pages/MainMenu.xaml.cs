using RockPaperScissor;

namespace RockPaperScissor.Pages;

public partial class MainMenu : ContentPage
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void NewBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Game());
    }

    private void StatsBtnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stats());
    }

    private void QuitBtnClicked(object sender, EventArgs e)
    {
        App.Current?.Quit();
    }
}
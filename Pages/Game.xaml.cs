namespace RockPaperScissor.Pages;

public partial class Game : ContentPage
{
    private int _userScore = 0;
    private int _computerScore = 0;
    private static Random _randomChoice = new Random();
    private int _computerChoice = _randomChoice.Next(1, 4);
    private bool _userChoiceMade = true;
    public Game()
    {
        InitializeComponent();
    }

    private void Play(int userChoice)
    {
        int computerChoice = _computerChoice;

        switch (userChoice)
        {
            case 1: //rock
                if (computerChoice == 1)
                    lblResult.Text = "It's a Tie!";
                else if (computerChoice == 2)
                {
                    _computerScore++;
                    lblResult.Text = "Computer Wins!";
                }
                else if (computerChoice == 3)
                {
                    _userScore++;
                    lblResult.Text = "You Win!";
                }
                break;
            case 2: //paper
                if (computerChoice == 1)
                {
                    _userScore++;
                    lblResult.Text = "You Win!";
                }
                else if (computerChoice == 2)
                    lblResult.Text = "It's a Tie!";
                else if (computerChoice == 3)
                {
                    _computerScore++;
                    lblResult.Text = "Computer Wins!";
                }
                break;
            case 3: //scissors
                if (computerChoice == 1)
                {
                    _computerScore++;
                    lblResult.Text = "Computer Win!";
                }
                else if (computerChoice == 2)
                {
                    _userScore++;
                    lblResult.Text = "You Win!";
                }
                else if (computerChoice == 3)
                    lblResult.Text = "It's a Tie!";
                break;
        }

        lblUserScore.Text = $"Your Score: {_userScore}";
        lblCompScore.Text = $"Computer Score: {_computerScore}";

        if (_userChoiceMade)
        {
            switch (userChoice)
            {
                case 1:
                    imgUserChoice.Source = "stone.png"; // Rock
                    break;
                case 2:
                    imgUserChoice.Source = "paper.jpg"; // Paper
                    break;
                case 3:
                    imgUserChoice.Source = "scissor.jpg"; // Scissors
                    break;
            }

            switch (computerChoice)
            {
                case 1:
                    imgCompChoice.Source = "stone.png"; // Rock
                    break;
                case 2:
                    imgCompChoice.Source = "paper.jpg"; // Paper
                    break;
                case 3:
                    imgCompChoice.Source = "scissor.jpg"; // Scissors
                    break;
            }

        }
    }


    private void RockBtnClicked(object sender, EventArgs e)
    {
        Play(1);
        _userChoiceMade = true;
        imgRock.Source = "stone.png";
    }

    private void PaperBtnClicked(object sender, EventArgs e)
    {
        Play(2);
        _userChoiceMade = true;
        imgPaper.Source = "paper.jpg";
    }

    private void ScissorBtnClicked(object sender, EventArgs e)
    {
        Play(3);
        _userChoiceMade = true;
        imgScissor.Source = "scissor.jpg";

    }



    private void QuitBtnClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainMenu();
    }
}
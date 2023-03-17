namespace CitiesGameByTDD
{
    public partial class Form1 : Form
    {
        private Players _players;
        private Cities _cities;
        private int moveTime = 180;
        private int moveTimeLeft;

        public Form1()
        {
            _players = new Players();
            _cities = new Cities();
            _players.SetPlayers(4);
            _cities.LoadCities();
            _cities.FillLetterCountersKeys();
            _cities.FillLetterCountersValues();
            InitializeComponent();
            GameMove();
        }

        private void GameMove()
        {
            labelMessage.Text = String.Empty;
            moveTimeLeft = moveTime;
            labelPlayer.Text = _players.CurrentPlayer.ToString();
            labelCurrentLetter.Text = _cities.CurrentLetter.ToString();
            timerMove.Start();
        }

        private void buttonSurrender_Click(object sender, EventArgs e)
        {
            labelMessage.Text = $"����� ����� {_players.CurrentPlayer} �������!";
            Thread.Sleep(3000);
            timerMove.Stop();
            _players.ExpelCurrentPlayer();
            _players.NextPlayer();
            GameMove();
        }

        private void buttonEnterCity_Click(object sender, EventArgs e)
        {
            switch (_cities.CheckCity(textBoxCity.Text))
            {
                case CheckCityResult.NotFound:
                    labelMessage.Text = "������ ������ ���!";
                    break;
                case CheckCityResult.FoundUsed:
                    labelMessage.Text = "����� ������!";
                    richTextBoxUsedCities.Text += textBoxCity + Environment.NewLine;
                    Thread.Sleep(3000);
                    _cities.AcceptCity(textBoxCity.Text);
                    _cities.SetCurrentLetter(textBoxCity.Text);
                    _players.NextPlayer();
                    GameMove();                    
                    break;
                case CheckCityResult.FoundUnused:
                    labelMessage.Text = "����� ����� ��� ��� ������!";
                    break;
                case CheckCityResult.WrongFirstLetter:
                    labelMessage.Text = $"�������� ������ ������ ���������� �� ����� {_cities.CurrentLetter}";
                    break;
                default: break;
            }
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            labelTime.Text = moveTimeLeft.ToString();
            moveTimeLeft--;
            if (moveTimeLeft < 0)
            {
                labelMessage.Text = $"����� ����� {_players.CurrentPlayer} ��������!";
                Thread.Sleep(3000);
                _players.ExpelCurrentPlayer();
                _players.NextPlayer();
                timerMove.Stop();
            }

        }
    }
}
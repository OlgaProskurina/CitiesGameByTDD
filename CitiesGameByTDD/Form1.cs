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

        }

        private void buttonEnterCity_Click(object sender, EventArgs e)
        {

        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            labelTime.Text = moveTimeLeft.ToString();
            moveTimeLeft--;
            if (moveTimeLeft < 0)
            {
                labelMessage.Text = $"Игрок номер {_players.CurrentPlayer} выбывает!";
                _players.ExpelCurrentPlayer();
                _players.NextPlayer();
                timerMove.Stop();
            }

        }
    }
}
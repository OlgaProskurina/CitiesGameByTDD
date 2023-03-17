namespace CitiesGameByTDD
{
    public partial class Form1 : Form
    {
        private Players _players;
        private Cities _cities;
        private int moveTimeLeft = 180;

        public Form1()
        {            
            InitializeComponent();
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
                timerMove.Stop();
            }

        }
    }
}
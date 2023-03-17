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
                labelMessage.Text = $"����� ����� {_players.CurrentPlayer} ��������!";
                _players.ExpelCurrentPlayer();
                timerMove.Stop();
            }

        }
    }
}
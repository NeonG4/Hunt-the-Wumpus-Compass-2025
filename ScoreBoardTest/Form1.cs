using ScoreBoard;
namespace ScoreBoardTest
{
    public partial class Form1 : Form
    {
        Scoreboard scoreboard = new Scoreboard();
        List<ScoreItem> items = new List<ScoreItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addscore_Click(object sender, EventArgs e)
        {
            //scoreboard.AddHighScore(namebox.Text, cavebox.Text, TurnBox)
        }

        private void Savetofile_Click(object sender, EventArgs e)
        {

        }

        private void loadtofile_Click(object sender, EventArgs e)
        {

        }

        private void addtobox_Click(object sender, EventArgs e)
        {

        }
    }
}

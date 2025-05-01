using ScoreBoardLibrary;
namespace ScoreboardTestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ScoreItem> items = new List<ScoreItem>();
        Scoreboard scoreboard = new Scoreboard();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            items = scoreboard.forTestOnlyGetFourNames();
            foreach (ScoreItem item in items)
            {
                scorebox.Items.Add(item.Name + " " + item.Score + " " + item.CaveType);
            }
        }

        private void Addnewscore_Click(object sender, EventArgs e)
        {
            
        }
    }
}

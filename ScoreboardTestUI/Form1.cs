using ScoreBoardLibrary;
using System.Drawing.Imaging;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ScoreboardTestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

       
        Scoreboard scoreboard = new Scoreboard();
        const string ScoreData = "Scores.csv";//this is where im gonna store all the scores !
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scorebox.Items.Clear();
            scoreboard.items = scoreboard.GetList();
            foreach (ScoreItem i in scoreboard.items)
            {
                scorebox.Items.Add(i.Name);
            }
        }

        private void Addnewscore_Click(object sender, EventArgs e)
        {
            scoreboard.AddHighScore(Playername.Text, int.Parse(scoretext.Text), CaveNames.Text);


        }

        private void scorebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scorebox.SelectedIndex == -1) { return; }
            int index = scorebox.SelectedIndex;
            Playername.Text = scoreboard.items[index].Name;
            scoretext.Text = scoreboard.items[index].Score.ToString();
            CaveNames.Text = scoreboard.items[index].CaveType;
        }

        private void Scoreodrer_Click(object sender, EventArgs e)
        {
            scoreboard.forTestOnlyGetFourNames();
            scoreboard.SortHighScore();
            
        }
    }
}

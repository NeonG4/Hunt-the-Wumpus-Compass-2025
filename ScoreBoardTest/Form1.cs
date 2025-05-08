using ScoreBoard;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
namespace ScoreBoardTest
{
    public partial class Form1 : Form
    {
        Scoreboard scoreboard = new Scoreboard();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addscore_Click(object sender, EventArgs e)
        {
            scoreboard.AddHighScore(namebox.Text, cavebox.Text, int.Parse(TurnBox.Text), int.Parse(Goldbvox.Text), int.Parse(arrowbox.Text), Wumpusdead.Checked);
        }

        private void Savetofile_Click(object sender, EventArgs e)
        {
            scoreboard.SaveTofile();
        }

        private void loadtofile_Click(object sender, EventArgs e)
        {
            scoreboard.ReadFromFile();
        }

        private void addtobox_Click(object sender, EventArgs e)
        {
            listBoxScores.Items.Clear();


            foreach (ScoreItem score in scoreboard.items)
            {
                listBoxScores.Items.Add(score.Name);
            }
        }

        private void listBoxScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxScores.SelectedIndex != -1)
            {
                int i = listBoxScores.SelectedIndex;

                cavebox.Text = scoreboard.items[i].CaveType.ToString();
                namebox.Text = scoreboard.items[i].Name;
                scorebox.Text = scoreboard.items[i].Score.ToString();
                arrowbox.Text = scoreboard.items[i].Arrows.ToString();
                Goldbvox.Text = scoreboard.items[i].Gold.ToString();
                TurnBox.Text = scoreboard.items[i].Turns.ToString();
                Wumpusdead.Checked = scoreboard.items[i].WumpusDead;
            }
        }
    }
}

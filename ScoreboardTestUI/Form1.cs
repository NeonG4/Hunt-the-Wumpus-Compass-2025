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

        List<ScoreItem> items = new List<ScoreItem>();
        Scoreboard scoreboard = new Scoreboard();
        const string ScoreData = "Scores.csv";//this is where im gonna store all the scores !
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
            ScoreItem contact;



            contact = new ScoreItem(Playername.Text, int.Parse(scoretext.Text), CaveNames.Text);
            items.Add(contact);
            scorebox.Items.Add(contact.Name);

        }

        private void scorebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scorebox.SelectedIndex == -1) { return; }
            int index = scorebox.SelectedIndex;
           Playername.Text = items[index].Name;
            scoretext.Text = items[index].Score.ToString();
            CaveNames.Text = items[index].CaveType;
        }
    }
}

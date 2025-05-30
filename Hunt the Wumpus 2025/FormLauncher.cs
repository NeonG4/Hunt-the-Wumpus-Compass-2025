using GameLocationLibrary;

namespace Hunt_the_Wumpus_2025
{
    public partial class FormLaucher : Form
    {
        // switch from a form to a splash screen
        public FormLaucher()
        {
            InitializeComponent();
        }
        public void StartGame(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name");
                textBoxName.Focus();
                return;
            }
            this.Hide();
            FormGame form = new FormGame();
            form.gc.playerName = textBoxName.Text;
            form.ShowDialog(); // creates a new game instance
            this.Show();
        }

        private void buttonTestGameLocation_Click(object sender, EventArgs e)
        {
            // open hazardstest.cs
            GameLocationTest form = new GameLocationTest();
            form.ShowDialog();
        }

        private void buttonTestCave_Click(object sender, EventArgs e)
        {
            // open cave form
            //Form1 form = new Form1();
            //form.ShowDialog();
        }
    }
}

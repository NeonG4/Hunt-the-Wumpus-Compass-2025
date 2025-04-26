namespace Hunt_the_Wumpus_2025
{
    public partial class FormLaucher : Form
    {
        public FormLaucher()
        {
            InitializeComponent();
        }
        public void StartGame(object sender, EventArgs e)
        {
            FormGame form = new FormGame();
            form.ShowDialog(); // creates a new game instance
        }
    }
}

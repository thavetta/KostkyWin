namespace KostkyWin
{
    public partial class MainWindow : Form
    {
        private readonly Random generator = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHodKostkou_Click(object sender, EventArgs e)
        {
            int maximum = int.Parse(lbMaximum.SelectedItem.ToString());
            int hodnota = generator.Next(1, maximum + 1);
            lblHodnota.Text = hodnota.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lbMaximum.SelectedIndex = 0;
        }
    }
}
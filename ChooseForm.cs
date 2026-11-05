namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object? sender, EventArgs e)
        {
            Bicycle bicycleForm = new Bicycle();
            bicycleForm.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object? sender, EventArgs e)
        {
            Mushroom mushroomForm = new Mushroom();
            mushroomForm.Show();
            this.Hide();
        }

        private void ChooseForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

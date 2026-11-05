namespace Lab2
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            int checkInHour;
            int checkOutHour;

            // TryParse gives false (instead of crashing) if the text is not a whole number
            bool inOk = int.TryParse(txtStart.Text.Trim(), out checkInHour);
            bool outOk = int.TryParse(txtEnd.Text.Trim(), out checkOutHour);

            if (!inOk || !outOk)
            {
                MessageBox.Show("Please enter whole numbers only (no letters or decimals).", "Invalid input");
                return;
            }

            if (checkInHour < 0 || checkInHour > 23)
            {
                MessageBox.Show("Pickup hour must be between 0 and 23.", "Invalid input");
                return;
            }

            if (checkOutHour < 1 || checkOutHour > 24)
            {
                MessageBox.Show("Return hour must be between 1 and 24.", "Invalid input");
                return;
            }

            if (checkOutHour <= checkInHour)
            {
                MessageBox.Show("Return hour must be later than pickup hour.", "Invalid input");
                return;
            }

            // Count how many hours fall in each price bracket
            int cheapHours = 0;   // 0-7 and 21-24  -> 500 RWF
            int midHours = 0;     // 7-14 and 19-21 -> 1000 RWF
            int peakHours = 0;    // 14-19          -> 1500 RWF

            for (int currentHour = checkInHour; currentHour < checkOutHour; currentHour++)
            {
                if ((currentHour >= 0 && currentHour < 7) || (currentHour >= 21 && currentHour < 24))
                {
                    cheapHours++;
                }
                else if ((currentHour >= 7 && currentHour < 14) || (currentHour >= 19 && currentHour < 21))
                {
                    midHours++;
                }
                else if (currentHour >= 14 && currentHour < 19)
                {
                    peakHours++;
                }
            }

            int bill = (cheapHours * 500) + (midHours * 1000) + (peakHours * 1500);

            txtTotal.Text = bill + " RWF";

            MessageBox.Show("Rental duration: " + (checkOutHour - checkInHour) + " hour(s)\n"
                + "Off-peak hours (500 RWF): " + cheapHours + "\n"
                + "Normal hours (1000 RWF): " + midHours + "\n"
                + "Busy hours (1500 RWF): " + peakHours + "\n\n"
                + "Total to pay: " + bill + " RWF", "Rental summary");
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Bicycle_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

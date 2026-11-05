namespace Lab2
{
    public partial class Mushroom : Form
    {
        int step = 1;            // which question we are on (1, 2 or 3)
        bool hasRing;
        bool hasConvexCap;

        public Mushroom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            string answer = txtAnswer.Text.Trim().ToLower();

            // Only "yes" or "no" is accepted
            if (answer != "yes" && answer != "no")
            {
                MessageBox.Show("Please enter only yes or no.", "Invalid answer");
                txtAnswer.Clear();
                txtAnswer.Focus();
                return;   // stop here, wait for a valid answer
            }

            bool isYes = answer == "yes";
            txtAnswer.Clear();
            txtAnswer.Focus();

            if (step == 1)
            {
                // Answer to: ring?
                hasRing = isYes;
                lblQuestion.Text = "Does the cap look convex (curved/dome-shaped)?";
                step = 2;
            }
            else if (step == 2)
            {
                // Answer to: convex cap?
                hasConvexCap = isYes;

                if (hasRing && !hasConvexCap)
                {
                    MessageBox.Show("Your mushroom is: Coprin chevelu", "Result");
                    step = 1;
                    lblQuestion.Text = "Does it have a ring around the stem?";
                }
                else if (!hasRing && hasConvexCap)
                {
                    MessageBox.Show("Your mushroom is: Pied bleu", "Result");
                    step = 1;
                    lblQuestion.Text = "Does it have a ring around the stem?";
                }
                else if (hasRing && hasConvexCap)
                {
                    lblQuestion.Text = "Does it grow in a forest?";
                    step = 3;
                }
                else
                {
                    lblQuestion.Text = "Does it have gills under the cap (instead of pores)?";
                    step = 3;
                }
            }
            else if (step == 3)
            {
                string mushroom;

                if (hasRing)
                {
                    // third question was: forest?
                    if (isYes)
                    {
                        mushroom = "Amanite tue-mouche";
                    }
                    else
                    {
                        mushroom = "Agaric Jaunissant";
                    }
                }
                else
                {
                    // third question was: gills?
                    if (isYes)
                    {
                        mushroom = "Girolle";
                    }
                    else
                    {
                        mushroom = "Cepe de bordeau";
                    }
                }

                MessageBox.Show("Your mushroom is: " + mushroom, "Result");
                step = 1;
                lblQuestion.Text = "Does it have a ring around the stem?";
            }
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

        private void Mushroom_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

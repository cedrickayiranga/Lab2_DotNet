namespace Lab2
{
    partial class Mushroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblQuestion = new Label();
            label3 = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 46);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Mushroom App";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(128, 96);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(311, 25);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Does it have a ring around the stem?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(157, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Your Answer :";
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(280, 134);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(170, 27);
            txtAnswer.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(278, 173);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(161, 37);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Answer";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(278, 248);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(375, 248);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Mushroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(label3);
            Controls.Add(lblQuestion);
            Controls.Add(label1);
            Name = "Mushroom";
            Text = "Mushroom";
            FormClosed += Mushroom_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblQuestion;
        private Label label3;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Button btnBack;
        private Button btnLogout;
    }
}
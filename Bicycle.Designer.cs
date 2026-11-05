namespace Lab2
{
    partial class Bicycle
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
            label2 = new Label();
            label3 = new Label();
            this.btnCalculate = new Button();
            this.btnBack = new Button();
            btnLogout = new Button();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 37);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Bicycle App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 94);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "PickUp Hour(0-23):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 135);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Return Hour(1-24):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnCalculate.Location = new Point(294, 182);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new Size(103, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += btnCalculate_Click;
            // 
            // btnBack
            // 
            this.btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnBack.Location = new Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(76, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(293, 289);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(290, 91);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(120, 23);
            txtStart.TabIndex = 7;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(290, 136);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(120, 23);
            txtEnd.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(290, 225);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(117, 23);
            txtTotal.TabIndex = 9;
            // 
            // Bicycle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(btnLogout);
            Controls.Add(this.btnBack);
            Controls.Add(this.btnCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bicycle";
            Text = "Bicycle";
            FormClosed += Bicycle_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalculate;
        private Button btnBack;
        private Button btnLogout;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtTotal;
    }
}
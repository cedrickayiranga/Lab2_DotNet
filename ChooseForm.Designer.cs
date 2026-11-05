namespace Lab2
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 59);
            label1.Name = "label1";
            label1.Size = new Size(232, 21);
            label1.TabIndex = 0;
            label1.Text = "Choose Which Project to open";
            // 
            // btnBicycle
            // 
            btnBicycle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBicycle.Location = new Point(208, 134);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(94, 27);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMushroom.Location = new Point(362, 131);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(97, 30);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Controls.Add(label1);
            Name = "ChooseForm";
            Text = "Choose";
            FormClosed += ChooseForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}
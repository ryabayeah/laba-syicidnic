
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.winner = new System.Windows.Forms.Label();
            this.teams = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.draws = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.looses = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.wins = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.goals = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.points = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.winner);
            this.panel1.Controls.Add(this.teams);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 467);
            this.panel1.TabIndex = 0;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winner.Location = new System.Drawing.Point(131, 426);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(0, 20);
            this.winner.TabIndex = 27;
            // 
            // teams
            // 
            this.teams.AutoSize = true;
            this.teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teams.Location = new System.Drawing.Point(21, 66);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(0, 20);
            this.teams.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(22, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(128, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "Draws";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(222, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Looses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(329, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Wins";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel6.Controls.Add(this.draws);
            this.panel6.Location = new System.Drawing.Point(121, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(69, 355);
            this.panel6.TabIndex = 20;
            // 
            // draws
            // 
            this.draws.AutoSize = true;
            this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.draws.Location = new System.Drawing.Point(23, 17);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(0, 20);
            this.draws.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(428, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Goals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(516, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Points";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.looses);
            this.panel5.Location = new System.Drawing.Point(217, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(69, 355);
            this.panel5.TabIndex = 19;
            // 
            // looses
            // 
            this.looses.AutoSize = true;
            this.looses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.looses.Location = new System.Drawing.Point(23, 17);
            this.looses.Name = "looses";
            this.looses.Size = new System.Drawing.Size(0, 20);
            this.looses.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.wins);
            this.panel4.Location = new System.Drawing.Point(317, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(69, 355);
            this.panel4.TabIndex = 18;
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.wins.Location = new System.Drawing.Point(22, 18);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(0, 20);
            this.wins.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.goals);
            this.panel3.Location = new System.Drawing.Point(416, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 355);
            this.panel3.TabIndex = 17;
            // 
            // goals
            // 
            this.goals.AutoSize = true;
            this.goals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.goals.Location = new System.Drawing.Point(23, 18);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(0, 20);
            this.goals.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.points);
            this.panel2.Location = new System.Drawing.Point(509, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 355);
            this.panel2.TabIndex = 16;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.points.Location = new System.Drawing.Point(24, 17);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(0, 20);
            this.points.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 490);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ya ymerla poka delala";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label draws;
        private System.Windows.Forms.Label looses;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label goals;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label teams;
        private System.Windows.Forms.Label winner;
    }
}


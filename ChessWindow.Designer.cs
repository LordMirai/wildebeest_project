namespace Chess
{
    partial class Chess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chess));
            this.RestartButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.GameState = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.GroupBox();
            this.BlackTimer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WhiteTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonRules = new System.Windows.Forms.Button();
            this.Timer.SuspendLayout();
            this.State.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RestartButton.Location = new System.Drawing.Point(5, 47);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(103, 24);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Reset game";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // TimeButton
            // 
            this.TimeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimeButton.Location = new System.Drawing.Point(5, 19);
            this.TimeButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(103, 24);
            this.TimeButton.TabIndex = 1;
            this.TimeButton.Text = "Start game";
            this.TimeButton.UseVisualStyleBackColor = true;
            // 
            // GameState
            // 
            this.GameState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameState.AutoSize = true;
            this.GameState.BackColor = System.Drawing.Color.Transparent;
            this.GameState.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.GameState.ForeColor = System.Drawing.Color.Black;
            this.GameState.Location = new System.Drawing.Point(4, 17);
            this.GameState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameState.Name = "GameState";
            this.GameState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GameState.Size = new System.Drawing.Size(70, 20);
            this.GameState.TabIndex = 2;
            this.GameState.Text = "NORMAL";
            this.GameState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.Controls.Add(this.BlackTimer);
            this.Timer.Controls.Add(this.label5);
            this.Timer.Controls.Add(this.WhiteTimer);
            this.Timer.Controls.Add(this.label4);
            this.Timer.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Timer.Location = new System.Drawing.Point(650, 93);
            this.Timer.Margin = new System.Windows.Forms.Padding(2);
            this.Timer.Name = "Timer";
            this.Timer.Padding = new System.Windows.Forms.Padding(2);
            this.Timer.Size = new System.Drawing.Size(112, 83);
            this.Timer.TabIndex = 3;
            this.Timer.TabStop = false;
            this.Timer.Text = "Timer";
            // 
            // BlackTimer
            // 
            this.BlackTimer.AutoSize = true;
            this.BlackTimer.BackColor = System.Drawing.Color.Transparent;
            this.BlackTimer.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackTimer.Location = new System.Drawing.Point(60, 24);
            this.BlackTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlackTimer.Name = "BlackTimer";
            this.BlackTimer.Size = new System.Drawing.Size(48, 17);
            this.BlackTimer.TabIndex = 0;
            this.BlackTimer.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "White";
            // 
            // WhiteTimer
            // 
            this.WhiteTimer.AutoSize = true;
            this.WhiteTimer.BackColor = System.Drawing.Color.Transparent;
            this.WhiteTimer.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteTimer.Location = new System.Drawing.Point(60, 53);
            this.WhiteTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhiteTimer.Name = "WhiteTimer";
            this.WhiteTimer.Size = new System.Drawing.Size(48, 17);
            this.WhiteTimer.TabIndex = 2;
            this.WhiteTimer.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Black";
            // 
            // State
            // 
            this.State.Controls.Add(this.GameState);
            this.State.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.State.Location = new System.Drawing.Point(650, 180);
            this.State.Margin = new System.Windows.Forms.Padding(2);
            this.State.Name = "State";
            this.State.Padding = new System.Windows.Forms.Padding(2);
            this.State.Size = new System.Drawing.Size(112, 44);
            this.State.TabIndex = 4;
            this.State.TabStop = false;
            this.State.Text = "King\'s state";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TimeButton);
            this.groupBox1.Controls.Add(this.RestartButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(650, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(112, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(22, 480);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 19);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(131, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(580, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "K";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(187, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(523, 480);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "J";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(359, 480);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "G";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(243, 480);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(301, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(411, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "H";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(467, 480);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "I";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(620, 450);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(620, 400);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(620, 300);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 19);
            this.label16.TabIndex = 18;
            this.label16.Text = "4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(620, 350);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(620, 205);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 19);
            this.label18.TabIndex = 20;
            this.label18.Text = "6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(620, 257);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(620, 114);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 19);
            this.label20.TabIndex = 22;
            this.label20.Text = "8";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(620, 161);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 19);
            this.label21.TabIndex = 21;
            this.label21.Text = "7";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(620, 18);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 19);
            this.label22.TabIndex = 24;
            this.label22.Text = "10";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(620, 65);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 19);
            this.label23.TabIndex = 23;
            this.label23.Text = "9";
            // 
            // buttonRules
            // 
            this.buttonRules.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRules.Location = new System.Drawing.Point(655, 480);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(103, 24);
            this.buttonRules.TabIndex = 25;
            this.buttonRules.Text = "About game";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 521);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Timer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Chess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.Timer.ResumeLayout(false);
            this.Timer.PerformLayout();
            this.State.ResumeLayout(false);
            this.State.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartButton;
        public System.Windows.Forms.Label GameState;
        private System.Windows.Forms.GroupBox Timer;
        private System.Windows.Forms.Label BlackTimer;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WhiteTimer;
        private System.Windows.Forms.GroupBox State;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonRules;
    }
}



namespace Kurs_
{
    partial class Form1
    {
        public int YBallSpeed = -5,
            XBallSpeed = 0, 
            P1SScore = 0, 
            P2SScore = 0, 
            P1Score = 0, 
            P2Score = 0, 
            ComScore = 0,
            P1MoveSpeed = 7,
            P2MoveSpeed = 7;

        public int P1Counter = 0, P2Counter = 0;

        public bool Flag1 = false, Flag2 = false;

        public bool ispressedA = false,
                    ispressedD = false,
                    ispressedL = false,
                    ispressedR = false;

        public bool P1BonusState = false,
                    P2BonusState = false;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameField = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P1SScoreBar = new System.Windows.Forms.Label();
            this.P2SScoreBar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IIActive = new System.Windows.Forms.CheckBox();
            this.ComScoreBar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2ScoreBar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1ScoreBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.GameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.Color.Silver;
            this.GameField.Controls.Add(this.Ball);
            this.GameField.Controls.Add(this.P2);
            this.GameField.Controls.Add(this.P1);
            this.GameField.Location = new System.Drawing.Point(12, 12);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(690, 590);
            this.GameField.TabIndex = 1;
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackColor = System.Drawing.Color.Maroon;
            this.Ball.Location = new System.Drawing.Point(317, 275);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(18, 18);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // P2
            // 
            this.P2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P2.BackColor = System.Drawing.Color.Indigo;
            this.P2.Location = new System.Drawing.Point(265, 3);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(140, 18);
            this.P2.TabIndex = 1;
            this.P2.TabStop = false;
            // 
            // P1
            // 
            this.P1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.P1.BackColor = System.Drawing.Color.Indigo;
            this.P1.Location = new System.Drawing.Point(265, 569);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(140, 18);
            this.P1.TabIndex = 0;
            this.P1.TabStop = false;
            // 
            // P1SScoreBar
            // 
            this.P1SScoreBar.AutoSize = true;
            this.P1SScoreBar.BackColor = System.Drawing.Color.Transparent;
            this.P1SScoreBar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1SScoreBar.ForeColor = System.Drawing.Color.Red;
            this.P1SScoreBar.Location = new System.Drawing.Point(24, 460);
            this.P1SScoreBar.Name = "P1SScoreBar";
            this.P1SScoreBar.Size = new System.Drawing.Size(39, 47);
            this.P1SScoreBar.TabIndex = 10;
            this.P1SScoreBar.Text = "0";
            // 
            // P2SScoreBar
            // 
            this.P2SScoreBar.AutoSize = true;
            this.P2SScoreBar.BackColor = System.Drawing.Color.Transparent;
            this.P2SScoreBar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2SScoreBar.ForeColor = System.Drawing.Color.Red;
            this.P2SScoreBar.Location = new System.Drawing.Point(89, 460);
            this.P2SScoreBar.Name = "P2SScoreBar";
            this.P2SScoreBar.Size = new System.Drawing.Size(39, 47);
            this.P2SScoreBar.TabIndex = 9;
            this.P2SScoreBar.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Game_Updater);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.P2SScoreBar);
            this.panel1.Controls.Add(this.P1SScoreBar);
            this.panel1.Controls.Add(this.IIActive);
            this.panel1.Controls.Add(this.ComScoreBar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.P2ScoreBar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.P1ScoreBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(708, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 590);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(75, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 47);
            this.label7.TabIndex = 13;
            this.label7.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "P1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // IIActive
            // 
            this.IIActive.AutoSize = true;
            this.IIActive.Location = new System.Drawing.Point(10, 15);
            this.IIActive.Name = "IIActive";
            this.IIActive.Size = new System.Drawing.Size(132, 34);
            this.IIActive.TabIndex = 8;
            this.IIActive.Text = "Do you want to play\r\nwith computer?";
            this.IIActive.UseVisualStyleBackColor = true;
            // 
            // ComScoreBar
            // 
            this.ComScoreBar.AutoSize = true;
            this.ComScoreBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComScoreBar.Location = new System.Drawing.Point(89, 180);
            this.ComScoreBar.Name = "ComScoreBar";
            this.ComScoreBar.Size = new System.Drawing.Size(22, 25);
            this.ComScoreBar.TabIndex = 7;
            this.ComScoreBar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Com:";
            // 
            // P2ScoreBar
            // 
            this.P2ScoreBar.AutoSize = true;
            this.P2ScoreBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2ScoreBar.Location = new System.Drawing.Point(89, 155);
            this.P2ScoreBar.Name = "P2ScoreBar";
            this.P2ScoreBar.Size = new System.Drawing.Size(22, 25);
            this.P2ScoreBar.TabIndex = 5;
            this.P2ScoreBar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "P2:";
            // 
            // P1ScoreBar
            // 
            this.P1ScoreBar.AutoSize = true;
            this.P1ScoreBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1ScoreBar.Location = new System.Drawing.Point(89, 130);
            this.P1ScoreBar.Name = "P1ScoreBar";
            this.P1ScoreBar.Size = new System.Drawing.Size(22, 25);
            this.P1ScoreBar.TabIndex = 3;
            this.P1ScoreBar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "P1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameField);
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GameField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ComScoreBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label P2ScoreBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label P1ScoreBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IIActive;
        private System.Windows.Forms.Label P1SScoreBar;
        private System.Windows.Forms.Label P2SScoreBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer5;
    }
}


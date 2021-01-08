
namespace reaquect_ball
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.scoreAnouncer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 20;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Control;
            this.Score.Location = new System.Drawing.Point(824, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(74, 25);
            this.Score.TabIndex = 0;
            this.Score.Text = "score";
            // 
            // p1Score
            // 
            this.p1Score.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.p1Score.Location = new System.Drawing.Point(822, 32);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(33, 32);
            this.p1Score.TabIndex = 2;
            this.p1Score.Text = "0";
            // 
            // scoreAnouncer
            // 
            this.scoreAnouncer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreAnouncer.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreAnouncer.Location = new System.Drawing.Point(715, 182);
            this.scoreAnouncer.Name = "scoreAnouncer";
            this.scoreAnouncer.Size = new System.Drawing.Size(220, 36);
            this.scoreAnouncer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(841, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // p2Score
            // 
            this.p2Score.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.SystemColors.Control;
            this.p2Score.Location = new System.Drawing.Point(852, 32);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(27, 27);
            this.p2Score.TabIndex = 5;
            this.p2Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(937, 493);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreAnouncer);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.Score);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label scoreAnouncer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p2Score;
    }
}


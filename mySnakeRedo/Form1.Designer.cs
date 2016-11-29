namespace mySnakeRedo
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssScoreText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssScoreNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSpeedText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSpeedNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssScoreText,
            this.tssScoreNum,
            this.tssSpeedText,
            this.tssSpeedNum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(305, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssScoreText
            // 
            this.tssScoreText.Name = "tssScoreText";
            this.tssScoreText.Size = new System.Drawing.Size(36, 17);
            this.tssScoreText.Text = "Score";
            // 
            // tssScoreNum
            // 
            this.tssScoreNum.Name = "tssScoreNum";
            this.tssScoreNum.Size = new System.Drawing.Size(13, 17);
            this.tssScoreNum.Text = "0";
            // 
            // tssSpeedText
            // 
            this.tssSpeedText.Name = "tssSpeedText";
            this.tssSpeedText.Size = new System.Drawing.Size(39, 17);
            this.tssSpeedText.Text = "Speed";
            // 
            // tssSpeedNum
            // 
            this.tssSpeedNum.Name = "tssSpeedNum";
            this.tssSpeedNum.Size = new System.Drawing.Size(13, 17);
            this.tssSpeedNum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 327);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Snake by Duong Nguyen";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssScoreText;
        private System.Windows.Forms.ToolStripStatusLabel tssScoreNum;
        private System.Windows.Forms.ToolStripStatusLabel tssSpeedText;
        private System.Windows.Forms.ToolStripStatusLabel tssSpeedNum;
    }
}


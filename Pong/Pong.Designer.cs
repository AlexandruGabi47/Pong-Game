namespace Pong
{
	partial class Pong
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.Player1 = new System.Windows.Forms.Label();
			this.Player2 = new System.Windows.Forms.Label();
			this.scoreLabel2 = new System.Windows.Forms.Label();
			this.scoreLabel1 = new System.Windows.Forms.Label();
			this.CountdownLabel = new System.Windows.Forms.Label();
			this.pongBall = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.TimeTickHandler);
			// 
			// Player1
			// 
			this.Player1.BackColor = System.Drawing.Color.Gray;
			this.Player1.Location = new System.Drawing.Point(12, 190);
			this.Player1.Name = "Player1";
			this.Player1.Size = new System.Drawing.Size(10, 80);
			this.Player1.TabIndex = 0;
			// 
			// Player2
			// 
			this.Player2.BackColor = System.Drawing.Color.Gray;
			this.Player2.Location = new System.Drawing.Point(867, 190);
			this.Player2.Name = "Player2";
			this.Player2.Size = new System.Drawing.Size(10, 80);
			this.Player2.TabIndex = 1;
			// 
			// scoreLabel2
			// 
			this.scoreLabel2.AutoSize = true;
			this.scoreLabel2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLabel2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.scoreLabel2.Location = new System.Drawing.Point(826, 9);
			this.scoreLabel2.Name = "scoreLabel2";
			this.scoreLabel2.Size = new System.Drawing.Size(34, 32);
			this.scoreLabel2.TabIndex = 4;
			this.scoreLabel2.Text = "0";
			// 
			// scoreLabel1
			// 
			this.scoreLabel1.AutoSize = true;
			this.scoreLabel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLabel1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.scoreLabel1.Location = new System.Drawing.Point(29, 9);
			this.scoreLabel1.Name = "scoreLabel1";
			this.scoreLabel1.Size = new System.Drawing.Size(29, 40);
			this.scoreLabel1.TabIndex = 3;
			this.scoreLabel1.Text = "0";
			this.scoreLabel1.UseCompatibleTextRendering = true;
			// 
			// CountdownLabel
			// 
			this.CountdownLabel.AutoSize = true;
			this.CountdownLabel.Font = new System.Drawing.Font("Verdana", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountdownLabel.ForeColor = System.Drawing.Color.Black;
			this.CountdownLabel.Location = new System.Drawing.Point(386, 34);
			this.CountdownLabel.Name = "CountdownLabel";
			this.CountdownLabel.Size = new System.Drawing.Size(58, 57);
			this.CountdownLabel.TabIndex = 6;
			this.CountdownLabel.Text = "0";
			this.CountdownLabel.Visible = false;
			// 
			// pongBall
			// 
			this.pongBall.BackColor = System.Drawing.Color.SlateGray;
			this.pongBall.Location = new System.Drawing.Point(411, 215);
			this.pongBall.Name = "pongBall";
			this.pongBall.Size = new System.Drawing.Size(10, 10);
			this.pongBall.TabIndex = 0;
			this.pongBall.TabStop = false;
			// 
			// Pong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(889, 472);
			this.Controls.Add(this.pongBall);
			this.Controls.Add(this.CountdownLabel);
			this.Controls.Add(this.scoreLabel2);
			this.Controls.Add(this.scoreLabel1);
			this.Controls.Add(this.Player2);
			this.Controls.Add(this.Player1);
			this.Name = "Pong";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label Player1;
		private System.Windows.Forms.Label Player2;
		private System.Windows.Forms.Label scoreLabel2;
		private System.Windows.Forms.Label scoreLabel1;
		private System.Windows.Forms.Label CountdownLabel;
		private System.Windows.Forms.PictureBox pongBall;
	}
}


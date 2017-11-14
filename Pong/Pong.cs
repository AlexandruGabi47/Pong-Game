using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//TODOS: angle, increasing speed

namespace Pong
{
	public partial class Pong : Form
	{
		Random rnd = new Random();
		Timer countdown = new Timer { Interval = 1000 };
		int countdownTick = 2;

		bool up1IsPressed = false;
		bool down1IsPressed = false;
		bool up2IsPressed = false;
		bool down2IsPressed = false;

		bool Xplus = false;//transform this into angle
		bool Yplus = false;

		int player1Score = 0;
		int player2Score = 0;

		int platformSpeed = 3;
		int ballSpeed = 3;
		bool moveBall = true;

		public Pong()
		{
			InitializeComponent();
			countdown.Tick += CountdownTickHandler;
			
			if (rnd.Next(0, 2) == 1) Xplus = false;
			else Xplus = true;

			//Fixes the screen flickering
			int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
			style |= NativeWinAPI.WS_EX_COMPOSITED;
			NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
		}

		private void TimeTickHandler(object sender, EventArgs e)
		{
			//Updating the score labels
			scoreLabel1.Text = $"{player1Score}";
			scoreLabel2.Text = $"{player2Score}";
			//Handling the controls
			if (up1IsPressed)
				if (!(Player1.Top <= 0))
					Player1.Top -= platformSpeed;
			if (down1IsPressed)
				if (!(Player1.Bottom >= ClientSize.Height))
					Player1.Top += platformSpeed;

            if (up2IsPressed)
				if (!(Player2.Top <= 0))
					Player2.Top -= platformSpeed;
			if (down2IsPressed)
				if (!(Player2.Bottom >= ClientSize.Height))
					Player2.Top += platformSpeed;
			//Checking if it hit a platform
			if (pongBall.Bounds.IntersectsWith(Player1.Bounds) && !(pongBall.Location.X < Player1.Location.X + Player1.Width - 3))
				Xplus = !Xplus;
			if (pongBall.Bounds.IntersectsWith(Player2.Bounds) && !(pongBall.Location.X > Player2.Location.X + Player2.Width + 3))
				Xplus = !Xplus;
			//Checking if it's out of bounds
			if (pongBall.Bottom >= ClientSize.Height || pongBall.Top <= 0)
				Yplus = !Yplus;

			if (pongBall.Left + pongBall.Width >= ClientSize.Width)
				SomeoneScored(ref player1Score);

			if (pongBall.Left <= 0)
				SomeoneScored(ref player2Score);
			//Moving the ball
			if (moveBall)
			{
				if (Xplus) pongBall.Left += ballSpeed;
				else pongBall.Left -= ballSpeed;

				if (Yplus) pongBall.Top += ballSpeed;
				else pongBall.Top -= ballSpeed;
			}
		}

		public void SomeoneScored(ref int playerScore)
		{
			playerScore++;
			GameCountdown();
		}

		public void GameCountdown()
		{
			//Changing direction
			Xplus = !Xplus;
			//Moving the ball in the middle of the screen
			moveBall = false;
			pongBall.Left = ClientSize.Width / 2;
			pongBall.Top = ClientSize.Height / 2;
			//Starting the countdown
			CountdownLabel.Visible = true;
			CountdownLabel.Text = $"{countdownTick}";
			CountdownLabel.Refresh();
			countdown.Start();
		}

		private void CountdownTickHandler(object sender, EventArgs e)
		{
			if (countdownTick == 0)
			{
				countdown.Stop();
				CountdownLabel.Visible = false;
				countdownTick = 2;
				moveBall = true;
			}
			countdownTick--;
			CountdownLabel.Text = $"{countdownTick}";
			CountdownLabel.Refresh();
		}

		private void Pong_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W)
				up1IsPressed = true;
			if (e.KeyCode == Keys.S)
				down1IsPressed = true;
			if (e.KeyCode == Keys.Up)
				up2IsPressed = true;
			if (e.KeyCode == Keys.Down)
				down2IsPressed = true;
		}

		private void Pong_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W)
				up1IsPressed = false;
			if (e.KeyCode == Keys.S)
				down1IsPressed = false;
			if (e.KeyCode == Keys.Up)
				up2IsPressed = false;
			if (e.KeyCode == Keys.Down)
				down2IsPressed = false;
		}
	}

	//Fixes the screen flickering
	internal static class NativeWinAPI
	{
		internal static readonly int GWL_EXSTYLE = -20;
		internal static readonly int WS_EX_COMPOSITED = 0x02000000;

		[DllImport("user32")]
		internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32")]
		internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
	}
}

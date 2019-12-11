using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SinglePlayForm : Form
    {
        private const int rectSize = 27; // 오목판의 셀 크기
        private const int edgeCount = 15; // 오목판의 선 개수

        private enum Horse { none = 0, BLACK, WHITE }; //특정 오목판이 비었으면 none
        private Horse[,] board = new Horse[edgeCount, edgeCount];
        private Horse nowPlayer = Horse.BLACK;

        private bool playing = false; // 게임이 진행중인지 체크하는 변수

        public SinglePlayForm()
        {
            InitializeComponent();
        }

        private bool judge() // 승리 판정 함수
        {
            for (int i = 0; i < edgeCount - 4; i++) // 가로
                for (int j = 0; j < edgeCount; j++)
                    if (board[i, j] == nowPlayer && board[i + 1, j] == nowPlayer && board[i + 2, j] == nowPlayer &&
                        board[i + 3, j] == nowPlayer && board[i + 4, j] == nowPlayer)
                        return true;          
            for (int i = 0; i < edgeCount - 4; i++) // 세로
                for (int j = 0; j < edgeCount; j++)
                    if (board[j, i] == nowPlayer && board[j, i + 1] == nowPlayer && board[j, i + 2] == nowPlayer &&
                        board[j, i + 3] == nowPlayer && board[j, i + 4] == nowPlayer)
                        return true;
            for (int i = 0; i < edgeCount - 4; i++) // y = x 직선
                for (int j = 0; j < edgeCount - 4; j++)
                    if (board[i, j] == nowPlayer && board[i + 1, j + 1] == nowPlayer && board[i + 2, j + 2] == nowPlayer &&
                        board[i + 3, j + 3] == nowPlayer && board[i + 4, j + 4] == nowPlayer) 
                        return true;
            for (int i = 4; i < edgeCount; i++) // y = -x 직선
                for (int j = 0; j < edgeCount - 4; j++)
                    if (board[i, j] == nowPlayer && board[i - 1, j + 1] == nowPlayer && board[i - 2, j + 2] == nowPlayer &&
                        board[i - 3, j + 3] == nowPlayer && board[i - 4, j + 4] == nowPlayer)
                        return true;
            return false;
        }

        private void refresh()
        {
            this.boardPicture2.Refresh();
            for (int i = 0; i < edgeCount; i++)
                for (int j = 0; j < edgeCount; j++)
                    board[i, j] = Horse.none;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                refresh();
                playing = true;
                playButton.Text = "Restart";
                status.Text = nowPlayer.ToString() + " Player's turn";
            }
            else
            {
                refresh();
                status.Text = "Restart the game";
            }
        }

        private void boardPicture_MouseDown(object sender, MouseEventArgs e)
        {
         
        }
        private void boardPicture_Paint (object sender, PaintEventArgs e)
        {
           
        }   
        private void SinglePlayForm_Load(object sender, EventArgs e)
        {

        }
        private void boardPicture_Click(object sender, EventArgs e)
        {

        }
        private void boardPicture_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void boardPicture2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!playing)
            {
                MessageBox.Show("Please start the game.");
                return;
            }
            Graphics g = this.boardPicture2.CreateGraphics();
            int x = e.X / rectSize;
            int y = e.Y / rectSize;
            if (x < 0 || y < 0 || x >= edgeCount || y > edgeCount)
            {
                MessageBox.Show("테두리를 벗어날 수 없습니다.");
                return;
            }
            if (board[x, y] != Horse.none) return; //이미 돌이 올라가 있을 때
            board[x, y] = nowPlayer;
            //검은 돌이면 검은색 화면에 칠, 흰색 돌이면 흰색 화면에 칠
            if (nowPlayer == Horse.BLACK)
            {
                SolidBrush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize-5, rectSize-5);
            }   
            else
            {
                SolidBrush brush = new SolidBrush(Color.White);
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize-5, rectSize-5);
            }
            if (judge())
            {
                status.Text = nowPlayer.ToString() + " Player is win!!!";
                playing = false;
                playButton.Text = "게임시작";
            }
            else
            {
                nowPlayer = ((nowPlayer == Horse.BLACK) ? Horse.WHITE : Horse.BLACK);
                status.Text = nowPlayer.ToString() + " Player's turn";
            }
        }

        private void boardPicture2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            Color lineColor = Color.Black; //오목판 선 색깔
            Pen p = new Pen(lineColor, 2);// 굵기가 2인 검은색(lineColor)선
            //테두리 만들기
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2); // 좌측
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize / 2); // 상측
            gp.DrawLine(p, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2); // 하측
            gp.DrawLine(p, rectSize * edgeCount - rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2); // 우측
            p = new Pen(lineColor, 1);
            //대각선 방향으로 이동하면서 십자가 모양의 선 그리기
            for (int i = rectSize + rectSize / 2; i < rectSize * edgeCount - rectSize / 2; i += rectSize)
            {
                gp.DrawLine(p, rectSize / 2, i, rectSize * edgeCount - rectSize / 2, i);
                gp.DrawLine(p, i, rectSize / 2, i, rectSize * edgeCount - rectSize / 2);
            }
        }

        
    }
}

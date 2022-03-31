using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {


        List<Rectangle> rectangles = new List<Rectangle>();
        List<int> player1Marks = new List<int>();
        List<int> player2Marks = new List<int>();
        List<Player> players;
        DataGridViewRow p1data;
        DataGridViewRow p2data;
        int turnCount = 0;
        Boolean Player1turn = true;
        Boolean playerWins = false;
        Boolean isCpu = false;
        Boolean isDraw = false;
        Random intervalRnd = new Random();
        public Form2(DataGridViewRow p1, DataGridViewRow p2)
        {

            InitializeComponent();
            //Add player names to status bar.
            p1data = p1;
            p2data = p2;
            p1tSSL.Text = " O - " + p1.Cells[1].Value.ToString();
            p1tSSL.BackColor = Color.LightGreen;
            p2tSSL.Text = " X -  " + p2.Cells[1].Value.ToString();

            int p2Id = int.Parse(p2.Cells[0].Value.ToString());

            //Check if cpu is playing
            if (p2Id == 1)
            {
                isCpu = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        //Board painting function
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myBrush = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            //Board location
            int ypos = 50;
            int xpos = 250;

            //Paint 3x3 board. When one column is done reset y-coords back to 50 and increase x-coords.
            for (int y = 0; y < 3; y++)
            {
                //Paint three squares in one column by increasing y-coords in for loop.
                for (int i = 0; i < 3; i++)
                {
                    Rectangle r = new Rectangle(xpos, ypos, 100, 100);
                    rectangles.Add(r);
                    formGraphics.DrawRectangle(myBrush, r);
                    ypos += 100;
                }
                ypos = 50;
                xpos += 100;
            }

            myBrush.Dispose();
            formGraphics.Dispose();
        }
        //Function for drawing player mark. Gets coords from the mouseUp or cpu_play functions. Shape of the mark is based on the playersturn
        private void DrawMark(PaintEventArgs e, int x, int y, int width, int height)
        {
            Pen pen = new Pen(Color.Black, 3);
            if (Player1turn)
            {
                pen.Color = Color.Red;
                e.Graphics.DrawEllipse(pen, x, y, width, height);
            }
            else
            {
                pen.Color = Color.Black;
                e.Graphics.DrawLine(pen, x, y, x + 100, y + 100);
                e.Graphics.DrawLine(pen, x, y + 100, x + 100, y);
            }
        }
        private void CheckWinConditions(List<int> playerMarks)
        {
            
            //Check if player has winning line in columns, rows or diagonal. After nine turns check if game is draw.
            //Check columns
            if (playerMarks.Contains(0) && playerMarks.Contains(1) && playerMarks.Contains(2))
            {
                playerWins = true;
                EndGame();
            }
            if (playerMarks.Contains(3) && playerMarks.Contains(4) && playerMarks.Contains(5))
            {
                playerWins = true;
                EndGame();
            }
            if (playerMarks.Contains(6) && playerMarks.Contains(7) && playerMarks.Contains(8))
            {
                playerWins = true;
                EndGame();
            }
            //Check Rows
            if (playerMarks.Contains(0) && playerMarks.Contains(3) && playerMarks.Contains(6))
            {
                playerWins = true;
                EndGame();
            }
            if (playerMarks.Contains(1) && playerMarks.Contains(4) && playerMarks.Contains(7))
            {
                playerWins = true;
                EndGame();
            }
            if (playerMarks.Contains(2) && playerMarks.Contains(5) && playerMarks.Contains(8))
            {
                playerWins = true;
                EndGame();
            }
            //Check diagonal
            if (playerMarks.Contains(0) && playerMarks.Contains(4) && playerMarks.Contains(8))
            {
                playerWins = true;
                EndGame();
            }
            if (playerMarks.Contains(2) && playerMarks.Contains(4) && playerMarks.Contains(6))
            {
                playerWins = true;
                EndGame();
            }
            //Check if draw
            if (turnCount == 9 && !playerWins)
            {
                isDraw = true;
                EndGame();
            }

        }
        //End game function that is called if checkWinner functio finds a winner
        private void EndGame()
        {
            //Stop timers
            isCpu = false;
            cpuTimer.Stop();
            int winnerId;
            int loserId;
            //Fetch json file of the players
            if (File.Exists("c:\\temp\\players.json"))
            {
                using (StreamReader file = File.OpenText("c:\\temp\\players.json"))
                {
                    string json = File.ReadAllText("c:\\temp\\players.json");
                    players = JsonConvert.DeserializeObject<List<Player>>(json);
                    file.Close();
                }
            }
            //If draw increase players draw count
            if (isDraw)
            {
                MessageBox.Show("It's a Draw", "Game Finished");
                winnerId = int.Parse(p1data.Cells[0].Value.ToString());
                loserId = int.Parse(p2data.Cells[0].Value.ToString());
                players[winnerId - 1].drawCount++;
                players[loserId - 1].drawCount++;
            }
            else
            {
                //Check which player is the winner
                if (Player1turn && !isDraw)
                {
                    MessageBox.Show(p1data.Cells[1].Value.ToString() + " Wins","Game Finished");

                    winnerId = int.Parse(p1data.Cells[0].Value.ToString());
                    loserId = int.Parse(p2data.Cells[0].Value.ToString());

                }
                else
                {
                    MessageBox.Show(p2data.Cells[1].Value.ToString() + " Wins");
                    winnerId = int.Parse(p2data.Cells[0].Value.ToString());
                    loserId = int.Parse(p1data.Cells[0].Value.ToString());
                }
            }
            if (!isDraw)
            {
                //Add data to correct player based on the player id.
                players[winnerId - 1].winCount++;
                players[loserId - 1].lossCount++;
            }
            File.WriteAllText("c:\\temp\\players.json", JsonConvert.SerializeObject(players));
            this.Close();
        }

        //MouseUp function, checks the board for already played marks and draws a new mark where user clicks.
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            //Check if it's cpu's turn
            if (!cpuTimer.Enabled)
            {
                //Painteventargs which is passed on to draw function
                Graphics g;
                g = this.CreateGraphics();
                Rectangle r = new Rectangle();
                PaintEventArgs arg = new PaintEventArgs(g, r);

                //Go trough the board and check if the clicked square has a mark. Only allow new marks on empty squares
                for (int i = 0; i < rectangles.Count; i++)
                {

                    if (!player1Marks.Contains(i) && !player2Marks.Contains(i))
                    {
                        //Check which square is clicked
                        if ((e.X > rectangles[i].X) && (e.X < rectangles[i].X + rectangles[i].Width) &&
                        (e.Y > rectangles[i].Y) && (e.Y < rectangles[i].Y + rectangles[i].Height))
                        {
                            DrawMark(arg, rectangles[i].X, rectangles[i].Y, rectangles[i].Width, rectangles[i].Height);
                            //Add square to list of played marks
                            if (Player1turn)
                            {

                                player1Marks.Add(i);
                            }
                            else
                            {
                                player2Marks.Add(i);
                            }
                            //Increase turn counter and change player turn. If second player is cpu enable cpuTimer and call cpu_play function.
                            addTurn();
       
                            if (isCpu && !Player1turn)
                            {
                                //Randomized timer for cpu
                                cpuTimer.Interval = intervalRnd.Next(500, 2000); 
                                cpuTimer.Enabled = true;
                                cpuTimer.Start();
                            }
                        }
                    }
                }
            }
        }

        //Function where cpu makes a play
        private void cpu_Play()
        {
            Random rnd = new Random();

            Graphics g;
            g = this.CreateGraphics();
            Rectangle r = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, r);

            Boolean cpuTurnOver = false;
            //Gets random number between 0-8 and checks if that square is on the already played list
            while (!cpuTurnOver)
            {
                int play = rnd.Next(8);
                if (!player1Marks.Contains(play) && !player2Marks.Contains(play))
                {
                    DrawMark(arg, rectangles[play].X, rectangles[play].Y, rectangles[play].Width, rectangles[play].Height);
                    player2Marks.Add(play);
                    cpuTurnOver = true;
                }
            }
            addTurn();

        }
        //Timer function for the cpu.
        private void cpuTimer_Tick(object sender, EventArgs e)
        {
            cpu_Play();
           
            cpuTimer.Stop();
            cpuTimer.Enabled = false;

        }
        //Increase turn counter and change player turn. Check win conditions if three or more turns played.
        private void addTurn()
        {
            turnCount++;
            if (turnCount > 2)
            {
                if (Player1turn)
                {
                    CheckWinConditions(player1Marks);
                }
                else
                {
                    CheckWinConditions(player2Marks);
                }

            }
            Player1turn = !Player1turn;
            
            if (Player1turn)
            {
                p1tSSL.BackColor = Color.LightGreen;
                p2tSSL.BackColor = Color.SeaShell;
            }
            if (!Player1turn)
            {
                p2tSSL.BackColor = Color.LightGreen;
                p1tSSL.BackColor = Color.SeaShell;
            }
        }
    }
}

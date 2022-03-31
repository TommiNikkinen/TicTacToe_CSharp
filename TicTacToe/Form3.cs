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
    public partial class Form3 : Form
    {
        List<Player> players;
        Boolean gameRunning = false;
        Boolean addingPlayer = false;

        public Form3()
        {
            //Play background music and populate dgv's
            InitializeComponent();
           // string s = AppContext.BaseDirectory;
           // System.Media.SoundPlayer sp = new System.Media.SoundPlayer(s + "backgroundmusic.wav");

           // sp.PlayLooping();

            populatePlayersDgv();
            p1DataGridView.Columns[3].HeaderCell.Value = "Birthday";
            p1DataGridView.Columns[4].HeaderCell.Value = "Wins";
            p1DataGridView.Columns[5].HeaderCell.Value = "Losses";
            p1DataGridView.Columns[6].HeaderCell.Value = "Draws";
            p2DataGridView.Columns[3].HeaderCell.Value = "Birthday";
            p2DataGridView.Columns[4].HeaderCell.Value = "Wins";
            p2DataGridView.Columns[5].HeaderCell.Value = "Losses";
            p2DataGridView.Columns[6].HeaderCell.Value = "Draws";

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void populatePlayersDgv()
        {
            //Get player data from the json file and populate dgv's
            //If json-file doesnt exist, create a new one with a default cpu player.
            if (File.Exists("c:\\temp\\players.json"))
            {
                using (StreamReader file = File.OpenText("c:\\temp\\players.json"))
                {
                    string json = File.ReadAllText("c:\\temp\\players.json");
                    players = JsonConvert.DeserializeObject<List<Player>>(json);
                   
                    file.Close();
                }
            }
            else
            {
                players = new List<Player>();
                Player p = new Player();

                p.firstname = "CPU";
                p.surname = "";
                
                p.winCount = 0;
                p.lossCount = 0;
                p.drawCount = 0;
                p.id = players.Count + 1;

                players.Add(p);

                File.WriteAllText("c:\\temp\\players.json", JsonConvert.SerializeObject(players));
            }
          
            BindingSource source = new BindingSource();
            BindingSource source2 = new BindingSource();
            source.DataSource = players;
            source2.DataSource = players;
            p1DataGridView.DataSource = source;
            p2DataGridView.DataSource = source2;


        }

        //Functions for opening addPlayer form. Refresh main form when new player is added.
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            if (!addingPlayer) {
                addingPlayer = true;
            AddPlayerForm apf = new AddPlayerForm(this);
            apf.FormClosing += new FormClosingEventHandler(this.addPlayerForm_FormClosing);
            apf.Show();
            }
        }

        private void addPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            populatePlayersDgv();
            Refresh();
            addingPlayer = false;
        }
        //Start game if player 1 hasn't picked cpu and game isnt already running.
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(p1DataGridView.SelectedRows[0].Cells[0].Value.ToString()) == 1) {
                MessageBox.Show("Only player 2 can be set to Cpu", "Help!");
            }
            else if (int.Parse(p1DataGridView.SelectedRows[0].Cells[0].Value.ToString()) == int.Parse(p2DataGridView.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Pick two different players", "Help!");
            }
            else if (!gameRunning && int.Parse(p1DataGridView.SelectedRows[0].Cells[0].Value.ToString()) != 1) { 
                DataGridViewRow p1 = p1DataGridView.SelectedRows[0];
                DataGridViewRow p2 = p2DataGridView.SelectedRows[0];
                Form2 f2 = new Form2(p1, p2);
                f2.FormClosing += new FormClosingEventHandler(this.form2_FormClosing);
                f2.Show();
                gameRunning = true;
            }
            
        }
        private void form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameRunning = false;
            populatePlayersDgv();
            Refresh();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

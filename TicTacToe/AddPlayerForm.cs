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
    public partial class AddPlayerForm : Form
    {
        List<Player> players;
        Form3 f;
        Boolean nameValidation = false;
        public AddPlayerForm(Form3 f3)
        {
            InitializeComponent();
            f = f3;
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
            }
        }

        //Check that name fields contain atleast two letters
        private void checkValidation()
        {
            if(firstnameTb.Text.Length < 2 || surnameTb.Text.Length < 2)
            {
                MessageBox.Show("Two letters required for name", "Error");
                nameValidation = false;
            }
            if(firstnameTb.Text.Length > 1 && surnameTb.Text.Length > 1)
            {
                nameValidation = true;
            }
        }

        private void addNewPlayerBtn_Click(object sender, EventArgs e)
        {
            Player p = new Player();

            //Check string length for names
            checkValidation();
            if (nameValidation) { 

                p.firstname = firstnameTb.Text;
                p.surname = surnameTb.Text;
                p.dob = DobDtp.Value;
                p.winCount = 0;
                p.lossCount = 0;
                p.drawCount = 0;
                p.id = players.Count + 1;

                players.Add(p);

                File.WriteAllText("c:\\temp\\players.json", JsonConvert.SerializeObject(players));
                this.Close();
            }


        }

        //Only allow user type letters in name fields
        private void firstnameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Only allow user input current date or past dates for their date of birht
        private void DobDtp_ValueChanged(object sender, EventArgs e)
        {
            DobDtp.MaxDate = DateTime.Today;
        }
    }
}

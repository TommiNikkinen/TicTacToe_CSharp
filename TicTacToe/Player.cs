using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public DateTime dob { get; set; }
        public int winCount { get; set; }
        public int lossCount { get; set; }
        public int drawCount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp.APP
{
    public class Record
    {

        // ex: [ 10/7 Computer: Rock VS You: Paper => You Win! ]
        public DateTime Date { get; }
        public string PC { get; }
        public string Player { get; }
        public string result { get; }
        // constructor
        public Record(DateTime date, string pc, string player, string result) //X
        {
            Date = date;
            PC = pc;
            Player = player;
            result = result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp.APP
{
    public class Record
    {
        //This way is weakening encapsulation, but for example its okay
        //XmlSerializer(and ofteh other serializers)
        //expect class that have zero-argument construtor

        public DateTime Date { get; set; }
        public string PC { get; set; }
        public string Player { get; set; }
        public string result { get; set; }
        // constructor
        public Record(DateTime date, string pc, string player, string result) 
        {
            Date = date;
            PC = pc;
            Player = player;
            this.result = result;
        }
        //Constructor
        public Record()
        {

        }
    }
}
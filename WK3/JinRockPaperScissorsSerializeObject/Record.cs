using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp.APP
{
    public class Record
    {

        /*XmlSerializer**
        expect class that have a zero-argument constructor
        and they can fill in public properties via their setters*/


        /* a class that ONLY has a zero=arg construcor and public get set properties
        is sometimes called a POCO(plain old CLR object)*/
        
        // ex: [ 10/7 Computer: Rock VS You: Paper => You Win! ]
        public DateTime Date { get; }
        public string PC { get; }
        public string Player { get; }
        public string result { get; }
        // constructor
        public Record(DateTime date, string pc, string player, string result)
        {
            this.Date = date;
            this.PC = pc;
            this.Player = player;
            this.result = result;
        }

        public Record() //X
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RockPaperScissorsApp.APP
{
    public class Record
    {
        //This way is weakening encapsulation, but for example its okay
        //XmlSerializer(and ofteh other serializers)
        //expect class that have zero-argument construtor
        [XmlAttribute(AttributeName = "When")]
        public DateTime Date { get; set; }
        [XmlElement(ElementName = "CPUMove")]
        public string PC { get; set; }
        [XmlElement(ElementName = "PlayerMove")]
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
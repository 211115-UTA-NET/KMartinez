using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSConsoleApp.UI.Dtos
{
    public class Round
    {
        public DateTimeOffset Date { get; set; }
        public int Move Player1{ get; set; }
        public int Move Player2 { get; set;}
        public int Result { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatty.Models
{
    // Clasa pentru mesajele utilizatorului
    public class UserMessage
    {
        // Numele utilizatorului care a trimis mesajul
        public string Username { get; set; }

        // Conținutul mesajului
        public string Message { get; set; }

        // Indicator dacă mesajul este al utilizatorului curent sau nu
        public bool CurrentUser { get; set; }

        // Data și ora la care a fost trimis mesajul
        public DateTime DateSent { get; set; }
    }
}

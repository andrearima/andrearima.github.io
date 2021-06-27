using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima
{
    public class Contato
    {
        public Contato(string email, string celular, string whatsApp, string urlLinkedIn)
        {
            Email = email;
            Celular = celular;
            WhatsApp = whatsApp;
            UrlLinkedIn = urlLinkedIn;
        }

        public string Email { get; private set; }
        public string Celular { get; private set; }
        public string WhatsApp { get; private set; }
        public string UrlLinkedIn { get; private set; }
    }
}

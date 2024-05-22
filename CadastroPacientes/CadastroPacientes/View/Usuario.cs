using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPacientes.View
{
    public class Usuario
    {
        private string username;
        private string password;

        public Usuario()
        {
            this.Username = username;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}

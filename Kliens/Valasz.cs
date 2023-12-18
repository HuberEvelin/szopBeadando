using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    internal class Valasz
    {
        private int error;

        public int Error
        {
            get { return error; }
            set { error = value; }
        }


        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        private List<Felhasznalo> users;

        public List<Felhasznalo> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}

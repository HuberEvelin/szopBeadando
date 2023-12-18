using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    internal class LoginValasz
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


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

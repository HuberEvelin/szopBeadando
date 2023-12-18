using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    internal class PostaResponse
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


        private List<Uzenet> tartalom;

        public List<Uzenet> Tartalom
        {
            get { return tartalom; }
            set { tartalom = value; }
        }
    }
}

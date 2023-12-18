using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    internal class Uzenet
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int kuldo_id;

        public int Kuldo_id
        {
            get { return kuldo_id; }
            set { kuldo_id = value; }
        }

        private int cimzett_id;

        public int Cimzett_id
        {
            get { return cimzett_id; }
            set { cimzett_id = value; }
        }

        private int uzenet_id;

        public int Uzenet_id
        {
            get { return uzenet_id; }
            set { uzenet_id = value; }
        }

    }
}

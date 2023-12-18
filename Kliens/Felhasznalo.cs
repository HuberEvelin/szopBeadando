using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    public class Felhasznalo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string felhasznalonev;

        public string Felhasznalonev
        {
            get { return felhasznalonev; }
            set { felhasznalonev = value; }
        }


        private string jelszo;

        public string Jelszo
        {
            get { return jelszo; }
            set { jelszo = value; }
        }

        public override string ToString()
        {
            string szoveg;
            szoveg = "Id: " + this.Id + "Név: " + this.Felhasznalonev + "Jelszó: " + this.Jelszo;
            return szoveg;
        }
    }
}

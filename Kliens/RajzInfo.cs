using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoV3.Kliens
{
    internal class RajzInfo
    {
        public int Id { get; set; }
        public string RajzNev { get; set; }
        public string Rajz { get; set; }

        public RajzInfo(int id, string rajzNev, string rajz)
        {
            Id = id;
            RajzNev = rajzNev;
            Rajz = rajz;
        }

        public override string ToString()
        {
            return RajzNev;
        }
    }
}

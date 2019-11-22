using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLApp
{
    class Rendezo
    {
        int id;
        string nev;
        DateTime szulDatum;
        string szarmazas;

        public Rendezo(int id, string nev, DateTime szulDatum, string szarmazas)
        {
            this.id = id;
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.szarmazas = szarmazas;
        }

        public int Id { get => id;}
        public string Nev { get => nev; set => nev = value; }
        public DateTime SzulDatum { get => szulDatum; set => szulDatum = value; }
        public string Szarmazas { get => szarmazas; set => szarmazas = value; }

        public override string ToString()
        {
            return this.Nev;
        }
    }
}

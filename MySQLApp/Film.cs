using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLApp
{
    class Film
    {
        int id;
        string cim;
        DateTime kiadas;
        int hossz;
        int rendezok_id;

        public Film(int id, string cim, DateTime kiadas, int hossz, int rendezok_id)
        {
            this.id = id;
            this.cim = cim;
            this.kiadas = kiadas;
            this.hossz = hossz;
            this.rendezok_id = rendezok_id;
        }

        public int Id { get => id; set => id = value; }
        public string Cim { get => cim; set => cim = value; }
        public DateTime Kiadas { get => kiadas; set => kiadas = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public int Rendezok_id { get => rendezok_id; set => rendezok_id = value; }

        public override string ToString()
        {
            return cim + " " + kiadas.ToString("yyyy-MM-dd") + " " + hossz + " perc";
        }
    }
}

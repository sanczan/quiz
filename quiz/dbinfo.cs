using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SQLite;

namespace quiz
{
    class dbinfo    //stworzenie zmiennych
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nazwa_quizu { get; set; }
        public int numer_pytania { get; set; }
        public string pytanie { get; set; }
        public string odpowiedz_1 { get; set; }
        public string odpowiedz_2 { get; set; }
        public string odpowiedz_3 { get; set; }
        public string odpowiedz_4 { get; set; }
        public string poprawna_odpowiedz { get; set; }

        public dbinfo() { }     //funkcja 'pusta'

        public dbinfo(string n_q)   //w zaleznosci ile poda sie argumentow, to taka funkcja sie wykona
        {
            nazwa_quizu = n_q;
        }

        public dbinfo(string o1, string o2)
        {
            odpowiedz_1 = o1;
            odpowiedz_2 = o2;
        }


        public dbinfo(string n_q, int n_p, string p, string o1, string o2, string o3, string o4, string p_o)
        {
            nazwa_quizu = n_q;
            numer_pytania = n_p;
            pytanie = p;
            odpowiedz_1 = o1;
            odpowiedz_2 = o2;
            odpowiedz_3 = o3;
            odpowiedz_4 = o4;
            poprawna_odpowiedz = p_o;
        }
    }
}

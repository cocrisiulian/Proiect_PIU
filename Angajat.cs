using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiunea_Angajatilor_unei_Firme
{
    internal class Angajat
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Adresa { get; set; }
        public string NumarTelefon { get; set; }
        public string Pozitie { get; set; }
        public DateTime DataAngajarii { get; set; }
        public float Salariu { get; set; }
        public void AfisareDetalii()
        {
            Console.WriteLine("Nume: " + Nume);
            Console.WriteLine("Prenume: " + Prenume);
            Console.WriteLine("Data nasterii: " + DataNasterii.ToShortDateString());
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("Numar de telefon: " + NumarTelefon);
            Console.WriteLine("Pozitie: " + Pozitie);
            Console.WriteLine("Data angajarii: " + DataAngajarii.ToShortDateString());
            Console.WriteLine("Salariu: " + Salariu);
        }
        public void AdaugaAngajat(List<Angajat> listaAngajati, string nume, string prenume, DateTime dataNasterii, string adresa, string numarTelefon, string pozitie, DateTime dataAngajarii, float salariu)
        {
            Angajat angajat = new Angajat()
            {
                Nume = nume,
                Prenume = prenume,
                DataNasterii = dataNasterii,
                Adresa = adresa,
                NumarTelefon = numarTelefon,
                Pozitie = pozitie,
                DataAngajarii = dataAngajarii,
                Salariu = salariu
            };

            listaAngajati.Add(angajat);
        }
        public void ActualizareAngajat(string nume, string prenume, Angajat angajatActualizat)
        {
            for (int i = 0; i < listaAngajati.Count; i++)
            {
                if (listaAngajati[i].Nume == nume && listaAngajati[i].Prenume == prenume)
                {
                    listaAngajati[i] = angajatActualizat;
                    break;
                }
            }
        }
    }
}
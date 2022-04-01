//Olari Ionut-Adrian Grupa:3133A


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieAgendaPersoane
{
    public class Agenda
    {

        //constante
        private const int aceeasivarsta = 0;
        private const int persoana_curenta_maimare = -1;
        private const int persoana_curenta_maimica = 1;
        private const char SEP_NumePrenume = ' ';
        private const char SEP_PrincipalFisier = ',';

        //date membre publice

        public string NR_Telefon;
        public string Adresa_e_mail;
        public DateTime Data_Nasterii;
        private string datanasterii;
        private string adresaemail;
        private Grup program;
        private Provenienta programM;


        //proprietati auto-implementate

        public DateTime Actualizare_Data { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Provenienta provenienta { get; set; }
        public Grup grup { get; set; }


        public string Nume_Complet
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }

        public string getData_Nasterii
        {
            get
            {
                return Data_Nasterii.ToString("dd/MM/yyyy");
            }
        }



        //Constructor implicit;

        public Agenda()
        {
            this.Nume = string.Empty;
            this.Prenume = string.Empty;
            this.Adresa_e_mail = string.Empty;
            this.Data_Nasterii = DateTime.Now;
            this.NR_Telefon = string.Empty;
            provenienta = Provenienta.Romania;
            grup = Grup.Prieteni;
            Actualizare_Data = DateTime.Now;
        }

        //Constructor cu parametri

        public Agenda(string _nume, string _prenume, DateTime _data_nastere, string _nr_telefon, string _adresa_e_mail) //Grup _grup, Provenienta _provenienta
        {
            this.Nume = _nume;
            this.Prenume = _prenume;
            this.Adresa_e_mail = _adresa_e_mail;
            this.NR_Telefon = _nr_telefon;
            this.Data_Nasterii = _data_nastere;
          //  grup = _grup;
           // provenienta = _provenienta;
           // Actualizare_Data = DateTime.Now;

        }

        //Constructor cu parametri string

        public Agenda(string sir)
        {
            string[] buf = sir.Split(',');
            this.Nume = buf[0];
            this.Prenume = buf[1];
            this.Data_Nasterii = Convert.ToDateTime(buf[2]);
            this.NR_Telefon = buf[3];
            this.Adresa_e_mail = buf[4];
          //  grup = (Grup)Enum.Parse(typeof(Grup), buf[5]);
          //  provenienta = (Provenienta)Enum.Parse(typeof(Provenienta), buf[6]);
           // Actualizare_Data = DateTime.Parse(buf[7]);


        }

        public Agenda(string nume, string prenume, string datanasterii, string nr_telefon, string adresaemail) // Grup program, Provenienta programM
        {
            this.Nume = nume;
             this.Prenume = prenume;
            this.datanasterii = datanasterii;
            this.NR_Telefon = nr_telefon;
            this.adresaemail = adresaemail;
          //  this.program = program;
           // this.programM = programM;
        }

        //Data curenta

        public string DataCurenta()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        //Varsta
        //Compararea varstei a doua persoane din agenda

        //Functia de modificare a unei persoane din Agenda

        public void CautasiModifica(string numeNOU, string prenumeNOU)
        {
            Nume = numeNOU;
            Prenume = prenumeNOU;
        }

        //Afisare NumeComplet

        public string NumeComplet()
        {
            return String.Format("\t{1}{0}{0}{2}", SEP_NumePrenume, Nume, Prenume);

        }

        //Afisare date in cosola

        public string ConversielaSir()
        {
            return String.Format("{0,-12}{1,8}{2,20}{3,21}{4,29}{5,15}{6,26}", Nume, Prenume, Data_Nasterii.ToString("dd/MM/yyyy"), NR_Telefon, Adresa_e_mail, grup, provenienta);

        }

        //Afisare date in Fisier

        public string ConversielaSirFisier()
        {
            string sir = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}", SEP_PrincipalFisier, Nume, Prenume, Data_Nasterii.ToString("dd/MM/yyyy"), NR_Telefon, Adresa_e_mail, grup, provenienta, Actualizare_Data);
            return sir;
        }
    }

}

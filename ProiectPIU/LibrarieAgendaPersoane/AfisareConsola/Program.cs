﻿using LibrarieAgendaPersoane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisareConsola
{
    class Program
    {
      /*  static void Main(string[] args)
        {

            Agenda Agenda = new Agenda();
            int i;
            int nrAgenda;

            string optiune;
            do
            {
                Console.WriteLine("A.Listare Agenda");
                Console.WriteLine("B.Adauga in agenda");
                Console.WriteLine("C.Modificare nume");
                Console.WriteLine("D.XXXXXXXXXXX");
                Console.WriteLine("E.XXXXXXXXXX");
                Console.WriteLine("X.Inchide programul");
                Console.WriteLine("Alegeti o optiune");

                optiune = Console.ReadLine();
      
                switch (optiune.ToUpper())
                {
                    case "A":
                        AfisareAgenda(Agenda);
                        break;
                    case "B":
                        Agenda a = Citiretastatura();
                       // Agenda[nrAgenda] = a;
                        //nrAgenda++;
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    case "E":
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();
        }
        public static void AfisareAgenda(Agenda Agenda)
        {
            Console.WriteLine("----------AfisareAgenda-----");
            string info = String.Format("{0,-12}{1,8}{2,20}{3,21}{4,29}{5,15}{6,26}",Agenda.Nume,Agenda.Prenume,Agenda.Data_Nasterii.ToString("dd/MM/yyyy"),Agenda.NR_Telefon,Agenda.Adresa_e_mail,Agenda.grup,Agenda.provenienta);

        }

        public static Agenda Citiretastatura()
        {
            Console.WriteLine("Introduceti numele:");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele:");
            string Prenume = Console.ReadLine();

            Console.WriteLine("Introduceti data nasterii:");
            string datanasterii = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de telefon:");
            string nr_telefon = Console.ReadLine();

            Console.WriteLine("Introduceti adresa de email:");
            string adresaemail = Console.ReadLine();

            Console.WriteLine("Alege grupul:");
            Console.WriteLine("0 - Prieteni \n " +
                "1 - Serviciu \n" +
                "2 - Familie \n" +
                "3- Scoala \n");

            Console.WriteLine("Alege tara de provenienta:");
            Console.WriteLine("0 - Romania \n" +
                "1 - Spania \n" +
                "2 - Belgia \n" +
                "3 - Germania \n" +
                "4 - Franta \n" +
                "5 - Anglia \n");
            int optiune = Convert.ToInt32(Console.ReadLine());
            Grup program = (Grup)optiune;
            Provenienta programM = (Provenienta)optiune;

            Console.WriteLine("Introduceti persoana cu tot cu date:");
            string sir = Console.ReadLine();

            // Agenda a = new Agenda(Nume, Prenume, datanasterii, nr_telefon, adresaemail, program, programM);
            Agenda a = new Agenda(sir);

            return a;
        }

    } /*
      }


  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieAgendaPersoane
{
    class Program
    {
        static void Main(string[] args)
        {

          /*  Agenda Agenda = new Agenda();
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
                       //  Agenda[nrAgenda] = a;
                       // nrAgenda++;
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
            } while (optiune.ToUpper() != "X"); */
           



            bool gasit;
            for (int i = 65; i < 91; i++)
            {
                gasit = false;

                char a, b;
                for (int j = 0; j < args.Length; j++)
                {
                    b = Convert.ToChar(i);
                    a = args[j].First();
                    //Console.WriteLine("{0},{1}", a, b);
                    if (a == b || a == b + 32)
                    {
                        Console.Write(args[j] + " ");
                        gasit = true;
                    }

                }
                if (gasit == true)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
        public static void AfisareAgenda(Agenda Agenda)
        {
            Console.WriteLine("\n----------AfisareAgenda-----");
            string info = string.Format("{0} {1} {2} {3} {4} {5}", Agenda.Nume, Agenda.Prenume, Agenda.Data_Nasterii, Agenda.NR_Telefon, Agenda.Adresa_e_mail);

            Console.WriteLine(info);
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

          /*  Console.WriteLine("Alege grupul:");
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
            Provenienta programM = (Provenienta)optiune; */

           // Console.WriteLine("Introduceti persoana cu tot cu date:");
          //  string sir = Console.ReadLine();

            Agenda a = new Agenda(Nume, Prenume, datanasterii, nr_telefon, adresaemail);
           // Agenda a = new Agenda(sir);

            return a;
        }

    }
}

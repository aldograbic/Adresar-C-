using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbornikUnos;
            List<Kontakt> kontakti = new List<Kontakt>();

            do
            {
                Console.WriteLine("1) Dodavanje novog kontakta");
                Console.WriteLine("2) Ažuriranje postojećeg kontakta");
                Console.WriteLine("3) Ispis svih kontakata");
                Console.WriteLine("4) Ispis svih kontakata u određenom gradu");
                Console.WriteLine("5) Prekid rada programa");

                Console.WriteLine("");
                Console.Write("Unesite broj sa izbornika: ");
                int.TryParse(Console.ReadLine(), out izbornikUnos);
                switch (izbornikUnos)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("");
                            Console.Write("Ime: ");
                            string ime = Console.ReadLine();
                            Console.Write("Prezime: ");
                            string prezime = Console.ReadLine();
                            Console.Write("Ulica: ");
                            string ulica = Console.ReadLine();
                            Console.Write("Kućni broj: ");
                            int kucniBroj = int.Parse(Console.ReadLine());
                            Console.Write("Grad: ");
                            string grad = Console.ReadLine();

                            Kontakt noviKontakt = new Kontakt(ime, prezime, ulica, kucniBroj, grad);
                        
                            kontakti.Add(noviKontakt);
                            Console.WriteLine("");
                            Console.WriteLine("Kontakt {0} {1} je uspješno dodan/a.", noviKontakt.Ime, noviKontakt.Prezime);
                            Console.WriteLine("");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Pogrešan unos!");
                            Console.WriteLine("");
                        }
                        break;

                    case 2:
                        for (int i = 0; i < kontakti.Count; i++)
                        {
                            Console.WriteLine("Ime: {0}", kontakti[i].Ime);
                            Console.WriteLine("Prezime: {0}", kontakti[i].Prezime);
                            Console.WriteLine("Ulica: {0}", kontakti[i].Ulica);
                            Console.WriteLine("Kućni broj: {0}", kontakti[i].KucniBroj);
                            Console.WriteLine("Grad: {0}", kontakti[i].Grad);
                            Console.WriteLine("");
                            Console.Write("Želite li ažurirati kontakt {0}: ", kontakti[i].Ime);
                            string unosDaNe = Console.ReadLine();
                            if(unosDaNe == "da")
                            {
                                try
                                {
                                    Console.Write("Novo ime: ");
                                    string novoIme = Console.ReadLine();
                                    Console.Write("Novo prezime: ");
                                    string novoPrezime = Console.ReadLine();
                                    Console.Write("Nova ulica: ");
                                    string novaUlica = Console.ReadLine();
                                    Console.Write("Novi kućni broj: ");
                                    int noviKucniBroj = int.Parse(Console.ReadLine());
                                    Console.Write("Novi grad: ");
                                    string noviGrad = Console.ReadLine();

                                    kontakti[i].Ime = novoIme;
                                    kontakti[i].Prezime = novoPrezime;
                                    kontakti[i].Ulica = novaUlica;
                                    kontakti[i].KucniBroj = noviKucniBroj;
                                    kontakti[i].Grad = noviGrad;

                                    Console.WriteLine("");
                                    Console.WriteLine("Uspješno ažuriran kontakt!");
                                    Console.WriteLine("");
                                }
                                catch(FormatException)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Pogrešan unos!");
                                    Console.WriteLine("");
                                }
                                
                            }
                            else if(unosDaNe == "ne")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Nema promjene!");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Unesite 'da' ili 'ne'!");
                                Console.WriteLine("");
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Podaci o kontaktima");
                        Console.WriteLine("");
                        if (kontakti.Count != 0)
                        {
                            foreach (var kontakt in kontakti)
                            {
                                Console.WriteLine("Ime: {0}", kontakt.Ime);
                                Console.WriteLine("Prezime: {0}", kontakt.Prezime);
                                Console.WriteLine("Ulica: {0}", kontakt.Ulica);
                                Console.WriteLine("Kućni broj: {0}", kontakt.KucniBroj);
                                Console.WriteLine("Grad: {0}", kontakt.Grad);
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nema unesenog kontakta!");
                            Console.WriteLine("");
                        }
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.Write("Unesite grad: ");
                        string gradUnos = Console.ReadLine();
                        for (int i = 0; i < kontakti.Count; i++)
                        {
                            if (kontakti[i].Grad == gradUnos)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Kontakti u gradu {0}", gradUnos);
                                Console.WriteLine("");
                                Console.WriteLine("Ime: {0}", kontakti[i].Ime);
                                Console.WriteLine("Prezime: {0}", kontakti[i].Prezime);
                                Console.WriteLine("Ulica: {0}", kontakti[i].Ulica);
                                Console.WriteLine("Kućni broj: {0}", kontakti[i].KucniBroj);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Kraj programa!");
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Izaberite broj sa izbornika!");
                        Console.WriteLine("");
                        break;
                }
                
            }
            while (izbornikUnos != 5) ;
            Console.ReadKey();

        }
    }
}

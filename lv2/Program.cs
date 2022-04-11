using System;
using System.IO;

namespace lv2
{
    class Program
    {
        static void Main() {  }
        
        static void RunExercise1()
        {
            int brojac = 0;
            Console.WriteLine("Unesite broj kontakata: ");
            int contactCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite naziv datoteke: ");
            string fileName = Console.ReadLine();
            Contact[] kontakti = new Contact[contactCount];
            for (int i = 0; i < contactCount; i++)
            {
                kontakti[i] = new Contact("a","a","a","a");
            }
            do
            {
                for (int i = 0; i < contactCount; i++)
                {
                    kontakti[i].Ime = Console.ReadLine();
                    kontakti[i].Prezime = Console.ReadLine();
                    kontakti[i].Broj = Console.ReadLine();
                    kontakti[i].Email = Console.ReadLine();
                    if (EmailHelper.provjera(kontakti[i].Email) == true) { brojac += 1; }
                }
            } while (brojac > contactCount);
            for(int i = 0; i < contactCount; i++)
            {
                if (EmailHelper.provjeraFerit(kontakti[i].Email) == true)
                {
                    Console.WriteLine(kontakti[i].Ispis());

                }
            }
        }
        static void RunExercise2()
        {
            Vector v1 = new Vector(2, 3, 4);
            Vector v2 = new Vector(4, 2, 3);
            Vector v3 = new Vector();
            v3 = v1 - v2;
            Console.WriteLine(v3.Ispis());
            v3 = v1 + v2;
            Console.WriteLine(v3.Ispis());
            Vector v4 = new Vector();
            v4 = RandomExtension.Generate(10);
            Console.WriteLine(v4.Ispis());
        }
        static void RunExercise3()
        {
            Termin alilovic1 = new Termin("Alilovic", new DateTime(2020, 2, 19), new TimeSpan(2, 0, 0));
            Termin alilovic2 = new Termin("Alilovic", new DateTime(2020, 2, 23), new TimeSpan(2, 0, 0));
            Termin alilovic3 = new Termin("Alilovic", new DateTime(2020, 2, 29), new TimeSpan(2, 0, 0));
            Termin alilovic4 = new Termin("Alilovic", new DateTime(2020, 3, 31), new TimeSpan(2, 0, 0));
            Termin alilovic5 = new Termin("Alilovic", new DateTime(2020, 2, 4), new TimeSpan(2, 0, 0));
            Termin alilovic6 = new Termin("Alilovic", new DateTime(2020, 2, 25), new TimeSpan(2, 0, 0));
            Termin[] termini = new Termin[6] { alilovic1, alilovic6, alilovic2, alilovic3, alilovic4, alilovic5 };
            
        }
    }
}

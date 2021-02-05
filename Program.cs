using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Adi = "Python";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = "86";

            Kurs kurs2 = new Kurs();
            kurs2.Adi = "C#";
            kurs2.Egitmeni = "Mehmet Kızıltaş";
            kurs2.IzlenmeOrani = "100";

            Kurs kurs3 = new Kurs();
            kurs3.Adi = "Java";
            kurs3.Egitmeni = "Ensar Uç";
            kurs3.IzlenmeOrani = "77";

            Kurs kurs4 = new Kurs();
            kurs4.Adi = "JavaScript";
            kurs4.Egitmeni = "Fikret Demirbağ";
            kurs4.IzlenmeOrani = "91";

            //Console.WriteLine(kurs1.Adi + ": " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Adi + ": " + kurs.Egitmeni);
                //Console.WriteLine(kurs.IzlenmeOrani);
            }

            Console.ReadKey();
        }

        class Kurs
        {
            public string Adi { get; set; }

            public string Egitmeni { get; set; }

            public string IzlenmeOrani { get; set; }
        }
    }
}

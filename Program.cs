using System;
namespace kirjalista;

class Program
{
    static void Main(string[] args)
    {
        List<Kirja> kirjat = new List<Kirja>();

        //Tehdään käyttäjälle valikkorakenne.
        //1. Lisää kirja.
        //2. Poista kirja.
        //3. Listaa kirjat.

        //Ohjelma jatkuu kunnes käyttäjä syöttää '0'.

        //Kun saatte tämän toimimaan, muuttakaa rakenteeksi switch - case.
    
        while (true)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Valitse:\n1. Lisää kirja\n2. Poista kirja\n3. Listaa kirjat\n0. Lopeta\n");

            //Luetaan käyttäjän syöte.
            string syote = Console.ReadLine();

            //Toimitaan käyttäjän syötteen mukaisesti.
            if (syote == "1")
            {
                Console.WriteLine("Kirjan lisääminen.");
                //Toteutetaan tänne LisääKirja -metodin kutsu.
                LisaaKirja(kirjat);
            }
            else if (syote == "2")
            {
                Console.WriteLine("Kirjan poistaminen.");
            }
            else if (syote == "3")
            {
                Console.WriteLine("Kirjojen listaaminen.");
            }
            else if (syote == "0")
            {
                Console.WriteLine("HeiHei!");
                break;
            }
            else
            {
                Console.WriteLine("Kelpaamaton syöte.");
            }
        }
    }

    public static void LisaaKirja(List<Kirja> kirjat)
    {
        //Laitetaan tänne koodi, joka kysyy käyttäjältä kirjan nimen, kirjailijan, vuoden ja genren.
        //Kun käyttäjältä on kysytty nämä tiedot, kutsutaan niillä tiedoilla Kirjan konstruktoria.
        //kirjat.Add(täällä kutsutaan konstruktoria)
        
    }

    //Poista kirja metodi.

    //Listaa kirjat metodi foreachilla.


    

}


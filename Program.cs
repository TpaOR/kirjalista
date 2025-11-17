namespace kirjalista;

/*
Lisätä kirjoja kirjalistalle 
    Tarvitaan siis lista, johon voidaan tallentaa Kirja -luokan olioita.
    Eli luodaan luokka Kirja, jolla on alla olevat ominaisuudet.
Kirjalla on vähintään nimi, kirjoittaja, julkaisuvuosi ja genre. 
    Kirjan pitää siis olla olio.
Poistaa kirjoja listalta 
    Pitää tehdä metodi PoistaKirja().
    Sitä ennen on varmaan pitänyt tehdä myös metodi LisaaKirja().
Näyttää kaikki kirjat 
    Metodi TulostaKaikkiKirjat().
Näyttää kirjat genren mukaan
    Metodi TulostaGenrenKirjat().
Etsiä kirjoja kirjoittajan tai nimen perusteella 
    Metodi TulostaKirjoittajanKirjat().
    Metodi TulostaNimella().

    Meillä on siis paljon metodeita, joista käyttäjä valitsee, mitä tehdään
    Tarvitaan siis jonkinlainen valikkorakenne pääohjelmaan.
(Valinnainen lisäominaisuus) Tallentaa ja ladata kirjalista tiedostosta 
*/

class Program
{
    static void Main(string[] args)
    {
        //Ensimmäisenä luodaan Kirja -luokka ja lista, johon voi tallentaa sen olioita.
        
        //Kerrotaan käyttäjällle, mitä valintoja hän voi tehdä.
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Toinen rivi");

    }
}

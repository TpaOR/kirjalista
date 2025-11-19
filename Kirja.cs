using System;

namespace kirjalista
{
  public class Kirja
  {
    private string nimi;
    public string kirjailija;

    public Kirja(string nimi, string kirjailija)
    {
        this.nimi = nimi;
        this.kirjailija = kirjailija;
    }

    public override string ToString()
    {
        return $"{nimi} - {kirjailija}";
    }

  }
}
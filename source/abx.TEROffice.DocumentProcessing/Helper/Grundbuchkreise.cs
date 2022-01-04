using System;
using System.Collections.Generic;
using System.Text;

namespace abx.TEROffice.DocumentProcessing.Helper
{
    public class Grundbuchkreise
    {
        private Dictionary<string, string> kreisDictionary = new Dictionary<string, string>();

        public Grundbuchkreise()
        {
            FillDictionary();
        }

        private void FillDictionary()
        {
            kreisDictionary.Add("201", "Adligenswil");
            kreisDictionary.Add("202", "Buchrain");
            kreisDictionary.Add("203", "Dierikon");
            kreisDictionary.Add("204", "Ebikon");
            kreisDictionary.Add("205", "Gisikon");
            kreisDictionary.Add("206", "Greppen");
            kreisDictionary.Add("207", "Honau");
            kreisDictionary.Add("208", "Horw");
            kreisDictionary.Add("209", "Kriens");
            kreisDictionary.Add("210", "Littau");
            kreisDictionary.Add("111", "Luzern linkes Ufer");
            kreisDictionary.Add("112", "Luzern rechtes Ufer");
            kreisDictionary.Add("211", "Malters");
            kreisDictionary.Add("212", "Meggen");
            kreisDictionary.Add("213", "Meierskappel");
            kreisDictionary.Add("214", "Root");
            kreisDictionary.Add("215", "Schwarzenberg");
            kreisDictionary.Add("216", "Udligenswil");
            kreisDictionary.Add("217", "Vitznau");
            kreisDictionary.Add("218", "Weggis");
            kreisDictionary.Add("301", "Aesch");
            kreisDictionary.Add("302", "Altwis");
            kreisDictionary.Add("303", "Ballwil");
            kreisDictionary.Add("304", "Emmen");
            kreisDictionary.Add("305", "Ermensee");
            kreisDictionary.Add("306", "Eschenbach");
            kreisDictionary.Add("307", "Gelfingen");
            kreisDictionary.Add("308", "Hämikon");
            kreisDictionary.Add("309", "Herlisberg");
            kreisDictionary.Add("310", "Hitzkirch");
            kreisDictionary.Add("311", "Hochdorf");
            kreisDictionary.Add("312", "Hohenrain");
            kreisDictionary.Add("313", "Inwil");
            kreisDictionary.Add("314", "Lieli");
            kreisDictionary.Add("315", "Mosen");
            kreisDictionary.Add("316", "Müswangen");
            kreisDictionary.Add("317", "Rain");
            kreisDictionary.Add("318", "Retschwil");
            kreisDictionary.Add("319", "Römerswil");
            kreisDictionary.Add("320", "Rothenburg");
            kreisDictionary.Add("321", "Schongau");
            kreisDictionary.Add("322", "Sulz");
            kreisDictionary.Add("501", "Alberswil");
            kreisDictionary.Add("502", "Altbüron");
            kreisDictionary.Add("503", "Altishofen");
            kreisDictionary.Add("401", "Beromünster");
            kreisDictionary.Add("504", "Buchs");
            kreisDictionary.Add("402", "Büron");
            kreisDictionary.Add("403", "Buttisholz");
            kreisDictionary.Add("505", "Dagmersellen");
            kreisDictionary.Add("601", "Doppleschwand");
            kreisDictionary.Add("506", "Ebersecken");
            kreisDictionary.Add("507", "Egolzwil");
            kreisDictionary.Add("404", "Eich");
            kreisDictionary.Add("602", "Entlebuch");
            kreisDictionary.Add("603", "Escholzmatt");
            kreisDictionary.Add("508", "Ettiswil");
            kreisDictionary.Add("509", "Fischbach");
            kreisDictionary.Add("604", "Flühli");
            kreisDictionary.Add("510", "Gettnau");
            kreisDictionary.Add("405", "Geuensee");
            kreisDictionary.Add("511", "Grossdietwil");
            kreisDictionary.Add("406", "Grosswangen");
            kreisDictionary.Add("407", "Gunzwil");
            kreisDictionary.Add("605", "Hasle");
            kreisDictionary.Add("512", "Hergiswil bei Willisau");
            kreisDictionary.Add("408", "Hildisrieden");
            kreisDictionary.Add("409", "Knutwil");
            kreisDictionary.Add("513", "Kottwil");
            kreisDictionary.Add("410", "Kulmerau");
            kreisDictionary.Add("514", "Langnau bei Reiden");
            kreisDictionary.Add("515", "Luthern");
            kreisDictionary.Add("606", "Marbach");
            kreisDictionary.Add("411", "Mauensee");
            kreisDictionary.Add("516", "Menznau");
            kreisDictionary.Add("517", "Nebikon");
            kreisDictionary.Add("412", "Neudorf");
            kreisDictionary.Add("413", "Neuenkirch");
            kreisDictionary.Add("414", "Nottwil");
            kreisDictionary.Add("415", "Oberkirch");
            kreisDictionary.Add("518", "Ohmstal");
            kreisDictionary.Add("519", "Pfaffnau");
            kreisDictionary.Add("416", "Pfeffikon");
            kreisDictionary.Add("520", "Reiden");
            kreisDictionary.Add("521", "Richenthal");
            kreisDictionary.Add("417", "Rickenbach");
            kreisDictionary.Add("522", "Roggliswil");
            kreisDictionary.Add("607", "Romoos");
            kreisDictionary.Add("418", "Ruswil");
            kreisDictionary.Add("419", "Schenkon");
            kreisDictionary.Add("420", "Schlierbach");
            kreisDictionary.Add("523", "Schötz");
            kreisDictionary.Add("608", "Schüpfheim");
            kreisDictionary.Add("421", "Schwarzenbach");
            kreisDictionary.Add("422", "Sempach");
            kreisDictionary.Add("423", "Sursee");
            kreisDictionary.Add("424", "Triengen");
            kreisDictionary.Add("524", "Uffikon");
            kreisDictionary.Add("525", "Ufhusen");
            kreisDictionary.Add("526", "Wauwil");
            kreisDictionary.Add("609", "Werthenstein");
            kreisDictionary.Add("527", "Wikon");
            kreisDictionary.Add("425", "Wilihof");
            kreisDictionary.Add("528", "Willisau-Land");
            kreisDictionary.Add("529", "Willisau-Stadt");
            kreisDictionary.Add("426", "Winikon");
            kreisDictionary.Add("427", "Wolhusen");
            kreisDictionary.Add("530", "Zell");
        }

        public string kreisBezeichnungHerleiten(string x)
        {
            string rückgabewert = "Kreisbezeichnung unbekannt für " + x;

            if (kreisDictionary.ContainsKey(x))
            {
                if (x == "520") //Ausnhame wegen gleicher Kreisnamen "Reiden" & "Langnau bei Reiden", bessere Lösung muss her
                {
                    rückgabewert = "Ausnahme bei Langnau bei Reiden & Reiden";
                }
                else
                {
                    rückgabewert = kreisDictionary[x];
                }
            }
            return rückgabewert;
        }

        Dictionary<string, string> GetDictionary()
        {
            return this.kreisDictionary;
        }
    }
}

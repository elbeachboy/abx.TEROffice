using System.Collections.Generic;

namespace abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten
{
    public class Dienstbarkeit
    {
        public string LastRechtBezeichnung { get; set; }
        public string LastRechId { get; set; }

        public string LastRechId2 { get; set; }

        public string LastRechIdGesamt { get; set; }

        public string Ereid { get; set; }

        public string Status { get; set; }

        public string Mutationsdatum { get; set; }

        public string Mutationsnummer { get; set; }

        public string LastRechtInhalt { get; set; }

        public string LastRechtInhaltZusatz { get; set; }

        public string Errichtungsdatum { get; set; }

        public string Betrag { get; set; }

        public List<Beziehung> Beziehungen { get; set; }

        public List<Belege> Belege { get; set; }

    }

    public class Beziehung
    {
        public string Status { get; set; }

        public string Gründungsdatum { get; set; }

        public string Gründungsnummer { get; set; }

        public string Grol { get; set; }

        public Person? Person { get; set; }

        public Grundstück? Grundstück { get; set; }
    }

    public class Grundstück
    {
        public string Status { get; set; }

        public string Status_Eigentümer { get; set; }

        public string Grundbuchnummer { get; set; }

        public string Grundstückid { get; set; }

        public string GrundstückIdMitGrundbuch { get; set; }
        
        public string Grundstückart { get; set; }

        public string Egrid { get; set; }

        public string Grundbuchname { get; set; }
    }

    public class Person
    {
        public string Id { get; set; }

        public string Niveau { get; set; }

        public string Status { get; set; }

        public string Typ { get; set; }

        public string Name { get; set; }

        public string Vorname { get; set; }

        public string Geburtsdatum { get; set; }

        public string LedigName { get; set; }

        public string Rufname { get; set; }

        public string Rechtsform { get; set; }

        public string Sitz { get; set; }

        public string Strasse { get; set; }

        public string Plz { get; set; }

        public string Ort { get; set; }

        public string Laenderkürzel { get; set; }

        public string Land { get; set; }

        public string Nationalitaet { get; set; }

        public string Geburtsort { get; set; }
    }

    public class Belege
    {
        public string Status { get; set; }

        public string DatumFormatUsa { get; set; }

        public string DatumFormatEu { get; set; }
        
        public string NummerMitWhitespace { get; set; }

        public string NummerOhneWhitespace { get; set; }

        public string Text { get; set; }
    }
}

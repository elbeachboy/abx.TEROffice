using abx.TEROffice.Data.Entities.Common.Auszug.Person;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Common.Personen
{
   public class Person
    {
        [XmlElement("ID")]
        public string Id { get; set; }

        [XmlElement("NEST-PID")]
        public string NestPersonenId { get; set; }

        [XmlElement("NIV")]
        public int Niveau { get; set; }

        [XmlElement("INHOCC")]
        public PersonDetail PersonDetail { get; set; }

        [XmlElement("STRASSE")]
        public string Strasse { get; set; }

        [XmlElement("LAND")]
        public string LandKürzel { get; set; }

        [XmlElement("LANDTXT")]
        public string LAND { get; set; }

        [XmlElement("PLZ")]
        public string Plz { get; set; }

        [XmlElement("ORT")]
        public string Ort { get; set; }

        [XmlElement("AHVNR")]
        public string AHVNummer { get; set; }

        [XmlElement("BERUF")]
        public string Beruf { get; set; }

        [XmlElement("ZIV")]
        public string ZivilstandCode { get; set; }

        [XmlElement("ZIVTXT")]
        public string Zivilstand { get; set; }

        [XmlElement("ANREDE")]
        public string Anrede { get; set; }

        [XmlElement("ZUSATZ")]
        public string Zusatz { get; set; }

        [XmlElement("NORH")]
        public string Norh { get; set; }

        [XmlElement("A1")]
        public string A1 { get; set; }

        [XmlElement("A2")]
        public string A2 { get; set; }

        [XmlElement("A3")]
        public string A3 { get; set; }

        [XmlElement("A4")]
        public string A4 { get; set; }

        [XmlElement("ADRZUS1")]
        public string Adresszusatz1 { get; set; }

        [XmlElement("ADRZUS2")]
        public string Adresszusatz2 { get; set; }

        [XmlElement("ADRZUS3")]
        public string Adresszusatz3 { get; set; }

        [XmlElement("ADRZUS4")]
        public string Adresszusatz4 { get; set; }

        [XmlElement("ADRZUS5")]
        public string Adresszusatz5 { get; set; }
    }
}

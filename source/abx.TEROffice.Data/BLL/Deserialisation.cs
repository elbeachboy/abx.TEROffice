using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities;
using abx.TEROffice.Data.Interfaces;

namespace abx.TEROffice.Data.BLL
{
    public class Deserialisation : IDeserialisation
    {
        private string _xmlFilePath;
        

        public Deserialisation(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public void Deserialisieren()
        {

            var serializer = new XmlSerializer(typeof(Auszuege));
            StreamReader reader = new StreamReader(_xmlFilePath);
            var auszuege = (Auszuege)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}

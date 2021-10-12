using System;
using System.IO;
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

        public Auszuege ErstelleAuszugObjekt()
        {
            StreamReader reader = LoadStreamReader();
            try
            {
                var serializer = new XmlSerializer(typeof(Auszuege));
                var auszug = (Auszuege)serializer.Deserialize(reader);
                return auszug;
            }
            catch (Exception e)
            {
                throw new DataReaderException(e.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private StreamReader LoadStreamReader() 
        {
            try 
            {
                return new StreamReader(_xmlFilePath); 
            } 
            catch (Exception e)
            {

                throw new DataReaderException(e.Message);
            } 
        }  
    }
}

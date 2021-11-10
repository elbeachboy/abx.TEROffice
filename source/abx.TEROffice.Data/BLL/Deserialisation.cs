using System;
using System.IO;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities;
using abx.TEROffice.Data.Interfaces;
using abx.TEROFfice.Library;

namespace abx.TEROffice.Data.BLL
{
    public class Deserialisation : IDeserialisation
    {
        
        public Auszuege CreateAuszugObjekt(string xmlFilePath)
        {
            StreamReader reader = LoadStreamReader(xmlFilePath);
            XmlSerializer serializer = LoadXmlSerializer();
            try
            {
                var auszug = (Auszuege)serializer.Deserialize(reader);
                return auszug;
            }
            catch (Exception e)
            {
                throw new TERofficeException(e.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private StreamReader LoadStreamReader(string xmlFilePath) 
        {
            try 
            {
                return new StreamReader(xmlFilePath); 
            } 
            catch (Exception e)
            {

                throw new TERofficeException("Sourcefile von TERRIS nicht vorhanden.");
            } 
        }

        private XmlSerializer LoadXmlSerializer() 
        {
            try 
            {
                return new XmlSerializer(typeof(Auszuege));
            } 
            catch (Exception e)
            {

                throw new TERofficeException(e.Message);
            } 
        }

    }
}

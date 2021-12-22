

using System;
using System.IO;
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel;

namespace abx.TEROffice.DataReader.BLL
{
    public class Deserialisation
    {
        
        public TERAuszuege DeserializeXml(string xmlFilePath)
        {
            StreamReader reader = LoadStreamReader(xmlFilePath);
            XmlSerializer serializer = LoadXmlSerializer();
            try
            {
                var auszug = (TERAuszuege)serializer.Deserialize(reader);
                return auszug;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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

                throw new Exception("Sourcefile von TERRIS nicht vorhanden.");
            } 
        }

        private XmlSerializer LoadXmlSerializer() 
        {
            try 
            {
                return new XmlSerializer(typeof(TERAuszuege));
            } 
            catch (Exception e)
            {

                throw new Exception(e.Message);
            } 
        }

    }
}

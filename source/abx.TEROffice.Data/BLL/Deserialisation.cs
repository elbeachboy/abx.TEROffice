using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public Auszuege ErstelleAuszugObjekt()
        {
            StreamReader reader = new StreamReader(_xmlFilePath);
            try
            {
                var serializer = new XmlSerializer(typeof(Auszuege));
                var auszug = (Auszuege)serializer.Deserialize(reader);
                return auszug;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                reader.Close();
            }
           
            
            
        }
    }
}

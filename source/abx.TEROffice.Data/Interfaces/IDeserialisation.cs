using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.Data.Entities;

namespace abx.TEROffice.Data.Interfaces
{
    public interface IDeserialisation
    {
        Auszuege CreateAuszugObjekt(string xmlFilePath);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel;

namespace abx.TEROffice.DataReader.Interface
{
    public interface IData
    {
        Grundbuchauszug GetAuszug(string xmlFilePath);
    }
}

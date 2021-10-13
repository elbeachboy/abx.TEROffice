using abx.TEROffice.Main.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace abx.TEROffice.Main.Interfaces
{
    public interface ILibrary
    {
        BereinigungsBelegHinweisHelper GetBereinigungsBelegHinweis();

        CharHelper GetCharHelper();

        ContextHelper GetContextHelper();
        
        StatusHelper GetStatusHelper();

        FilePathHelper GetFilePathHelper();

        FontFormatHelper GetFontFormatHelper();

        DateFOrmatingHelper GetDateFormatingHelper(string date);

        GrundbuchVerwalterHelper GetGrundbuchVerwalterHelper();

        BrundbuchKreisHelper GetBrundbuchKreisHelper();

    }
}

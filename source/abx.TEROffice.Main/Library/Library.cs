using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.Main.Interfaces;

namespace abx.TEROffice.Main.Library
{
    public class Library : ILibrary
    {
        public BereinigungsBelegHinweisHelper GetBereinigungsBelegHinweis()
        {
            return new BereinigungsBelegHinweisHelper();
        }

        public CharHelper GetCharHelper()
        {
            return new CharHelper();
        }

        public ContextHelper GetContextHelper()
        {
            return new ContextHelper();
        }

        public StatusHelper GetStatusHelper()
        {
            return new StatusHelper();
        }

        public FilePathHelper GetFilePathHelper()
        {
            return new FilePathHelper();
        }

        public FontFormatHelper GetFontFormatHelper()
        {
            return new FontFormatHelper();
        }

        public DateFOrmatingHelper GetDateFormatingHelper(string date)
        {
            return new DateFOrmatingHelper();
        }

        public GrundbuchVerwalterHelper GetGrundbuchVerwalterHelper()
        {
            return new GrundbuchVerwalterHelper();
        }

        public BrundbuchKreisHelper GetBrundbuchKreisHelper()
        {
            return new BrundbuchKreisHelper();
        }
    }
}

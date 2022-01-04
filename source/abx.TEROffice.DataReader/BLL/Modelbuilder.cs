

using System.Collections.Generic;
using abx.TEROffice.DataReader.Businessmodel;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DataReader.Datamodel;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU;
using abx.TEROffice.DataReader.Datamodel.Shared.BEL;
using abx.TEROffice.DataReader.Datamodel.Shared.BEZ;
using abx.TEROffice.DataReader.Datamodel.Shared.PERSON;

namespace abx.TEROffice.DataReader.BLL
{
    public class Modelbuilder
    {
        public Grundbuchauszug FillModel(TERAuszug auszug)
        {
            var grundbuchauszug = new Grundbuchauszug();
            grundbuchauszug.Grundstueck = new Grundstück
            {
                Status = auszug.GRU.GRUNDST.ST,
                Status_Eigentümer = auszug.GRU.GRUNDST.ST_EIG,
                Grundbuchnummer = auszug.GRU.GRUNDST.GRGB,
                Grundstückid = auszug.GRU.GRUNDST.GRID,
                Grundstückart = auszug.GRU.GRUNDST.GRART,
                Egrid = auszug.GRU.GRUNDST.EGRID_FOR_KSA,
                Grundbuchname = auszug.GRU.GRUNDST.GRGBTXT
            };

            var listOfDienstbarkeiten = new List<Dienstbarkeit>();

            foreach (var dbk in auszug.DBK.Lroccs)
            {
                var dienstbarkeit = new Dienstbarkeit
                {
                    LastRechtBezeichnung = dbk.LRLR,
                    LastRechId = dbk.LRID1,
                    LastRechId2 = dbk.LRID2,
                    LastRechIdGesamt = dbk.LRIDTXT,
                    Ereid = dbk.EREID_FOR_KSA,
                    Status = dbk.ST,
                    Mutationsdatum = dbk.INHOCC.MDT,
                    Mutationsnummer = dbk.INHOCC.MNR,
                    LastRechtInhalt = dbk.INHOCC.LRINH,
                    LastRechtInhaltZusatz = dbk.INHOCC.LRINH1,
                    Errichtungsdatum = dbk.INHOCC.ERIDAT,
                    Betrag = dbk.INHOCC.BETR,
                    Beziehungen = FillBeziehungen(dbk.BEZ.BEZOCC),
                    Belege = FillBelege(dbk.BEL.BELOCC)
                };
                listOfDienstbarkeiten.Add(dienstbarkeit);
            }

            grundbuchauszug.Dienstbarkeiten = listOfDienstbarkeiten;

            return grundbuchauszug;
        }

        private List<Beziehung> FillBeziehungen(List<BEZOCC> listOfBezoccs)
        {
            var listOfRelations = new List<Beziehung>();
            foreach (var bez in listOfBezoccs)
            {
                var beziehung = new Beziehung
                {
                    Status = bez.ST,
                    Gründungsdatum = bez.GDTX,
                    Gründungsnummer = bez.GNR,
                    Grol = bez.GROL,
                    Grundstück = FillGrundstueck(bez.GRUNDST),
                    Person = FillPerson(bez.PERSON)
                };
                listOfRelations.Add(beziehung);
            }

            return listOfRelations;
        }

        private List<Belege> FillBelege(List<BELOCC> listOfBeloccs)
        {
            var listOfBelege = new List<Belege>();
            foreach (var bel in listOfBeloccs)
            {
                var beleg = new Belege()
                {
                    Status = bel.ST,
                    DatumFormatUsa = bel.DTX,
                    DatumFormatEu = bel.DT,
                    NummerMitWhitespace = bel.NR,
                    NummerOhneWhitespace = bel.NRT,
                    Text = bel.TXT
                };
                listOfBelege.Add(beleg);
            }

            return listOfBelege;
        }

        private Person FillPerson(PERSON pers)
        {
            if (pers != null)
            {
                var person = new Person
                {
                    Id = pers.ID,
                    Niveau = pers.NIV,
                    Status = pers.INHOCC.ST,
                    Typ = pers.INHOCC.TYP,
                    Name = pers.INHOCC.NAME,
                    Vorname = pers.INHOCC.VORNAME,
                    Geburtsdatum = pers.INHOCC.GDAT,
                    LedigName = pers.A3,
                    Rufname = pers.INHOCC.RUFNAME,
                    Rechtsform = pers.INHOCC.RFORMTXT,
                    Sitz = pers.INHOCC.SITZ,
                    Strasse = pers.STRASSE,
                    Plz = pers.PLZ,
                    Ort = pers.ORT,
                    Land = pers.LANDTXT,
                    Laenderkürzel = pers.LAND,
                    Nationalitaet = pers.INHOCC.NATIOTXT,
                    Geburtsort = pers.BORT
                };
                return person;
            }
            else
            {
                return new Person();
            }
        }

        private Grundstück FillGrundstueck(GRUNDST grundst)
        {
            if (grundst != null)
            {
                var grundstueck = new Grundstück()
                {
                    Status = grundst.ST,
                    Status_Eigentümer = grundst.ST_EIG,
                    Grundbuchnummer = grundst.GRGB,
                    Grundstückid = grundst.GRID,
                    GrundstückIdMitGrundbuch = grundst.GRIDTXT,
                    Grundstückart = grundst.GRART,
                    Egrid = grundst.EGRID_FOR_KSA,
                    Grundbuchname = grundst.GRGBTXT
                };

                return grundstueck;
            }
            else
            {
                return new Grundstück();
            }


        }
    }
}

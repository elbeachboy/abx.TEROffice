

using System.Collections.Generic;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU;
using abx.TEROffice.DataReader.Datamodel.Shared.AUSZUG.BEZ;
using abx.TEROffice.DataReader.Datamodel.Shared.AUSZUG.PERSON;

namespace abx.TEROffice.DataReader.BLL
{
    public class Modelbuilder
    {
        public List<Dienstbarkeit> FillModel(List<LROCC> listOfLroccs)
        {
            var listOfDienstbarkeiten = new List<Dienstbarkeit>();
            foreach (var dbk in listOfLroccs)
            {
                var dienstbarkeit = new Dienstbarkeit
                {
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
                    Beziehungen = FillRelation(dbk.BEZ.BEZOCC)
                };
                listOfDienstbarkeiten.Add(dienstbarkeit);
            }

            return listOfDienstbarkeiten;
        }

        private List<Beziehung> FillRelation(List<BEZOCC> listOfBezoccs)
        {
            var listOfRelations = new List<Beziehung>();
            foreach (var bez in listOfBezoccs)
            {
                var beziehung = new Beziehung
                {
                    Status = bez.ST,
                    Gründungsdatum = bez.GDTX,
                    Gründungsnummer = bez.GNR,
                    Grundstück = FillGrundstueck(bez.GRUNDST),
                    Person = FillPerson(bez.PERSON)
                };
                listOfRelations.Add(beziehung);
            }

            return listOfRelations;
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
                    Rechtsform = pers.INHOCC.RFORMTXT,
                    Sitz = pers.INHOCC.SITZ,
                    Strasse = pers.STRASSE,
                    Plz = pers.PLZ,
                    Ort = pers.ORT,
                    Land = pers.LAND,
                    Geburtsort = pers.BORT
                };
                return person;
            }
            else
            {
                return null;
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
                    Grundstückart = grundst.GRART,
                    Egrid = grundst.EGRID_FOR_KSA,
                    Grundbuchname = grundst.GRGBTXT
                };

                return grundstueck;
            }
            else
            {
                return null;
            }


        }
    }
}

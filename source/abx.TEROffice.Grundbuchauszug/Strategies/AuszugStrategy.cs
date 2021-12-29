using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using abx.TEROffice.DocumentProcessing.Strategies.Interfaces;
using abx.TEROffice.WordGenerator.Interfaces;
using abx.TEROffice.WordGenerator.Strategies;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Strategies
{
    public class AuszugStrategy : IWordStrategy
    {
        public void ProceedWord(string dataFileName, string wordTemplate, IData dataReader, IWordGeneratorContext wordGeneratorContext, ITextbausteinFactory dienstbarkeitFactory, IWordFactory auszugFactory, PathHelper paths)
        {
            try
            {
                CreateOuputWord(paths, wordTemplate);
                GenerateAuszug(dataFileName,wordTemplate,dataReader,wordGeneratorContext,dienstbarkeitFactory,auszugFactory,paths);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void GenerateAuszug(string dataFileName, string wordTemplate,IData dataReader, IWordGeneratorContext wordGeneratorContext, ITextbausteinFactory dienstbarkeitFactory, IWordFactory auszugFactory, PathHelper paths)
        {
            
            using (WordprocessingDocument doc =
                WordprocessingDocument.Open(paths.GetWordOutputPath(), true))
            {
                
                var document = auszugFactory.CreateWord(doc, ReadData(dataFileName, paths, dataReader), dienstbarkeitFactory);

                wordGeneratorContext.SetStrategy(new SaveAuszugStrategy());
                wordGeneratorContext.SaveWord(doc);
                wordGeneratorContext.Open(paths.GetWordOutputPath());

            }
        }

        private void CreateOuputWord(PathHelper paths, string wordTemplate)
        {
            try
            {
                if (!File.Exists(paths.GetWordOutputPath()))
                {
                    File.Copy(paths.GetWordTemplatePath(wordTemplate), paths.GetWordOutputPath());
                }
            }
            catch (Exception e)
            {
                throw new TerofficeTechnicalException(e, "File konnte nicht kopiert werden.");
            }


        }

        private DataReader.Businessmodel.Grundbuchauszug ReadData(string dataFileName, PathHelper paths, IData dataReader)
        {
            try
            {
                return dataReader.GetAuszug(paths.GetDataFilePath() + dataFileName);
            }
            catch (Exception e)
            {
                throw new TerofficeTechnicalException(e, "File nicht gefunden");
            }

        }
    }
}

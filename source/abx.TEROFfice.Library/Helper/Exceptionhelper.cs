using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace abx.TEROFfice.Library.Helper
{
    public class Exceptionhelper
    {
        public void HandleException(Exception e, string[] paramList)
        {
            var text = ExctractExceptionText(e);
            var logDir = ConfigurationManager.AppSettings["ErrorLogPath"];
            if (!File.Exists(logDir))
            {
                var stream = File.Create(logDir);
                stream.Close();
            }
            File.AppendAllText(logDir ?? (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ErrorLog.txt"), Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " [" + String.Join(" ", paramList) + "] Error: " + text);

        }

        private string ExctractExceptionText(Exception exc)
        {
            string exceptionText = "";

            if (exc.GetType() == typeof(TERofficeException))
            {
                exceptionText = exc.Message;
            }
            else
            {
                if (exc.InnerException != null)
                {
                    exceptionText += "Inner Exception Type: " + Environment.NewLine;
                    exceptionText += exc.InnerException.GetType().ToString() + Environment.NewLine;
                    exceptionText += "Inner Exception: ";
                    exceptionText += exc.InnerException.Message + Environment.NewLine;
                    exceptionText += "Inner Source: ";
                    exceptionText += exc.InnerException.Source + Environment.NewLine;
                    if (exc.InnerException.StackTrace != null)
                    {
                        exceptionText += "Inner Stack Trace: " + Environment.NewLine;
                        exceptionText += exc.InnerException.StackTrace + Environment.NewLine;
                    }
                }
                exceptionText += "Exception Type: ";
                exceptionText += exc.GetType().ToString() + Environment.NewLine;
                exceptionText += "Exception: " + exc.Message + Environment.NewLine;
                exceptionText += "Stack Trace: " + Environment.NewLine;
                if (exc.StackTrace != null)
                {
                    exceptionText += exc.StackTrace + Environment.NewLine;
                    exceptionText += Environment.NewLine;
                }
            }
            return exceptionText;
        }
    }
}

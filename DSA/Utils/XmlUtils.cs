using System;
using System.IO;
using System.Xml.Serialization;
using Dsa.DataModels;

namespace Dsa.Utils
{
    public class XmlUtils
    {

        public static QuotesXml ReadXML(string filename)
        {
            XmlSerializer reader = new XmlSerializer(typeof(QuotesXml));
            StreamReader file = null;
            QuotesXml quotesXml = new QuotesXml();
            try
            {
                using (file = new StreamReader(filename))
                {
                    quotesXml = (QuotesXml)reader.Deserialize(file);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("Error:" + ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
            return quotesXml;
        }

        public static void WriteXML(string filename, QuotesXml quotesXml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(QuotesXml));
            TextWriter writer = null;

            try
            {
                using (writer = new StreamWriter(filename))
                {
                    ser.Serialize(writer, quotesXml);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("Error:" + ex);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}

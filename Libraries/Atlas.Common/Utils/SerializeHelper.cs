using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Atlas.Common.Utils
{
    public static class SerializeHelper
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string SerializeObject<T>(this T toSerialize)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(toSerialize.GetType());
                using (var textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        public static T DeSerializeObject<T>(this object serializedText)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var deserialize = (T)serializer.Deserialize(new StringReader(serializedText.ToString()));
                return deserialize;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        public static XmlDocument SerializeToXmlDocument<T>(this T input)
        {
            try
            {
                var ser = new XmlSerializer(input.GetType());
                XmlDocument xd;
                using (var memStm = new MemoryStream())
                {
                    ser.Serialize(memStm, input);
                    memStm.Position = 0;
                    var settings = new XmlReaderSettings { IgnoreWhitespace = true };

                    using (var xtr = XmlReader.Create(memStm, settings))
                    {
                        xd = new XmlDocument();
                        xd.Load(xtr);
                    }
                }
                return xd;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        public static string SerializeToJson<T>(this T input)
        {
            try
            {
                if (input == null) return "";
                var json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(input);
                return json;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw ex;
            }
        }

        public static T DeserilizeJson<T>(this string serilizedText)
        {
            try
            {
                return new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<T>(serilizedText);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw;
            }
        }
    }
}
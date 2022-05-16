using System;
using System.Collections.Generic;

namespace FacebookTest.Utilities
{
    public class Properties
    {
        private static Dictionary<Enum, string> configProperties = new Dictionary<Enum, string>()
       {
            { Property.Url, "http://www.facebook.com" },
            { Property.BrowserType, "chrome" },
            { Property.TestDataXmlFolder, "/Users/harishabuddhiraju/Projects/FacebookTest/FacebookTest/TestDataXml/" },
            { Property.LogsFolder, "/Users/harishabuddhiraju/Desktop/" },
            { Property.ReportsFolder, "/Users/harishabuddhiraju/Desktop/" },
            //{ Property.LogsFolder, "/Users/harishabuddhiraju/Projects/FacebookTest/FacebookTest/Logs/"},
            //{  Property.ExtentReportsFolder, "/Users/harishabuddhiraju/Projects/FacebookTest/FacebookTest/Reports/"}
        };

        public static string GetPropertry(Enum propertyName)
        {
            string value;
            configProperties.TryGetValue(propertyName, out value);
            return value;
        }
    }
    public enum Property
    {
        Url,
        BrowserType,
        TestDataXmlFolder,
        LogsFolder,
        ReportsFolder
    }
}

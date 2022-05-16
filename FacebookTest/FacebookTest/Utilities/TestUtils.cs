using System.IO;
using System.Xml.Serialization;
using System;

namespace FacebookTest.Utilities
{
	public class TestUtils
	{
		public TestUtils()
		{
		}

		public static void XMLSerializer<T>(T t, string xmlFile) where T : new()
		{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			using (var stream = new FileStream(xmlFile, FileMode.Create))
			{
				xmlSerializer.Serialize(stream, t);
			}

		}

		public static T XmlDeserialize<T>(string xmlFile) where T : class, new()
		{
			T t = default(T);
			if (File.Exists(xmlFile))
			{
				try
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
					//t = Activator.CreateInstance<T>();
					using (var stream = new FileStream(xmlFile, FileMode.Open))
					{
						t = (T)xmlSerializer.Deserialize(stream);
					}
					return t;
				}
				catch (Exception e)
				{

				}
			}
			return t;
		}

	}
}

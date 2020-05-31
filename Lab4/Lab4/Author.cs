using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace Lab4
{
    public class Author: IXmlSerializable
    {
		private string _name;
		private string _surname;
		private DateTime _birthday;

		public string Name { get { return _name; } set { _name = value; } }
		public string Surname { get { return _surname; } set { _surname = value; } }
		public DateTime Birthday { get { return _birthday; } set { _birthday = value; } }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Name":
                            reader.Read();
                            _name = reader.Value;
                            break;

                        case "Surname":
                            reader.Read();
                            _surname = reader.Value;
                            break;

                        case "Birthday":
                            reader.Read();
                            _birthday = DateTime.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Author"))
                {
                    break;
                }
            }
        }

        public static List<Author> ReadAuthorsList(string fileName)
        {
            List<Author> authors = new List<Author>();
            if (File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {                    
                    reader.MoveToContent();
                    while (reader.Read())
                    {                       
                        if (reader.IsStartElement() && !reader.Name.Equals("Authors"))
                        {
                            Author author = new Author();
                            author.ReadXml(reader);
                            authors.Add(author);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return authors;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Author");
            writer.WriteElementString("Name", _name);
            writer.WriteElementString("Surname", _surname);
            writer.WriteElementString("Birthday", _birthday.ToString());
            writer.WriteEndElement();
        }

        public static void WriteAuthorsToFile(string fileName, List<Author> authors)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Authors");
            authors.ForEach(author =>
            {
                author.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public override string ToString()
        {
            return $"{_name} {_surname} {_birthday.Date.ToString("dd/MM/yyyy")}";
        }

        public XmlSchema GetSchema()
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4
{
	public class Journal : IXmlSerializable
	{
		private Periodicity _periodicity;
		private string _journalName;
		private List<Article> _articles = new List<Article>();
		private int _pagesNumber = 0;
		private int _authorsNumber = 0;

		public Periodicity Periodicity { get { return _periodicity; } set { _periodicity = value; } }
		public string JournalName { get { return _journalName; } set { _journalName = value; } }
		public List<Article> Articles { get { return _articles; } set { _articles = value; CalculateNumOfPagesAndAuthors(); } }
		public int PagesNumber { get { return _pagesNumber; } set { _pagesNumber = value; } }

		public void AddArticle(Article article)
		{
			if (_articles == null)
			{
				_articles = new List<Article>();
			}
			_articles.Add(article);
			_pagesNumber += article.PagesNum;
			_authorsNumber++;
		}

		public void CalculateNumOfPagesAndAuthors()
		{
			_pagesNumber = 0;
			_authorsNumber = 0;
			if (_articles != null)
			{
				_articles.ForEach(article =>
				{
					_pagesNumber += article.PagesNum;
				});
				_authorsNumber = _articles.Count;
			}
		}

		public void ReadXml(XmlReader reader)
		{
			reader.MoveToContent();
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "JournalName":
							reader.Read();
							_journalName = reader.Value;
							break;

						case "Periodicity":
							reader.Read();
							_periodicity = (Periodicity)Enum.Parse(typeof(Periodicity), reader.Value);
							break;

						case "Articles":
							_articles = Article.ReadArticles(reader);
							CalculateNumOfPagesAndAuthors();
							break;
					}
				}
				if (reader.Name.Equals("Journal"))
				{
					break;
				}
			}
		}

		public static List<Journal> ReadJournalList(string fileName)
		{
			List<Journal> journals = new List<Journal>();
			if (File.Exists(fileName))
			{
				using (XmlReader reader = XmlReader.Create(fileName))
				{
					reader.MoveToContent();
					while (reader.Read())
					{
						if (reader.IsStartElement() && !reader.Name.Equals("Journals"))
						{
							Journal journal = new Journal();
							journal.ReadXml(reader);
							journals.Add(journal);
						}
						else
						{
							break;
						}
					}
				}
			}
			return journals;
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("Journal");
			writer.WriteElementString("JournalName", _journalName);
			writer.WriteElementString("Periodicity", _periodicity.ToString());
			writer.WriteStartElement("Articles");
			if (Articles != null)
			{
				Articles.ForEach(article =>
				{
					article.WriteXml(writer);
				});
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public static void WriteJournalsToFile(string fileName, List<Journal> journals)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.OmitXmlDeclaration = false;
			settings.NewLineOnAttributes = true;
			settings.ConformanceLevel = ConformanceLevel.Auto;

			XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
			xmlWriter.WriteStartElement("Journals");
			journals.ForEach(journal =>
			{
				journal.WriteXml(xmlWriter);
			});
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		public override string ToString()
		{
			return $"Name: {_journalName}\npages number: {_pagesNumber}\nAuthors number: {_authorsNumber}\nPeriodicity: {Enum.GetName(typeof(Periodicity), _periodicity)}";
		}

		public string ToShortString()
		{
			return $"Name: {_journalName} Total pages number: {_pagesNumber}";
		}

		public XmlSchema GetSchema()
		{
			return null;
		}
	}
}

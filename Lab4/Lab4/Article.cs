using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4
{
    public class Article: IXmlSerializable
	{
		private Author _authorOfArticle;
		private string _articleName;
		private int _pagesNum;
		private int _fee;

		public Author AuthorOfArticle { get { return _authorOfArticle; } set { _authorOfArticle = value; } }
		public string ArticleName { get { return _articleName; } set { _articleName = value; } }
		public int PagesNum { get { return _pagesNum; } set { _pagesNum = value; } }
		public int Fee { get { return _fee; } set { _fee = value; } }

        
        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Author":
                            _authorOfArticle = new Author();
                           _authorOfArticle.ReadXml(reader);
                            break;

                        case "ArticleName":
                            reader.Read();
                            _articleName = reader.Value;
                            break;

                        case "Fee":
                            reader.Read();
                            _fee = int.Parse(reader.Value);
                            break;

                        case "PagesNum":
                            reader.Read();
                            _pagesNum = int.Parse(reader.Value);
                            break;
                    }
                }

                if (reader.Name.Equals("Article"))
                {
                    break;
                }
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Article");
            _authorOfArticle.WriteXml(writer);
            writer.WriteElementString("ArticleName", _articleName);
            writer.WriteElementString("PagesNum", _pagesNum.ToString());
            writer.WriteElementString("Fee", _fee.ToString());
            writer.WriteEndElement();
        }

        public static List<Article> ReadArticles(XmlReader reader)
        {
            List<Article> articles = new List<Article>();
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement() && !reader.Name.Equals("Articles"))
                {
                    Article article = new Article();
                    article.ReadXml(reader);
                    articles.Add(article);
                }
                else
                {
                    break;
                }

            }
            return articles;
        }

        public override string ToString()
        {
            return $"{_authorOfArticle} {_articleName} {_pagesNum} {_fee}";
        }

        public XmlSchema GetSchema()
        {
            return null;
        }
    }
}

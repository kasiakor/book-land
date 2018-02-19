using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Bookland.Models
{
    public static class DataManager
    {
        /// <summary>
        /// Returns one block of book items
        /// </summary>
        /// <param name="BlockNumber">Starting from 1</param>
        /// <param name="BlockSize">Items count in a block</param>
        /// <returns></returns>
        public static List<Bookset> GetBooks(int BlockNumber, int BlockSize)
        {
            int startIndex = (BlockNumber - 1) * BlockSize;

            var filePath = AppDomain.CurrentDomain.BaseDirectory + "testData.xml";
            var doc = XDocument.Load(filePath);

            var books = (from p in doc.Descendants("book")
                         select new Bookset
                         {
                             ID = p.Attributes("id").Single().Value,
                             Author = p.Element("author").Value,
                             Title = p.Element("title").Value,
                             Genre = p.Element("genre").Value,
                             Price = p.Element("price").Value,
                             Language = p.Element("language").Value,
                             PublishDate = p.Element("publish_date").Value,
                             Description = p.Element("description").Value,
                         }).Skip(startIndex).Take(BlockSize).ToList();

            return books;
        }
    }

    public class Bookset
    {
        public string ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
    }

    public class JsonModel
    {
        public string HTMLString { get; set; }
        public bool NoMoreData { get; set; }
    }
}
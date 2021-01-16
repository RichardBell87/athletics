using System;
using System.Linq;

namespace Athletics.Memory
{
    public class NewsRepository : INewsRepository
    {

        private readonly News[] news = new[]
        {
            new News(1, "First news", "Some description by first news", "Some body text by first news", "Some tag by firs new"),
            new News(2, "Second news", "Some description by secont news", "Some body text by second news", "Some tag by second news"),
            new News(3, "Third news", "Some description by third news", "Some body text by third news", "Some tag by third news")
        };

        //public News[] GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public News[] GetAllByTitle(string titlePart)
        //{
        //    throw new NotImplementedException();
        //}

        //public News[] GetAllByDescription(string descriptionPart)
        //{
        //    throw new NotImplementedException();
        //}

        //public News[] GetAllByBodyText(string bodytextPart)
        //{
        //    throw new NotImplementedException();
        //}

        public News[] GetAllByTag(string tagPart)
        {
            return news.Where(news => news.Tag.Contains(tagPart)).ToArray();
        }
        
    }
}
 
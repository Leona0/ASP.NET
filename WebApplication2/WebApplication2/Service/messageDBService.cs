using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Service
{
    public class messageDBService
    {
        public WebApplication2.Models.messageEntities1 db = new Models.messageEntities1();

        public List<Article> GetData()
        {
            return (db.Article.ToList());
        }

        public void  DBCrate(string Article_title , string Content)
        {
            Article NEWData = new Article();
            NEWData.Title = Article_title;
            NEWData.Content = Content;
            NEWData.time = DateTime.Now;


            db.Article.Add(NEWData);

            db.SaveChanges();
        }
    }
}
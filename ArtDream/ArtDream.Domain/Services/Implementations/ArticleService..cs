using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArtDream.Domain.Services.Interfaces;
using ArtDream.Model;

namespace ArtDream.Domain.Services.Implementations
{
    public class ArticleService:ServiceBase,IArticleService
    {
        public IList<Article> GetArticles()
        {
            var query = from a in DataContext.Articles
                                              select a;
            return query.ToList();
        }

        public Article GetArticle(int id)
        {
            return DataContext.Articles.FirstOrDefault(d=>d.ID==id);
        }
        public void Create(Article item)
        {
            item.CreatedDate = DateTime.Now;
            DataContext.Articles.AddObject(item);
            DataContext.SaveChanges();
        }
        public void Update(Article item)
        {
            var article = DataContext.Articles.FirstOrDefault(d => d.ID == item.ID);
            article.Title = item.Title;
            article.Type = item.Type;
            article.Published = item.Published;
            article.Content = item.Content;
            DataContext.SaveChanges();
        }
        public void Delete(int articleId)
        {
            var article = DataContext.Articles.FirstOrDefault(d => d.ID == articleId);
            if (article != null)
            {
                DataContext.Articles.DeleteObject(article);
            }
            DataContext.SaveChanges();
        }
    }
}

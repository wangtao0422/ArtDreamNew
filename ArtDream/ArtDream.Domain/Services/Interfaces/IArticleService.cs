using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArtDream.Model;

namespace ArtDream.Domain.Services.Interfaces
{
    public interface IArticleService
    {
        IList<Article> GetArticles();
         Article GetArticle(int id);
        void Create(Article item);
        void Update(Article item);
        void Delete(int articleId);
    }
}

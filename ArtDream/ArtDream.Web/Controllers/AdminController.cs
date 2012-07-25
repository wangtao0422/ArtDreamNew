using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using ArtDream.Domain.Services.Interfaces;
using ArtDream.Web.Helpers;
using ArtDream.Web.Models;

namespace ArtDream.Web.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private readonly IArticleService _articleService;

        public AdminController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        #region Arcicle
        public ActionResult Index()
        {
           return RedirectToAction("Articles");
        }

        public ActionResult Articles()
        {
            return View();
        }

       [GridAction]
        public ActionResult AjaxLoadingArticles()
        {
            var items = _articleService.GetArticles().Select(obj => ArticleHelper.ConvertObjToModel(obj)).ToList();
            return View(new GridModel<ArticleListViewModel>
            {
                Data = items
            });
        }

       [Authorize]
       public PartialViewResult ArticleEditor(int id)
       {
           var viewModel = new ArticleViewModel() { Id = 0, Published = true };
           var item = _articleService.GetArticle(id);
           if (item != null)
           {
               viewModel.Id = item.ID;
               viewModel.Title = item.Title;
               viewModel.Type = item.Type;
               viewModel.Content = item.Content;
               viewModel.Published = item.Published;
           }
           return PartialView("ArticleEditor", viewModel);
       }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtDream.Web.Models;
using ArtDream.Model;
using Telerik.Web.Mvc.UI;
using System.Web.Mvc;

namespace ArtDream.Web.Helpers
{
    public static class ArticleHelper
    {
        public static ArticleListViewModel ConvertObjToModel(Article obj)
        {
            var model = new ArticleListViewModel()
            {
                Id = obj.ID,
                Title = obj.Title,
                Type = obj.Type,
                Published = obj.Published,
                Content = obj.Content
            };

            switch (model.Type)
            {
                case (int)ArticleType.Notice:
                    model.TypeName = "公告";
                    break;
                case (int)ArticleType.Event:
                    model.TypeName = "赛事花絮";
                    break;
                case (int)ArticleType.Show:
                    model.TypeName = "才艺表演";
                    break;
                case (int)ArticleType.Skill:
                    model.TypeName = "技能特长";
                    break;
                default:
                    model.TypeName = "公告";
                    break;
            }
            return model;
        }

        public static List<SelectListItem> GenerateArticleTypes(int articleType)
        {
            var types= Enum.GetValues(typeof(ArticleType));
            var items=new List<SelectListItem>();
            foreach (var type in types)
            {
                var item=new SelectListItem() { 
                    Value=((int)type).ToString(),
                    Text=type.ToString()
                };

                switch ((int)type)
                {
                    case (int)ArticleType.Notice:
                        item.Text = "公告";
                        break;
                    case (int)ArticleType.Event:
                        item.Text = "赛事花絮";
                        break;
                    case (int)ArticleType.Show:
                        item.Text = "才艺表演";
                        break;
                    case (int)ArticleType.Skill:
                        item.Text = "技能特长";
                        break;
                    default:
                        item.Text = "公告";
                        break;
                }
                if(articleType==(int)type)
                {
                    item.Selected=true;
                }
                items.Add(item);
            }
            return items;

        }
    }
}
using NewsArticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsArticlesWeb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var objArticle = new Article();
            objArticle.CategoryId = 1;
            objArticle.Title = "Web Title";
            objArticle.Body = "Web Article body here";
            objArticle.PublishDate = DateTime.Now;
            ArticleData objArticleData = new ArticleData();
            objArticleData.InsertArticle(objArticle);
        }
    }
}
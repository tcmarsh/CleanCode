using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCode
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string userName;
        //private IList<Right> rights;
        private IList<Article> viewedArticles;
        private IList<Article> editedArticles;
        private IList<Article> authoredArticles;

        public User()
        {
 
        }

        public void TrackViewed(Article article)
        {
            viewedArticles.Add(article);
        }

        public void TrackEdited(Article article)
        {
            editedArticles.Add(article);
        }

        public void TrackAuthored(Article article)
        {
            authoredArticles.Add(article);
        }

        public IList<Article> ViewedArticles
        { get { return viewedArticles; } }

        public IList<Article> EditedArticles
        { get { return editedArticles; } }

        public IList<Article> AuthoredArticles
        { get { return authoredArticles; } }
    }
}
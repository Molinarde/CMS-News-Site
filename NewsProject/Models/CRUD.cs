using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Models
{
    public static class CRUD
    {
        static NewsRepository repository = new NewsRepository();
        static List<News> listNews = new List<News>
        {
            new News{Category = "test1",ShortDescription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://pbs.twimg.com/media/CNPko1yWEAALPxL.jpg" },
            new News{Category = "test1",ShortDescription ="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://pbs.twimg.com/media/CNPko1yWEAALPxL.jpg" },
            new News{Category = "test2",ShortDescription ="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://cdn5.f-cdn.com/contestentries/140508/2149008/54b690fab47cd_thumb900.jpg"},
            new News{Category = "test2",ShortDescription ="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://cdn5.f-cdn.com/contestentries/140508/2149008/54b690fab47cd_thumb900.jpg"},
            new News{Category = "test3",ShortDescription ="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://png.pngtree.com/templates_detail/20181023/technology-logo-template-png_37586.jpg"},
            new News{Category = "test3",ShortDescription ="Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa.", Img = "https://png.pngtree.com/templates_detail/20181023/technology-logo-template-png_37586.jpg"}
        };

       

        public static void AddFirstData()
        {
            var db = repository.db.News.ToList();
            for (int i = 0; i <= db.Count; i++)
            {
                var newsObject = repository.db.News.FirstOrDefault(p => p.Category == null);
                if (newsObject != null)
                {

                    newsObject.Category = "test1";
                    repository.db.News.Update(newsObject);
                    repository.db.SaveChanges();
                }
                else
                    break;
            }
            
        }
    }
}

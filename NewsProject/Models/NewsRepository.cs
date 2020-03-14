using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Models
{
    public class NewsRepository : IRepository
    {
        public newsdbContext db = new newsdbContext();
       

        public IEnumerable<News> News()
        {
            return db.News;
        }
    }
}

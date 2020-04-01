using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2Starter.Data
{
    interface IDataService
    {
        void Add(BlogPost blogPost);

        IEnumerable<BlogPost> GetPosts();
    }
}

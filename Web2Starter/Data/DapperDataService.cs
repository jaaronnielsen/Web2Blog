using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2Starter.Data
{
    public class DapperDataService : IDataService
    {
        private readonly string connectionString;
        public DapperDataService(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Add(BlogPost blogPost)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO blogpost(title, body) values (@title, @body);", new { title = blogPost.Title, body = blogPost.Body });
            }
        }

        public IEnumerable<BlogPost> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}

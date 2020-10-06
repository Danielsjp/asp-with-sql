using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Started.Models;
using System.Data.SqlClient;

namespace Started.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {




        }

        public DbSet<Started.Models.TodoItem> TodoItems { get; set; }

        public DbSet<Started.Models.Employees> Employees { get; set; }

       
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Shared.Models;

namespace TaskManager.Server.Data
{
    public class TaskManagerServerContext : DbContext
    {
        public TaskManagerServerContext (DbContextOptions<TaskManagerServerContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManager.Shared.Models.TaskItem> TaskItem { get; set; }
    }
}
